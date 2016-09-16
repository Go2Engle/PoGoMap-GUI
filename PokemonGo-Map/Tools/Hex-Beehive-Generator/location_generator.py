import math
import argparse
import LatLon
import itertools
import os

parser = argparse.ArgumentParser()
parser.add_argument("-lat", "--lat", help="latitude", type=float, required=True)
parser.add_argument("-lon", "--lon", help="longitude", type=float, required=True)
parser.add_argument("-st", "--steps", help="steps", default=5, type=int)
parser.add_argument("-lp", "--leaps", help="like 'steps' but for workers instead of scans", default=3, type=int)
parser.add_argument("-o", "--output", default="../../beehive.sh", help="output file for the script")
parser.add_argument("-t", "--thread", default=1, help="Number of accounts and threads per worker")
parser.add_argument("-or", "--output_raw", default="../../beehive.txt", help="output file for the raw coords txt")
parser.add_argument("--accounts", help="List of your accounts, in csv [username],[password] format", default=None)
parser.add_argument("--auth", help="Auth method (ptc or google)", default="ptc")
parser.add_argument("-v", "--verbose", help="Print lat/lng to stdout for debugging", action='store_true', default=False)
parser.add_argument("--windows", help="Generate a bat file for Windows", action='store_true', default=False)
parser.add_argument("--installdir", help="Installation directory (only used for Windows)", type=str, default="C:\\PokemonGo-Map")

preamble = "#!/usr/bin/env bash"
server_template = "nohup python runserver.py -os -l '{lat}, {lon}' &\n" #this is the output template for linux
worker_template = "sleep 0.5; nohup python runserver.py -ns -l '{lat}, {lon}' -st {steps} {auth}&\n" # so is this
auth_template = "-a {} -u {} -p '{}' "  # unix people want single-quoted passwords - for threading reasons whitespace after ' before ""

R = 6378137.0
r_hex = 52.5  # probably not correct

args = parser.parse_args()
steps = args.steps
rings = args.leaps

if args.windows:
    # ferkin Windows
    preamble = "taskkill /IM python.exe /F"
    pythonpath = "C:\\Python27\\Python.exe"
    branchpath = args.installdir
    executable = args.installdir + "\\runserver.py"
    auth_template = '-a {} -u {} -p "{}" '  # windows people want double-quoted passwords -fook windows again!
    actual_worker_params = '{auth}-ns -l "{lat}, {lon}" -st {steps}'
    worker_template = 'Start "{{threadname}}" /d {branchpath} /MIN {pythonpath} {executable} {actual_params}\nping 127.0.0.1 -n 6 > nul\n\n'.format( #these are the templates for windows stuff
        branchpath=branchpath, pythonpath=pythonpath, executable=executable, actual_params = actual_worker_params
    )
    actual_server_params = '-os -l "{lat}, {lon}"'
    server_template = 'Start "Server" /d {branchpath} /MIN {pythonpath} {executable} {actual_params}\nping 127.0.0.1 -n 6 > nul\n\n'.format(
        branchpath=branchpath, pythonpath=pythonpath, executable=executable, actual_params = actual_server_params # ends here
    )
    if args.output == "../../beehive.sh":
        args.output = "../../beehive.bat"

if args.accounts:
    print("Reading usernames/passwords from {}".format(args.accounts))
    account_fh = open(args.accounts)
    account_fields = [line.split(",") for line in account_fh]
    accounts = [auth_template.format(args.auth, line[0].strip(), line[1].strip()) for line in account_fields]
else:
    accounts = [""]

print("Generating beehive script to {}".format(args.output))
output_fh = file(args.output, "wb")
os.chmod(args.output, 0o755)
output_fh.write(preamble + "\n")
output_fh.write(server_template.format(lat=args.lat, lon=args.lon))

print("Generating raw coordinates to {}".format(args.output_raw))
coords_fh = file(args.output_raw, 'wb')

w_worker = (2 * steps - 1) * r_hex #convert the step limit of the worker into the r radius of the hexagon in meters?
d = 2.0 * w_worker / 1000.0 #convert that into a diameter and convert to gps scale
d_s = d

brng_s = 0.0
brng = 0.0
mod = math.degrees(math.atan(1.732 / (6 * (steps - 1) + 3)))

total_workers = (((rings * (rings - 1)) *3) + 1) # this mathamtically calculates the total number of workers

locations = [LatLon.LatLon(LatLon.Latitude(0), LatLon.Longitude(0))] * total_workers #this initialises the list
locations[0] = LatLon.LatLon(LatLon.Latitude(args.lat), LatLon.Longitude(args.lon)) #set the latlon for worker 0 from cli args


turns = 0               # number of turns made in this ring (0 to 6)
turn_steps = 0          # number of cells required to complete one turn of the ring
turn_steps_so_far = 0   # current cell number in this side of the current ring


for i in range(1, total_workers):
    if turns == 6 or turn_steps == 0:
        # we have completed a ring (or are starting the very first ring)
        turns = 0
        turn_steps += 1
        turn_steps_so_far = 0

    if turn_steps_so_far == 0:
        brng = brng_s
        loc = locations[0]
        d = turn_steps * d
    else:
        loc = locations[0]
        C = math.radians(60.0)#inside angle of a regular hexagon
        a = d_s / R * 2.0 * math.pi #in radians get the arclength of the unit circle covered by d_s
        b = turn_steps_so_far * d_s / turn_steps / R * 2.0 * math.pi #percentage of a
         #the first spherical law of cosines gives us the length of side c from known angle C
        c = math.acos(math.cos(a) * math.cos(b) + math.sin(a) * math.sin(b) * math.cos(C))
         #turnsteps here represents ring number because yay coincidence always the same. multiply by derived arclength and convert to meters
        d = turn_steps * c * R / 2.0 / math.pi
        #from the first spherical law of cosines we get the angle A from the side lengths a b c
        A = math.acos((math.cos(b) - math.cos(a) * math.cos(c)) / (math.sin(c) * math.sin(a))) 
        brng = 60 * turns + math.degrees(A)

    loc = loc.offset(brng + mod, d)
    locations[i] = loc
    d = d_s

    turn_steps_so_far += 1
    if turn_steps_so_far >= turn_steps:
        # make a turn
        brng_s += 60.0
        brng = brng_s
        turns += 1
        turn_steps_so_far = 0

#if threading is desired (-t flag) cycle through all accounts and merge them into an array (do this anyway because otherwise we need an if statement below)

#make a list of exactly the right number of accounts
accountsNeeded = [(j) for i,j in itertools.izip(range(0,int(args.thread)*total_workers),itertools.cycle(accounts))]
#group those accounts, concatenate the details into a single string per worker
accountStack=[""]*total_workers
for i in range(0,total_workers):    
    for j in range(0,int(args.thread)):
        accountStack[i] = accountStack[i] + accountsNeeded[i*int(args.thread)+j]

# if accounts list was provided, match each location with an account
# reusing accounts if required

location_and_auth = [(i, j) for i, j in itertools.izip(locations, accountStack)]

for i, (location, auth) in enumerate(location_and_auth):
    threadname = "Movable{}".format(i)
    output_fh.write(worker_template.format(lat=location.lat, lon=location.lon, steps=args.steps, auth=auth, threadname=threadname))
    coords_fh.write(str(location.lat) + ", " + str(location.lon) + "\n")
    if args.verbose:
        print("{}, {}".format(location.lat, location.lon))
