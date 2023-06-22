taskkill /f /im PoSApp.exe
:exit
msiexec.exe /x "PoSApp.Setup.msi"
if "%errorlevel%" == "1605" goto err
del "PoSApp.Setup.msi";
start PoSApp.exe
exit

:err
msiexec.exe /i "PoSApp.Setup.msi"
del "PoSApp.Setup.msi";
start PoSApp.exe
echo "Error: Msiexec failed with errorlevel = %errorlevel%"
exit /b %errorlevel%