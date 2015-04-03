Public Class jailbreakme

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        LinkLabel3.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:ptecproductions@gmail.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub jailbreakme_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter


        MessageBox.Show("Go to jailbreakme.om using Safari on your device to jailbreak using JailbreakMe.")
    End Sub

End Class