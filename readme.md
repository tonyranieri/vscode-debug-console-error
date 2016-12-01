# Project to demonstrate bug with VS Code Debug Console

This will work on command line and VS Code Terminal, but will fail in VS Code Debug Console with the error:  

```
Unhandled Exception: System.IO.IOException: The handle is invalid
   at System.ConsolePal.GetBufferInfo(Boolean throwOnNoConsole, Boolean& succeeded)
   at System.Console.get_CursorLeft()
   at VSCodeIssue.ConsoleSpinner.Turn()
   at VSCodeIssue.Program.Main(String[] args)

```