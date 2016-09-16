$usernamesPath = ".\usernames.txt"
$bannedpath = ".\banned.txt"
$csvpath = ".\usernames.csv"
$usernames = get-content -path $usernamesPath -ErrorAction Stop
$banned = get-content -path $bannedpath -ErrorAction SilentlyContinue
foreach($username in $banned)
    {
    $usernames = $usernames | where {$_ -notmatch $username}
    }
$usernames = $usernames | where {$_ -notlike ""}
[System.IO.File]::WriteAllLines($usernamesPath, $usernames)
remove-item -Path $bannedpath -Force -ErrorAction SilentlyContinue
foreach($username in $usernames)
    {
    $usernames = $usernames.replace($username,("ptc," + $username))
    }
$usernames = $usernames.replace(":",",")
[System.IO.File]::WriteAllLines($csvpath, $usernames)
