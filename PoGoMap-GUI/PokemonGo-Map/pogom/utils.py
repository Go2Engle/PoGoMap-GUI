#!/usr/bin/python
# -*- coding: utf-8 -*-

import sys
import configargparse
import os
import json
import logging
import shutil
import platform
import pprint
import time

from . import config

log = logging.getLogger(__name__)


def parse_unicode(bytestring):
    decoded_string = bytestring.decode(sys.getfilesystemencoding())
    return decoded_string


def verify_config_file_exists(filename):
    fullpath = os.path.join(os.path.dirname(__file__), filename)
    if not os.path.exists(fullpath):
        log.info('Could not find %s, copying default', filename)
        shutil.copy2(fullpath + '.example', fullpath)


def memoize(function):
    memo = {}

    def wrapper(*args):
        if args in memo:
            return memo[args]
        else:
            rv = function(*args)
            memo[args] = rv
            return rv
    return wrapper


@memoize
def get_args():
    # fuck PEP8
    configpath = os.path.join(os.path.dirname(__file__), '../config/config.ini')
    parser = configargparse.ArgParser(default_config_files=[configpath], auto_env_var_prefix='POGOMAP_')
    parser.add_argument('-a', '--auth-service', type=str.lower, action='append', default=[],
                        help='Auth Services, either one for all accounts or one per account: ptc or google. Defaults all to ptc.')
    parser.add_argument('-u', '--username', action='append', default=[],
                        help='Usernames, one per account.')
    parser.add_argument('-p', '--password', action='append', default=[],
                        help='Passwords, either single one for all accounts or one per account.')
    parser.add_argument('-w', '--workers', type=int,
                        help='Number of search worker threads to start. Defaults to the number of accounts specified.')
    parser.add_argument('-asi', '--account-search-interval', type=int, default=0,
                        help='Seconds for accounts to search before switching to a new account. 0 to disable.')
    parser.add_argument('-ari', '--account-rest-interval', type=int, default=7200,
                        help='Seconds for accounts to rest when they fail or are switched out')
    parser.add_argument('-ac', '--accountcsv',
                        help='Load accounts from CSV file containing "auth_service,username,passwd" lines')
    parser.add_argument('-l', '--location', type=parse_unicode,
                        help='Location, can be an address or coordinates')
    parser.add_argument('-j', '--jitter', help='Apply random -9m to +9m jitter to location',
                        action='store_true', default=False)
    parser.add_argument('-st', '--step-limit', help='Steps', type=int,
                        default=12)
    parser.add_argument('-sd', '--scan-delay',
                        help='Time delay between requests in scan threads',
                        type=float, default=10)
    parser.add_argument('-ld', '--login-delay',
                        help='Time delay between each login attempt',
                        type=float, default=5)
    parser.add_argument('-lr', '--login-retries',
                        help='Number of logins attempts before refreshing a thread',
                        type=int, default=3)
    parser.add_argument('-mf', '--max-failures',
                        help='Maximum number of failures to parse locations before an account will go into a two hour sleep',
                        type=int, default=5)
    parser.add_argument('-msl', '--min-seconds-left',
                        help='Time that must be left on a spawn before considering it too late and skipping it. eg. 600 would skip anything with < 10 minutes remaining. Default 0.',
                        type=int, default=0)
    parser.add_argument('-dc', '--display-in-console',
                        help='Display Found Pokemon in Console',
                        action='store_true', default=False)
    parser.add_argument('-H', '--host', help='Set web server listening host',
                        default='127.0.0.1')
    parser.add_argument('-P', '--port', type=int,
                        help='Set web server listening port', default=5000)
    parser.add_argument('-L', '--locale',
                        help='Locale for Pokemon names (default: {},\
                        check {} for more)'.
                        format(config['LOCALE'], config['LOCALES_DIR']), default='en')
    parser.add_argument('-c', '--china',
                        help='Coordinates transformer for China',
                        action='store_true')
    parser.add_argument('-m', '--mock', type=str,
                        help='Mock mode - point to a fpgo endpoint instead of using the real PogoApi, ec: http://127.0.0.1:9090',
                        default='')
    parser.add_argument('-ns', '--no-server',
                        help='No-Server Mode. Starts the searcher but not the Webserver.',
                        action='store_true', default=False)
    parser.add_argument('-os', '--only-server',
                        help='Server-Only Mode. Starts only the Webserver without the searcher.',
                        action='store_true', default=False)
    parser.add_argument('-nsc', '--no-search-control',
                        help='Disables search control',
                        action='store_false', dest='search_control', default=True)
    parser.add_argument('-fl', '--fixed-location',
                        help='Hides the search bar for use in shared maps.',
                        action='store_true', default=False)
    parser.add_argument('-k', '--gmaps-key',
                        help='Google Maps Javascript API Key',
                        required=True)
    parser.add_argument('--spawnpoints-only', help='Only scan locations with spawnpoints in them.',
                        action='store_true', default=False)
    parser.add_argument('-C', '--cors', help='Enable CORS on web server',
                        action='store_true', default=False)
    parser.add_argument('-D', '--db', help='Database filename',
                        default='pogom.db')
    parser.add_argument('-cd', '--clear-db',
                        help='Deletes the existing database before starting the Webserver.',
                        action='store_true', default=False)
    parser.add_argument('-np', '--no-pokemon',
                        help='Disables Pokemon from the map (including parsing them into local db)',
                        action='store_true', default=False)
    parser.add_argument('-ng', '--no-gyms',
                        help='Disables Gyms from the map (including parsing them into local db)',
                        action='store_true', default=False)
    parser.add_argument('-nk', '--no-pokestops',
                        help='Disables PokeStops from the map (including parsing them into local db)',
                        action='store_true', default=False)
    parser.add_argument('-ss', '--spawnpoint-scanning',
                        help='Use spawnpoint scanning (instead of hex grid). Scans in a circle based on step_limit when on DB', nargs='?', const='nofile', default=False)
    parser.add_argument('--dump-spawnpoints', help='dump the spawnpoints from the db to json (only for use with -ss)',
                        action='store_true', default=False)
    parser.add_argument('-pd', '--purge-data',
                        help='Clear pokemon from database this many hours after they disappear \
                        (0 to disable)', type=int, default=0)
    parser.add_argument('-px', '--proxy', help='Proxy url (e.g. socks5://127.0.0.1:9050)', action='append')
    parser.add_argument('-pxt', '--proxy-timeout', help='Timeout settings for proxy checker in seconds ', type=int, default=5)
    parser.add_argument('-pxd', '--proxy-display', help='Display info on which proxy beeing used (index or full) To be used with -ps', type=str, default='index')
    parser.add_argument('--db-type', help='Type of database to be used (default: sqlite)',
                        default='sqlite')
    parser.add_argument('--db-name', help='Name of the database to be used')
    parser.add_argument('--db-user', help='Username for the database')
    parser.add_argument('--db-pass', help='Password for the database')
    parser.add_argument('--db-host', help='IP or hostname for the database')
    parser.add_argument('--db-port', help='Port for the database', type=int, default=3306)
    parser.add_argument('--db-max_connections', help='Max connections (per thread) for the database',
                        type=int, default=5)
    parser.add_argument('--db-threads', help='Number of db threads; increase if the db queue falls behind',
                        type=int, default=1)
    parser.add_argument('-wh', '--webhook', help='Define URL(s) to POST webhook information to',
                        nargs='*', default=False, dest='webhooks')
    parser.add_argument('-gi', '--gym-info', help='Get all details about gyms (causes an additional API hit for every gym)',
                        action='store_true', default=False)
    parser.add_argument('--webhook-updates-only', help='Only send updates (pokémon & lured pokéstops)',
                        action='store_true', default=False)
    parser.add_argument('--wh-threads', help='Number of webhook threads; increase if the webhook queue falls behind',
                        type=int, default=1)
    parser.add_argument('--ssl-certificate', help='Path to SSL certificate file')
    parser.add_argument('--ssl-privatekey', help='Path to SSL private key file')
    parser.add_argument('-ps', '--print-status', action='store_true',
                        help='Show a status screen instead of log messages. Can switch between status and logs by pressing enter.', default=False)
    parser.add_argument('-sn', '--status-name', default=None,
                        help='Enable status page database update using STATUS_NAME as main worker name')
    parser.add_argument('-spp', '--status-page-password', default=None,
                        help='Set the status page password')
    parser.add_argument('-el', '--encrypt-lib', help='Path to encrypt lib to be used instead of the shipped ones')
    verbosity = parser.add_mutually_exclusive_group()
    verbosity.add_argument('-v', '--verbose', help='Show debug messages from PomemonGo-Map and pgoapi. Optionally specify file to log to.', nargs='?', const='nofile', default=False, metavar='filename.log')
    verbosity.add_argument('-vv', '--very-verbose', help='Like verbose, but show debug messages from all modules as well.  Optionally specify file to log to.', nargs='?', const='nofile', default=False, metavar='filename.log')
    verbosity.add_argument('-d', '--debug', help='Deprecated, use -v or -vv instead.', action='store_true')
    parser.set_defaults(DEBUG=False)

    args = parser.parse_args()

    if args.only_server:
        if args.location is None:
            parser.print_usage()
            print(sys.argv[0] + ": error: arguments -l/--location is required")
            sys.exit(1)
    else:
        # If using a CSV file, add the data into the username,password and auth_service arguments.
        # CSV file should have lines like "ptc,username,password".  Additional fields after that are ignored.
        if args.accountcsv is not None:
            with open(args.accountcsv, 'r') as f:
                for num, line in enumerate(f, 1):

                    # Ignore blank lines and comment lines
                    if len(line.strip()) == 0 or line.startswith('#'):
                        continue

                    # Split into fields
                    fields = line.split(",")

                    # Make sure it has at least 3 fields
                    if len(fields) < 3:
                        print(sys.argv[0] + ": Error parsing CSV file on line " + str(num) + ". Lines must be in the format '<method>,<username>,<password>'. Additional fields after those are ignored.")
                        sys.exit(1)

                    # Make sure none of the fields are blank
                    if len(fields[0]) == 0 or len(fields[1]) == 0 or len(fields[2]) == 0:
                        print(sys.argv[0] + ": Error parsing CSV file on line " + str(num) + ". Lines must be in the format '<method>,<username>,<password>'. Additional fields after those are ignored.")
                        sys.exit(1)

                    # Add the account to the list
                    args.auth_service.append(fields[0].strip())
                    args.username.append(fields[1].strip())
                    args.password.append(fields[2].strip())

        errors = []

        num_auths = len(args.auth_service)
        num_usernames = 0
        num_passwords = 0

        if len(args.username) == 0:
            errors.append('Missing `username` either as -u/--username, csv file using -ac, or in config')
        else:
            num_usernames = len(args.username)

        if args.location is None:
            errors.append('Missing `location` either as -l/--location or in config')

        if len(args.password) == 0:
            errors.append('Missing `password` either as -p/--password, csv file, or in config')
        else:
            num_passwords = len(args.password)

        if args.step_limit is None:
            errors.append('Missing `step_limit` either as -st/--step-limit or in config')

        if num_auths == 0:
            args.auth_service = ['ptc']

        num_auths = len(args.auth_service)

        if num_usernames > 1:
            if num_passwords > 1 and num_usernames != num_passwords:
                errors.append('The number of provided passwords ({}) must match the username count ({})'.format(num_passwords, num_usernames))
            if num_auths > 1 and num_usernames != num_auths:
                errors.append('The number of provided auth ({}) must match the username count ({})'.format(num_auths, num_usernames))

        if len(errors) > 0:
            parser.print_usage()
            print(sys.argv[0] + ": errors: \n - " + "\n - ".join(errors))
            sys.exit(1)

        # Fill the pass/auth if set to a single value
        if num_passwords == 1:
            args.password = [args.password[0]] * num_usernames
        if num_auths == 1:
            args.auth_service = [args.auth_service[0]] * num_usernames

        # Make our accounts list
        args.accounts = []

        # Make the accounts list
        for i, username in enumerate(args.username):
            args.accounts.append({'username': username, 'password': args.password[i], 'auth_service': args.auth_service[i]})

        # Make max workers equal number of accounts if unspecified, and disable account switching
        if args.workers is None:
            args.workers = len(args.accounts)
            args.account_search_interval = None

        # Disable search interval if 0 specified
        if args.account_search_interval == 0:
            args.account_search_interval = None

        # Make sure we don't have an empty account list after adding command line and CSV accounts
        if len(args.accounts) == 0:
            print(sys.argv[0] + ": Error: no accounts specified. Use -a, -u, and -p or --accountcsv to add accounts")
            sys.exit(1)

    return args


