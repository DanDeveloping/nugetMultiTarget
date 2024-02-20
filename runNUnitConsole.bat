@echo off
rem Run NUnit via console command line. 
rem Target test projects that use .NET Frameworks (net47, net48)

set config=Debug
rem set config=Release

set nunitConsole="C:\Program Files (x86)\NUnit.org\nunit-console\nunit3-console.exe"

set targetProject=DanDeveloping.Echo.Tests\bin\%config%\netstandar2.0\DanDeveloping.Echo.dll

set testProject47="DanDeveloping.Echo.Tests\bin\%config%\net47\DanDeveloping.Echo.Tests.dll"

set testProject48="DanDeveloping.Echo.Tests\bin\%config%\net48\DanDeveloping.Echo.Tests.dll"

rem %nunitConsole% %testProject% --framework="net-4.0"
%nunitConsole% %testProject47% 

%nunitConsole% %testProject48% 