Public Class Form6
    'For manual operation
    'Get all of the needed device info


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.Visible = True
        ComboBox3.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "iPhone 4S" Then
            iPhonev = "iPhone 4S"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "5.0")
            ComboBox3.Items.Insert(1, "5.0.1")
            ComboBox3.Items.Insert(2, "5.1")
            ComboBox3.Items.Insert(3, "5.1.1")
            ComboBox3.Items.Insert(4, "6.0")
            ComboBox3.Items.Insert(5, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPhone 4" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "4.1")
            ComboBox3.Items.Insert(1, "4.2.1")
            ComboBox3.Items.Insert(2, "4.3")
            ComboBox3.Items.Insert(3, "4.3.1")
            ComboBox3.Items.Insert(4, "4.3.2")
            ComboBox3.Items.Insert(5, "4.3.3")
            ComboBox3.Items.Insert(6, "4.3.4")
            ComboBox3.Items.Insert(7, "4.3.5")
            ComboBox3.Items.Insert(8, "5.0")
            ComboBox3.Items.Insert(9, "5.0.1")
            ComboBox3.Items.Insert(10, "5.1")
            ComboBox3.Items.Insert(11, "5.1.1")
            ComboBox3.Items.Insert(12, "6.0")
            ComboBox3.Items.Insert(13, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPhone 5" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "6.0")
            ComboBox3.Items.Insert(1, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPhone 3GS" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Items.Insert(2, "4.1")
            ComboBox3.Items.Insert(3, "4.3")
            ComboBox3.Items.Insert(4, "4.3.1")
            ComboBox3.Items.Insert(5, "4.3.2")
            ComboBox3.Items.Insert(6, "4.3.3")
            ComboBox3.Items.Insert(7, "4.3.4")
            ComboBox3.Items.Insert(8, "4.3.5")
            ComboBox3.Items.Insert(9, "5.0")
            ComboBox3.Items.Insert(10, "5.0.1")
            ComboBox3.Items.Insert(11, "5.1")
            ComboBox3.Items.Insert(12, "5.1.1")
            ComboBox3.Items.Insert(13, "6.0")
            ComboBox3.Items.Insert(14, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPod Touch 3G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Items.Insert(2, "4.1")
            ComboBox3.Items.Insert(3, "4.2.1")
            ComboBox3.Items.Insert(4, "4.3")
            ComboBox3.Items.Insert(5, "4.3.1")
            ComboBox3.Items.Insert(6, "4.3.2")
            ComboBox3.Items.Insert(7, "4.3.3")
            ComboBox3.Items.Insert(8, "4.3.4")
            ComboBox3.Items.Insert(9, "4.3.5")
            ComboBox3.Items.Insert(10, "5.0")
            ComboBox3.Items.Insert(11, "5.0.1")
            ComboBox3.Items.Insert(12, "5.1")
            ComboBox3.Items.Insert(13, "5.1.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPod Touch 4G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "4.1")
            ComboBox3.Items.Insert(1, "4.2.1")
            ComboBox3.Items.Insert(2, "4.3")
            ComboBox3.Items.Insert(3, "4.3.1")
            ComboBox3.Items.Insert(4, "4.3.2")
            ComboBox3.Items.Insert(5, "4.3.3")
            ComboBox3.Items.Insert(6, "4.3.4")
            ComboBox3.Items.Insert(7, "4.3.5")
            ComboBox3.Items.Insert(8, "5.0")
            ComboBox3.Items.Insert(9, "5.0.1")
            ComboBox3.Items.Insert(10, "5.1")
            ComboBox3.Items.Insert(11, "5.1.1")
            ComboBox3.Items.Insert(12, "6.0")
            ComboBox3.Items.Insert(13, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPod Touch 5G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "6.0")
            ComboBox3.Items.Insert(1, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPad 2G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Items.Insert(9, "5.1.1")
            ComboBox3.Items.Insert(10, "6.0")
            ComboBox3.Items.Insert(11, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPad 3G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "5.1")
            ComboBox3.Items.Insert(1, "5.1.1")
            ComboBox3.Items.Insert(2, "6.0")
            ComboBox3.Items.Insert(3, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPad 4G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "6.0")
            ComboBox3.Items.Insert(1, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPad Mini" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "6.0")
            ComboBox3.Items.Insert(1, "6.0.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPad 1G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Items.Insert(9, "5.1.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPhone 3G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Items.Insert(2, "4.1")
            ComboBox3.Items.Insert(3, "4.2.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPod Touch 2G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Items.Insert(2, "4.1")
            ComboBox3.Items.Insert(3, "4.2.1")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPhone 2G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Visible = True
        ElseIf ComboBox2.Text = "iPod Touch 1G" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Clear()
            ComboBox3.Items.Insert(0, "3.1.2")
            ComboBox3.Items.Insert(1, "3.1.3")
            ComboBox3.Visible = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        firmware = ComboBox3.Text
        Button1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class