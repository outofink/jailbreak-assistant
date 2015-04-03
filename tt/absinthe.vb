Public Class absinthe

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub absinthe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dir As String
        dir = CurDir()
        ChDir(mode)
        If My.Computer.FileSystem.FileExists("absinthe-win-2.0.4\absinthe.exe") = False Then
            Dim Processabs As New ProcessStartInfo
            Processabs.FileName = mode & "\absinthe.exe"
            Processabs.Arguments = ""
            Processabs.WindowStyle = ProcessWindowStyle.Hidden
            Dim myProcess As Process = Process.Start(Processabs)
            MessageBox.Show("Please wait a moment while Absinthe loads.", "Jailbreak Assistant")
            myProcess.WaitForExit()
        End If
        Dim Processred As New ProcessStartInfo
        Processred.FileName = "absinthe-win-2.0.4\absinthe.exe"
        Processred.Arguments = ""
        Processred.WindowStyle = ProcessWindowStyle.Normal
        Dim yourProcess As Process = Process.Start(Processred)
        ChDir(dir)
    End Sub
End Class