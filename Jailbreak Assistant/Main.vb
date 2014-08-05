Imports System.Xml

'    Jailbreak Assistant: A Windows jailbreak assistant which tells you what jailbreak software to use just by plugging your iDevice in!
'    Copyright (C) 2014 Out of Ink Software

'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>

Public Class Main
    Private Sub cfu_Background_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfu_Background.RunWorkerCompleted
        Dim windows_temp, temp As String
        windows_temp = My.Computer.FileSystem.SpecialDirectories.Temp
        temp = windows_temp & "\outofink\jailbreak-assistant"

        manualButton.Enabled = True
        ManualRadio.Enabled = True
        AutoRadio.Enabled = True
        optionsBox.Enabled = True
        AutoTimer.Start()

        loadXMLs(temp)
        statusText.Text = "Updated."
    End Sub
    Private Sub cfu_Background_DoWork(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfu_Background.DoWork
        Dim windows_temp, temp As String
        Dim name, time As String
        windows_temp = My.Computer.FileSystem.SpecialDirectories.Temp
        temp = windows_temp & "\outofink\jailbreak-assistant"

        Using document As XmlReader = New XmlTextReader(temp & "\update.xml")
            While (document.Read())
                document.ReadToFollowing("file")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("time")
                time = document.Value.ToString

                If name <> "" Then
                    updateA.Add(name, time)
                End If
            End While
        End Using
        Dim fail, reload As Boolean
        fail = False
        reload = False
        Dim wc As New System.Net.WebClient()
        Dim update_text As String
        Try
            update_text = wc.DownloadString("http://ja.outofinksoftware.com/update.xml")
            System.IO.File.WriteAllText(temp & "\update.xml", update_text)
            'MsgBox(update_text)
        Catch
            fail = True
        End Try
        If Not fail Then
            Using document As XmlReader = New XmlTextReader(temp & "\update.xml")
                While (document.Read())
                    document.ReadToFollowing("file")

                    document.MoveToAttribute("name")
                    name = document.Value.ToString

                    document.MoveToAttribute("time")
                    time = document.Value.ToString

                    If name <> "" Then
                        updateB.Add(name, time)
                    End If
                End While
            End Using
            For Each xml_file In updateB
                If xml_file.Value - updateA.Item(xml_file.Key) > 0 Then
                    ' MsgBox("need to update a file!")
                    update_text = wc.DownloadString("http://ja.outofinksoftware.com/" & xml_file.Key)
                    System.IO.File.WriteAllText(temp & "/" & xml_file.Key, update_text)
                    'MsgBox(update_text)
                End If
            Next
        End If
    End Sub
    Public iphone
    Public Sub init()
        Try
            iphone = New MobileDevice.iPhone
        Catch ex As Exception
            MsgBox("This program requires iTunes to be installed in order to run.")
            Me.Close()
        End Try
    End Sub
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Jailbreak Assistant " + program_version
        init()
        Dim windows_temp, temp As String
        'Move files into temp folder
        windows_temp = My.Computer.FileSystem.SpecialDirectories.Temp
        temp = windows_temp & "\outofink\jailbreak-assistant"
        'Dim now As Double
        'now = Format(Date.Now(), "yyMMddHHmmss")
        System.IO.Directory.CreateDirectory(temp)
        'If Not System.IO.File.Exists(temp & "\devices.xml") Then
        System.IO.File.WriteAllText(temp & "\devices.xml", My.Resources.devices)
        System.IO.File.WriteAllText(temp & "\ios.xml", My.Resources.ios)
        System.IO.File.WriteAllText(temp & "\jailbreak.xml", My.Resources.jailbreak)
        System.IO.File.WriteAllText(temp & "\tools.xml", My.Resources.tools)
        System.IO.File.WriteAllText(temp & "\update.xml", My.Resources.update)
        'End If
        manualButton.Enabled = False
        ManualRadio.Enabled = False
        AutoRadio.Enabled = False
        optionsBox.Enabled = False
        jailbreakButton.Enabled = False
        AutoRadio.Checked = True
        statusText.Text = "Checking for Updates..."

        Me.cfu_Background.RunWorkerAsync()
        'Start checking for a device...
    End Sub
    Private Sub loadXMLs(temp As String)
        Dim device, name, carrier, version As String

        Using document As XmlReader = New XmlTextReader(temp & "\devices.xml")
            While (document.Read())
                document.ReadToFollowing("Type")

                document.MoveToAttribute("device")
                device = document.Value.ToString

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("carrier")
                carrier = document.Value.ToString

                If device <> "" Then
                    details.Add(device, New List(Of String))
                    details(device).Add(name)
                    details(device).Add(carrier)
                End If
            End While
        End Using
        Using document As XmlReader = New XmlTextReader(temp & "\ios.xml")
            While (document.Read())
                document.ReadToFollowing("device")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("version")
                version = document.Value.ToString
                If name <> "" Then
                    manual.Add(name, New List(Of String))
                    manual(name) = version.Split(","c).ToList()
                    devices.Add(name)
                End If
            End While
        End Using
        Using document As XmlReader = New XmlTextReader(temp & "\tools.xml")
            Dim d_name, description, website, tool_icon As String
            While (document.Read())
                document.ReadToFollowing("tool")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("d_name")
                d_name = document.Value.ToString

                document.MoveToAttribute("description")
                description = document.Value.ToString

                document.MoveToAttribute("website")
                website = document.Value.ToString

                document.MoveToAttribute("icon")
                tool_icon = document.Value.ToString

                If name <> "" Then
                    utility.Add(name, New List(Of String))
                    utility(name).Add(d_name)
                    utility(name).Add(description)
                    utility(name).Add(website)
                    utility(name).Add(tool_icon)
                End If
            End While
        End Using
        Using document As XmlReader = New XmlTextReader(temp & "\jailbreak.xml")
            Dim version_list As List(Of String)
            While (document.Read())
                document.ReadToFollowing("jailbreak")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("version")
                version = document.Value.ToString

                document.MoveToAttribute("tool")
                tool = document.Value.ToString

                If name <> "" Then
                    version_list = version.Split(","c).ToList()
                    For Each versionNo As String In version_list
                        jailbreak.Add(name + versionNo, tool)
                    Next
                End If
            End While
        End Using
    End Sub
    Private Sub AutoTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoTimer.Tick
        If iphone.IsConnected = False Then
            'The user unplugged their device, wait for them to plug it back in
            'Resetting values
            jailbreakButton.Enabled = False
            device = ""
            ios = ""
            model = ""
            carrier = ""
            deviceText.Text = device
            iosText.Text = ios
            modelText.Text = model
            CarrierText.Text = carrier
            ProgressBar.Style = ProgressBarStyle.Marquee
            If dots = "..." Then
                dots = ""
            End If
            dots = dots + "."
            statusText.Text = "Waiting for iDevice" + dots
        ElseIf iphone.IsConnected = True Then
            'The user plugged their device back in!
            jailbreakButton.Enabled = True
            ProgressBar.Style = ProgressBarStyle.Blocks
            ProgressBar.Value = 100
            statusText.Text = "Connected (Automatic Mode)"
            'Once again determine which device they have...

            If details.ContainsKey(iphone.DeviceProductType) Then
                Dim listo As New List(Of String)
                Try
                    listo = details.Item(iphone.DeviceProductType)
                    device = listo.Item(0)
                    carrier = listo.Item(1)
                Catch ex As Exception
                End Try
            Else
                device = iphone.DeviceProductType
                carrier = "Unknown"
            End If
            'Display it
            ios = iphone.DeviceVersion
            model = iphone.DeviceModelNumber
            iosText.Text = ios + " (" + iphone.DeviceBuildVersion + ")"
            deviceText.Text = device
            modelText.Text = model
            CarrierText.Text = carrier
        End If
    End Sub

    'Private Sub recoveryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Recovery mode stuff...
    'Form2.Show()
    'End Sub

    Private Sub aboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutButton.Click
        'Credits!
        Dim f As New About
        f.ShowDialog()
        'About.Show()
        'MessageBox.Show("Created by Out of Ink Software. If you find any bugs or if there's anything missing, report at https://github.com/outofink/jailbreak-assistant." & vbCrLf & vbCrLf & "MobileDevice.dll for VB by Fallensn0w.", "Jailbreak Assistant")
    End Sub

    Private Sub jailbreakButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jailbreakButton.Click
        Dim deviceplusversion As String
        deviceplusversion = device + ios
        If jailbreak.ContainsKey(deviceplusversion) Then
            chosentool = jailbreak.Item(deviceplusversion)
            Dim f As New Tools
            f.ShowDialog()
        Else
            MsgBox("Either there is no jailbreak tool available for your iDevice yet, or Jailbreak Assistant doesn't support it yet.")
        End If


    End Sub

    Private Sub ManualRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualRadio.Click
        If AutoTimer.Enabled = True Then
            manualButton.PerformClick()
        End If
    End Sub
    Private Sub AutoRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoRadio.Click
        If AutoTimer.Enabled = False Then
            statusText.Text = "Waiting for iDevice."
            dots = "."
            iosText.Text = ""
            deviceText.Text = ""
            jailbreakButton.Enabled = False
        End If
        AutoTimer.Start()
    End Sub
    Private Sub manualButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualButton.Click
        ManualRadio.Checked = True
        AutoTimer.Stop()
        statusText.Text = "Manual mode"
        ProgressBar.Style = ProgressBarStyle.Blocks
        ProgressBar.Value = 0
        cancelled = False
        Dim f As New ManualForm
        f.ShowDialog()
        If cancelled = True And ok = False Then
            AutoRadio.PerformClick()
            jailbreakButton.Enabled = False
        Else
            jailbreakButton.Enabled = True
            iosText.Text = ios
            deviceText.Text = device
        End If
        modelText.Text = ""
        CarrierText.Text = ""
    End Sub


End Class
