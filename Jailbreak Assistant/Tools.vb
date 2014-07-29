Public Class Tools

    Private Sub Jailbreak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub siteButton_Click(sender As Object, e As EventArgs) Handles siteButton.Click
        Process.Start("http://en.pangu.io/")
    End Sub
End Class