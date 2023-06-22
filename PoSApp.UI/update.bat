taskkill /f /im PoSApp.exe
:exit
msiexec.exe /i "PoSApp.Setup.msi" REINSTALL=ALL REINSTALLMODE=A
del "PoSApp.Setup.msi";
start PoSApp.exe