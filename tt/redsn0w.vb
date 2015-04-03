Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Public Class redsn0w

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        LinkLabel3.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:ptecproductions@gmail.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub redsn0w_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Processred As New ProcessStartInfo
        If My.Computer.FileSystem.FileExists(mode & "\redsn0w.exe") = False Then
            Dim tDirectory As String
            Dim pFilePath
            tDirectory = mode
            pFilePath = mode & "\redsn0w.zip"
            MessageBox.Show("Please wait as redsn0w loads.")
            ZipExtract.Extract(pFilePath, tDirectory)
        End If
        Processred.FileName = mode & "\redsn0w.exe"
        Processred.Arguments = ""
        Processred.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(Processred)
    End Sub

    Private Sub AxShockwaveFlash1_Enter(sender As Object, e As EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
End Class



Public Class ZipExtract

    ''' <summary>Extracts the specified zip file with its directory hierarchy</summary>
    ''' <param name="SourceFileName">Zip file to be extracted</param>
    ''' <param name="DestinationFolderName">New folder that the zip will be extracted into</param>
    ''' <param name="DeleteZip">Delete or keep the original zip after extracting</param>
    Public Shared Sub Extract(ByVal SourceFileName As String, _
                              ByVal DestinationFolderName As String, _
                              Optional ByVal DeleteZip As Boolean = False)


    End Sub


End Class