def now():
    # The fact that you need this helper...
    return int(time.time())


def i8ln(word):
    if config['LOCALE'] == "en":
        return word
    if not hasattr(i8ln, 'dictionary'):
        file_path = os.path.join(
            config['ROOT_PATH'],
            config['LOCALES_DIR'],
            '{}.min.json'.format(config['LOCALE']))
        if os.path.isfile(file_path):
            with open(file_path, 'r') as f:
                i8ln.dictionary = json.loads(f.read())
        else:
            log.warning('Skipping translations - Unable to find locale file: %s', file_path)
            return word
    if word in i8ln.dictionary:
        return i8ln.dictionary[word]
    else:
        log.debug('Unable to find translation for "%s" in locale %s!', word, config['LOCALE'])
        return word


def get_pokemon_data(pokemon_id):
    if not hasattr(get_pokemon_data, 'pokemon'):
        file_path = os.path.join(
            config['ROOT_PATH'],
            config['DATA_DIR'],
            'pokemon.min.json')

        with open(file_path, 'r') as f:
            get_pokemon_data.pokemon = json.loads(f.read())
    return get_pokemon_data.pokemon[str(pokemon_id)]


def get_pokemon_name(pokemon_id):
    return i8ln(get_pokemon_data(pokemon_id)['name'])


