taskkill /f /im PoSApp.exe
:exit
msiexec.exe /i "PoSApp.Setup.msi" 
del "PoSApp.Setup.msi";
start PoSApp.exe