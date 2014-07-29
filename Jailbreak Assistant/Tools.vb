Public Class Tools
    Dim website As String
    Private Sub Jailbreak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tool_details As List(Of String)

        tool_details = utility.Item(chosentool)
        Me.Text = tool_details.Item(0)
        nameText.Text = tool_details.Item(0)
        toolIcon.Image = CType(My.Resources.ResourceManager.GetObject(tool_details.Item(3)), Image)
        descriptionText.Text = tool_details.Item(1)
        website = tool_details.Item(2)
        siteButton.Text = "Go to " + tool_details.Item(0) + "'s website"

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub siteButton_Click(sender As Object, e As EventArgs) Handles siteButton.Click
        Process.Start(website)
    End Sub
End Class