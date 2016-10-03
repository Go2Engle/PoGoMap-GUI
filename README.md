[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.me/PoGoMapGUI)
# PoGoMap-GUI

## NEWS
First just wanna let everyone know I just created a forum which can be access at http://www.go2engle.com. Hopfully we can get some people posting in there that way there can be more discussion on errors and what not. I will also be looking for Mods for the forums as right now its only me answering questions. Could use some help if anyone is interested!(If anyone registerd today 9/20/16 before 4:30pm est and didnt get your registration email please visit the site and click the resend button. 2nd if you have just updated to 3.1.7 please be aware that you will need to run check accounts before starting your map after updating. This will spit your current and future accounts into a CSV file which will then be used to log in. This upgrade also wiped out your google maps API key( Sorry :( ). So you will also need to re-enter that before starting your map as well.

## Description
This is a GUI tool created to ease the process of running your pokemongo-map and creating new accounts to scan with. This combines a few tools created by other fantastic users on github! Without there tools I would have no need to create this tool. This is a windows only tool. Sorry for my horrible coding but so far it seems to get the job done!

Tools being used by my GUI:
 - Pokemongo-Map (https://github.com/PokemonGoMap/PokemonGo-Map)
 - Pikaptcha (https://github.com/sriyegna/Pikaptcha)
 - PokeAlarm (https://github.com/kvangent/PokeAlarm)
 - PoGoAccountCheck (https://github.com/a-moss/PoGoAccountCheck)
 - Pokemongo-Map IVs and movesets (https://github.com/MangoScango/PokemonGo-Map/tree/IVs-and-Moves)
 - PokemonGo-Map_Launcher.exe source(https://github.com/engle2192/PoGoMap-GUI_EXE_SourceFiles)

## Features
![Alt text](https://github.com/engle2192/PoGoMap-GUI/blob/master/Screenshots/MainMenu1.PNG)
![Alt text](https://github.com/engle2192/PoGoMap-GUI/blob/master/Screenshots/notifications.PNG)
 - Built in updater!
 - Run your map in spiral scan or spawn point scanning
 - Enable/Disable scan for poke stops, gyms, fixed locations, no search control
 - Choose step limit (step limit must be commented out in your PokemonGo-Map config.ini for this to work)
 - Set starting location (location must be commented out in your PokemonGo-Map config.ini for this to work)
 - Quickly create accounts and automatically add them to your PokemonGo-Map config.ini (Please check the wiki for instructions https://github.com/engle2192/PoGoMap-GUI/wiki)
 - Quickly check the accounts you are currently using and automatically delete banned or deleted accounts from your config.ini
 - Command windows now dock in the GUI
 - 2Captcha Key, Password, and Location field will save through application restarts
 - Notifications now has its own GUI! No more need to edit config files!

## Pre-Installation
1. You will need your google maps API key, and any API key you wish you use for notifications if you plan to use them. The Google maps API is a must no matter what below is a link on how to get your Maps API key. After clicking the link click get a key and follow the instructions. You will Also need google chrome installed on your computer.
 - Google Maps API instructions (https://developers.google.com/maps/documentation/javascript/get-api-key)
 - Google Chrome (https://www.google.com/chrome/browser/desktop/)

## Installation

1. Download the Installer and Run as an administrator (https://github.com/engle2192/PoGoMap-GUI/releases/tag/AIO)
2. Browse to the PoGoMap-GUI folder located on your desktop.
3. Run PokemonGo-Map_Launcher.exe.
5. Enter your Google Maps API Key, Create some accounts using account creator, enter your zip code or address in quotes.
6. Run your Map!

## Powershell instructions
1. Run below in powershell launched as administrator:

    Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\PowerShell -Name ExecutionPolicy -Value ByPass

2. If you get this error continue to step 3 other wise you are finished.
![Alt text](https://i0.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo5.png?w=940)
3. This is because your local group policy to allow scripts to run on the system is probably “not configured” . To configure it, run “gpedit.msc”
4. Then Navigate to: Computer Configuration > Administrative Templates > Windows Components > Windows PowerShell. Change the “Turn on Script Execution” to look something like this:![Alt text](https://i2.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo7.png?w=940)
5. Afterwards, the PowerShell command should work and you should be able to change your Execution Policy without any problems!
![Alt text](https://i2.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo8.png?w=940)
