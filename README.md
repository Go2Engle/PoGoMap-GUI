# PoGoMap-GUI

## Description
This is a GUI tool created to ease the proccess of running your pokemongo-map and creating new accounts to scan with. This combines a few tools created by other users on github. This is a windows only tool. Sorry for my horrible coding but so far it seems to get the job done!

Tools being used by my GUI:
 - Pokemongo-Map (https://github.com/PokemonGoMap/PokemonGo-Map)
 - Pikaptcha (https://github.com/sriyegna/Pikaptcha)
 - PokeAlarm (https://github.com/kvangent/PokeAlarm)
 - PoGoAccountCheck (https://github.com/a-moss/PoGoAccountCheck)

## Installation
1. Have a fully running and working Pokemongo-Map (https://github.com/PokemonGoMap/PokemonGo-Map).
2. Follow instructions from (https://github.com/sriyegna/Pikaptcha) to install Pikaptcha.
3. Follow instructions from (https://github.com/kvangent/PokeAlarm) to install PokeAlarm.
3. Download latest PoGoMap-GUI zip from releases section. (https://github.com/engle2192/PoGoMap-GUI/releases)
4. Extract files from zip to the root of your PokemonGo-Map Directory.
5. Copy RunNotifications.bat from "Files for pokemongo-map directory" to your PokeAlarm folder and edit it to your setup.
6. Create a shortcut of RunNotifications.bat that is located in your PokeAlarm directory and place it in the root of your PokemonGo-Map Directory (Make sure the shortcut is called RunNotifications).
7. Follow the bellow instructions to configure your computer to bypass execution policy for powershell scripts
8. Run PokemonGo-Map_Launcher.exe

## Powershell instructions
1. Run "Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\PowerShell -Name ExecutionPolicy -Value ByPass" in powershell launched as administrator
2. If you get this error continue to step 3 other wise you are finished.
![Alt text](https://i0.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo5.png?w=940)
3. This is because your local group policy to allow scripts to run on the system is probably “not configured” . To configure it, run “gpedit.msc”
4. Then Navigate to: Computer Configuration > Administrative Templates > Windows Components > Windows PowerShell. Change the “Turn on Script Execution” to look something like this:![Alt text](https://i2.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo7.png?w=940)
5. Afterwards, the PowerShell command should work and you should be able to change your Execution Policy without any problems!
![Alt text](https://i2.wp.com/absolute-sharepoint.com/wp-content/uploads/2014/03/031714_2013_ChangethePo8.png?w=940)
