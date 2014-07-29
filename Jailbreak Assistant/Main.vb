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


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Move files into temp folder
        Dim windows_temp, temp As String
        windows_temp = My.Computer.FileSystem.SpecialDirectories.Temp
        temp = windows_temp & "\outofink\jailbreak-assistant"
        System.IO.Directory.CreateDirectory(temp)
        System.IO.File.WriteAllText(temp & "\devices.xml", My.Resources.devices)
        System.IO.File.WriteAllText(temp & "\ios.xml", My.Resources.ios)
        System.IO.File.WriteAllText(temp & "\jailbreak.xml", My.Resources.jailbreak)
        System.IO.File.WriteAllText(temp & "\tools.xml", My.Resources.tools)
        'Start checking for a device...
        AutoTimer.Start()
        jailbreakButton.Enabled = False
        AutoRadio.Checked = True
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
                'MsgBox(version)
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
            While (document.Read())
                document.ReadToFollowing("jailbreak")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("version")
                version = document.Value.ToString

                document.MoveToAttribute("tool")
                tool = document.Value.ToString

                If name <> "" Then
                    jailbreak.Add(name + version, New List(Of String))
                    jailbreak(name) = tool.Split(","c).ToList()
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
                Dim item As String
                Try
                    listo = details.Item(iphone.DeviceProductType)
                    For Each item In listo.GetRange(0, 1)
                        device = item
                    Next
                    For Each item In listo.GetRange(1, 1)
                        carrier = item
                    Next
                Catch ex As Exception
                End Try
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
        'User wants to know how to jailbreak!
        'Dim frm As New Form
        'frm.Size = New Size(300, 200)
        'frm.Text = "New Form"

        'Dim btn As New Button
        'btn.Text = "Click Me"
        'btn.Size = New Size(100, 30)
        'btn.Location = New Point( _
        '    (frm.ClientSize.Width - btn.Width) / 2, _
        '    (frm.ClientSize.Height - btn.Height) / 2)
        ''AddHandler btn.Click, AddressOf btn_Click
        'frm.Controls.Add(btn)

        'frm.Show()
        Dim f As New Tools
        f.ShowDialog()

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
