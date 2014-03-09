Public Class ManualForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelManual.Click
        Me.Close()
    End Sub


    Private Sub ManualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numb As Integer
        numb = 0
        For Each blob In devices
            deviceCombo.Items.Insert(numb, blob)
            numb += 1
        Next
        iosCombo.Enabled = False
        useManual.Enabled = False
        ok = False

    End Sub
    Private Sub ManualForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        cancelled = True
    End Sub
    Private Sub deviceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deviceCombo.SelectedIndexChanged
        Dim numb As Integer
        numb = 0
        iosCombo.Items.Clear()
        listo = manual.Item(deviceCombo.Text)
        For Each blob In listo
            iosCombo.Items.Insert(numb, blob)
            numb += 1
        Next
        iosCombo.Text = ""
        iosCombo.Enabled = True
        useManual.Enabled = False
    End Sub

    Private Sub useManual_Click(sender As Object, e As EventArgs) Handles useManual.Click
        device = deviceCombo.Text
        ios = iosCombo.Text
        model = ""
        carrier = ""
        ok = True
        Me.Close()
    End Sub

    Private Sub iosCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iosCombo.SelectedIndexChanged
        useManual.Enabled = True
    End Sub
End Class