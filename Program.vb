Imports System

Module Program
    Sub Main(args As String())
        PrintHeaderBlock()

        Dim alarmSystem as New AlarmSystem()

        Console.WriteLine("Type 'help' for a list of commands.")

        ' Main program loop
        While True
            ' Prompt for user input
            Console.write("> ")
            Dim command As String = Console.ReadLine().Trim().ToLowerInvariant()

            ' check for exit command
            If command Is Nothing OrElse command = "exit" Then
                ExitProgram()
                Exit While
            End If

            ' Process input command
            Select Case command
                Case "status"
                    PrintAlarmSystemStatus(alarmSystem)
                Case "help"
                    PrintAvailableCommands()
                Case Else
                    PrintHelp(command)
            End Select

        End While

    End Sub

    ' The Program Header Block printed at the start of the program
    Sub PrintHeaderBlock()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("---------------------------------")
        Console.WriteLine("Alarm Simulator Initiated")
        Console.WriteLine("---------------------------------")
        Console.WriteLine()
    End Sub

    ' Prints the current status of the AlarmSystem to the console
    Sub PrintAlarmSystemStatus(alarmSystem As AlarmSystem)
        Console.WriteLine(alarmSystem.GetStatus())
    End Sub

    ' Prints list of available commands to the console
    Sub PrintAvailableCommands()
        Console.WriteLine("Available commands:")
        Console.WriteLine("  status - Show the current status of the alarm system")
        Console.WriteLine("  help   - Show this help message")
        Console.WriteLine("  exit   - Exit the program")
    End Sub


    ' Print the help message to the console.
    Sub PrintHelp(command as String)
        Console.WriteLine($"Unknown command: '{command}'. Type 'help' for a list of commands.")
    End Sub

    ' Exit the program gracefully with console messaage.
    Sub ExitProgram()
        Console.WriteLine()
        Console.WriteLine("Exiting Alarm Simulator. Goodbye!")
        Console.WriteLine()
        Environment.Exit(0)
    End Sub
End Module
