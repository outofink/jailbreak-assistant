Public Class Form2

    Public Sub Delay(ByVal dblSecs As Double)
        'Code for pausing from stantheripper
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Enter recovery...
        If itunesexists = False Then
            MessageBox.Show("What are you doing? You don't have iTunes installed... Go install it!", "Jailbreak Assistant")
            Form1.Close()
            Me.Close()
        Else
            If bits = "x64" Then
                modex64()
            End If

            If bits = "x86" Then
                modex86()
            End If
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ""
        'determine what type of computer it is... from stantheripper...
        If System.Environment.Is64BitOperatingSystem.ToString = True Then
            bits = "x64"
            If System.IO.Directory.Exists("C:\Program Files (x86)\iTunes") Then
                itunesexists = True
            End If
        Else
            bits = "x86"
            If System.IO.Directory.Exists("C:\Program Files (x86)\iTunes") Then
                itunesexists = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'exit recovery
        If itunesexists = False Then
            MessageBox.Show("What are you doing? You don't have iTunes installed... Go install it!", "Jailbreak Assistant")
            Form1.Close()
            Me.Close()
        Else
            ExitRecoverymode()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Go back
        Me.Close()
    End Sub
End Class