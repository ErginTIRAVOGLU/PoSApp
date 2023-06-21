taskkill /f /im PoSApp.exe
:exit
msiexec.exe /i "PoSApp.Setup.msi" /passive /qn
del "PoSApp.Setup.msi";
start PoSApp.exe