def get_pokemon_rarity(pokemon_id):
    return i8ln(get_pokemon_data(pokemon_id)['rarity'])


def get_pokemon_types(pokemon_id):
    pokemon_types = get_pokemon_data(pokemon_id)['types']
    return map(lambda x: {"type": i8ln(x['type']), "color": x['color']}, pokemon_types)


def get_encryption_lib_path(args):
    if args.encrypt_lib is not None:
        lib_path = args.encrypt_lib

        if not os.path.isfile(lib_path):
            err = "Could not find manually specified encryption library {}".format(lib_path)
            log.error(err)
            raise Exception(err)
    else:
        # win32 doesn't mean necessarily 32 bits
        if sys.platform == "win32" or sys.platform == "cygwin":
            if platform.architecture()[0] == '64bit':
                lib_name = "encrypt64bit.dll"
            else:
                lib_name = "encrypt32bit.dll"

        elif sys.platform == "darwin":
            lib_name = "libencrypt-osx-64.so"

        elif os.uname()[4].startswith("arm") and platform.architecture()[0] == '32bit':
            lib_name = "libencrypt-linux-arm-32.so"

        elif os.uname()[4].startswith("aarch64") and platform.architecture()[0] == '64bit':
            lib_name = "libencrypt-linux-arm-64.so"

        elif sys.platform.startswith('linux'):
            if "centos" in platform.platform():
                if platform.architecture()[0] == '64bit':
                    lib_name = "libencrypt-centos-x86-64.so"
                else:
                    lib_name = "libencrypt-linux-x86-32.so"
            else:
                if platform.architecture()[0] == '64bit':
                    lib_name = "libencrypt-linux-x86-64.so"
                else:
                    lib_name = "libencrypt-linux-x86-32.so"

        elif sys.platform.startswith('freebsd'):
            lib_name = "libencrypt-freebsd-64.so"

        else:
            err = "Unexpected/unsupported platform '{}'. If you have encrypt lib compiled for your platform, specify its location with '--encrypt-lib' parameter".format(sys.platform)
            log.error(err)
            raise Exception(err)

        lib_path = os.path.join(os.path.dirname(__file__), "libencrypt", lib_name)

        if not os.path.isfile(lib_path):
            err = "Could not find {} encryption library {}".format(sys.platform, lib_path)
            log.error(err)
            raise Exception(err)

    return lib_path


class Timer():

    def __init__(self, name):
        self.times = [(name, time.time(), 0)]

    def add(self, step):
        t = time.time()
        self.times.append((step, t, round((t - self.times[-1][1]) * 1000)))

    def checkpoint(self, step):
        t = time.time()
        self.times.append(('total @ ' + step, t, t - self.times[0][1]))

    def output(self):
        self.checkpoint('end')
        pprint.pprint(self.times)
