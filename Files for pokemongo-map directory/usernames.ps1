$usernamesPath = ".\usernames.txt"
$bannedpath = ".\banned.txt"
$usernames = get-content -path $usernamesPath
$banned = get-content -path $bannedpath
foreach($username in $banned)
    {
    $usernames = $usernames | where {$_ -notmatch $username}
    }
[System.IO.File]::WriteAllLines($usernamesPath, $usernames)
remove-item -Path $bannedpath -Force
$configPath = '.\config\config.ini'
$config = get-content -path $MyPath
foreach($username in $usernames)
    {
    $username = $username.split(':')
    $username = $username | select -first 1
    $output += $username + ','
    }
$output = "username:[" + $output.trimend(',',1) + "]"
$line = $config | where {$_ -like "username:*"}
$config = $config.replace("$line","$output")
[System.IO.File]::WriteAllLines($configPath, $config)