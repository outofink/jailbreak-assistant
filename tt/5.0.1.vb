Public Class jail501

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("An untethered jailbreak is a jailbreak that does not require you to plug in your device each time you boot.", "Jailbreak Assistant")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.youtube.com/watch?v=qyyf6Kl8PSM")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton2.Checked = True Then
            redsn0w.Show()
        End If
    End Sub


    Private Sub jail501_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class