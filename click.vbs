Set oShell = CreateObject("WScript.Shell")
oShell.exec("D:\Ranorex solutions\qfcTest\qfcTest\bin\Debug\qfcTest.exe")
WScript.Sleep 1000
oShell.AppActivate "Welcome to Ranorex Evaluation"
WScript.Sleep 500
oShell.SendKeys "{Enter}"