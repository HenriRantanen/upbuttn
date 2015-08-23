﻿Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'Run initialization on startup
            For Each argument As String In My.Application.CommandLineArgs
                ' Add code here to use the argument. 
                If CommandLineArgs.First = "up" Then

                    Using com3 As IO.Ports.SerialPort =
                        My.Computer.Ports.OpenSerialPort("COM3")
                        com3.WriteLine("d115")
                    End Using

                    End

                End If
                If CommandLineArgs.First = "down" Then

                    Using com3 As IO.Ports.SerialPort =
                        My.Computer.Ports.OpenSerialPort("COM3")
                        com3.WriteLine("d72")
                    End Using

                    End
                End If

            Next
        End Sub
    End Class
End Namespace
