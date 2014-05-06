Option Explicit On
Public Class Toolbox


    Private Declare Function GetTickCount Lib "kernel32" () As Long
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        run(".\bin\CCleaner.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        run(".\bin\Revouninstaller.exe")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        run(".\bin\Combofix.exe")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        run(".\bin\BlueScreenView.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        run(".\bin\MyEventViewer.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        run("services.msc")

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        run("MSCONFIG")

    End Sub


    Function IsConnected() As Boolean
        Return My.Computer.Network.Ping("www.google.com")

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsConnected() = True Then
            run(".\bin\mbamnn.exe")
        End If
        If IsConnected() = False Then
            run(".\bin\mbam.exe")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsConnected() = False Then
            run(".\bin\SAS.exe")
        End If
        If IsConnected() = True Then
            run(".\bin\SASNN.exe")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        run(".\bin\tdsskiller.exe")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        run(".\bin\RKILL.exe")

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        run(".\bin\sfc.bat")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        run(".\bin\chkdsk.bat")
    End Sub




    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("Updating... Please reopen application when done...")
        run(".\bin\getnew.bat")
        End

    End Sub


    Private Sub VerLabel_Click(sender As Object, e As EventArgs) Handles VerLabel.Click
        MsgBox("Forcing update!")
        run(".\bin\update.bat")
        Wait(3)
        run(".\bin\getnew.bat")
        End
    End Sub


    Sub Wait(numSeconds As Long)
        Dim start As Long
        start = GetTickCount() + (numSeconds * 1000)

        Do While start > GetTickCount()

        Loop
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        run(".\bin\mbar.exe")
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        run(".\bin\adwcleaner.exe")
    End Sub


    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        run("appwiz.cpl")
    End Sub
    Private Sub run(A As String)
        Try
            System.Diagnostics.Process.Start(A)
        Catch ex As Exception

        End Try
    End Sub
End Class
