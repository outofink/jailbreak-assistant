Public Class greenpois0n61

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        LinkLabel3.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:ptecproductions@gmail.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub greenpois0n61_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dir As String
        dir = CurDir()
        ChDir(mode)
        Dim Processred As New ProcessStartInfo
        Processred.FileName = "greenpois0n61.exe"
        Processred.Arguments = ""
        Processred.WindowStyle = ProcessWindowStyle.Normal
        Dim yourProcess As Process = Process.Start(Processred)
        ChDir(dir)
    End Sub

    Private Sub AxShockwaveFlash1_Enter(sender As Object, e As EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
End Class