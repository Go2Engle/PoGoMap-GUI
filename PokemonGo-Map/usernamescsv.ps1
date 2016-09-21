$textPath = ".\usernames.txt"
$bannedpath = ".\banned.txt"
$csvpath = ".\usernames.csv"
$csvnames = get-content -path $csvpath -ErrorAction SilentlyContinue
$textnames = get-content -path $textPath -ErrorAction SilentlyContinue
$bannednames = get-content -path $bannedpath -ErrorAction SilentlyContinue
$usernames = $null
foreach($csvname in $csvnames)
    {
    $usernames += ($csvname.split(",") | Select -index 1) + ":" + ($csvname.split(",") | Select -index 2) + ","
    }
foreach($textname in $textnames)
    {
    $usernames += $textname + ","
    }
If ($usernames)
    {
    $usernames = $usernames.split(",")
    }
Else
    {
    "No valid accounts found! You will need to create new accounts in order to run your map."
    }
$usernames = $usernames | Select -Unique
If($bannednames)
    {
    foreach($bannedname in $bannednames)
        {
        $usernames = $usernames | where {$_ -notmatch $bannedname}
        }
    }
$usernames = $usernames | where {$_ -notlike ""}
remove-item -Path $bannedpath -Force -ErrorAction SilentlyContinue
If($usernames)
{
    [System.IO.File]::WriteAllLines($textPath, $usernames)
    foreach($username in $usernames)
        {
        $usernames = $usernames.replace($username,("ptc," + $username))
        }
    $usernames = $usernames.replace(":",",")
    [System.IO.File]::WriteAllLines($csvpath, $usernames)
}
Else
{
    Remove-Item -Path $textpath -Force -ErrorAction SilentlyContinue
    Remove-Item -Path $csvpath -Force -ErrorAction SilentlyContinue
}
