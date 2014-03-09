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
        'Start checking for a device...
        AutoTimer.Start()
        jailbreakButton.Enabled = False
        AutoRadio.Checked = True
        Dim device, name, carrier, version As String
        Using document As XmlReader = New XmlTextReader("devices.xml")
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
        Using document As XmlReader = New XmlTextReader("ios.xml")
            While (document.Read())
                document.ReadToFollowing("device")

                document.MoveToAttribute("name")
                name = document.Value.ToString

                document.MoveToAttribute("version")
                version = document.Value.ToString
                'MsgBox(version)
                If name <> "" Then
                    manual.Add(name, New List(Of String))
                    manual(name) = version.Split(",").ToList()
                    devices.Add(name)
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
            'The user plugged their devcie back in!
            'jailbreakButton.Enabled = True
            ProgressBar.Style = ProgressBarStyle.Blocks
            ProgressBar.Value = 100
            statusText.Text = "Connected (Automatic Mode)"
            'Once again determine which device they have...

            If details.ContainsKey(iphone.DeviceProductType) Then
                Dim listo As New List(Of String)
                Dim blob As String
                Try
                    listo = details.Item(iphone.DeviceProductType)
                    For Each blob In listo.GetRange(0, 1)
                        device = blob
                    Next
                    For Each blob In listo.GetRange(1, 1)
                        carrier = blob
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

    Private Sub recoveryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recoveryButton.Click
        'Recovery mode stuff...
        'Form2.Show()
    End Sub

    Private Sub aboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutButton.Click
        'Credits!
        Dim f As New About
        f.ShowDialog()
        'About.Show()
        'MessageBox.Show("Created by Out of Ink Software. If you find any bugs or if there's anything missing, report at https://github.com/outofink/jailbreak-assistant." & vbCrLf & vbCrLf & "MobileDevice.dll for VB by Fallensn0w.", "Jailbreak Assistant")
    End Sub

    Private Sub jailbreakButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jailbreakButton.Click
        'User wants to know how to jailbreak!

    End Sub

    Private Sub ManualRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualRadio.Click
        If AutoTimer.Enabled = True Then
            manualButton.PerformClick()
        End If
    End Sub
    Private Sub AutoRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoRadio.Click
        AutoTimer.Start()
        manualTimer.Stop()
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
            'ManualRadio.Checked = False
            AutoRadio.PerformClick()
        End If
        model = ""
        carrier = ""
        manualTimer.Start()
    End Sub
    Private Sub manualTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualTimer.Tick
        iosText.Text = ios
        deviceText.Text = device
        modelText.Text = model
        CarrierText.Text = carrier
    End Sub
End Class
