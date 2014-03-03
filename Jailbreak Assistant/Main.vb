Imports MobileDevice
Imports System.Xml

'Copyright (C) <2014>  <Out of Ink Software>

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

    Dim iphone As New MobileDevice.iPhone
    Dim cc As String
    Dim mode, iPhonev, extra, firmware, model As String
    Dim document As XmlReader
    Dim dicto As New Dictionary(Of String, List(Of String))
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Start checking for a device...
        Timer1.Start()
        Button2.Enabled = False
        RadioButton1.Checked = True
        Dim device, name, carrier As String
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
                    dicto.Add(device, New List(Of String))
                    dicto(device).Add(name)
                    dicto(device).Add(carrier)
                End If
            End While
        End Using

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Cool little thing for the waiting part, not important
        If cc = "..." Then
            cc = ""
        End If
        cc = cc + "."
        'Do this when iPhone is connected...
        If iphone.IsConnected = True Then
            Button2.Enabled = True
            Label1.Text = "Connected (Automatic Mode)"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Timer1.Stop()
            Timer2.Start()

           
            If dicto.ContainsKey(iphone.DeviceProductType) Then
                Dim listo As New List(Of String)
                Dim blob As String
                listo = dicto.Item(iphone.DeviceProductType)
                For Each blob In listo.GetRange(0, 1)
                    iPhonev = blob
                Next
                For Each blob In listo.GetRange(1, 1)
                    extra = blob
                Next
            End If

            'Display it
            firmware = iphone.DeviceVersion
            model = iphone.DeviceModelNumber

            Label3.Text = firmware + " (" + iphone.DeviceBuildVersion + ")"
            Label2.Text = iPhonev
            Label4.Text = model
            Label9.Text = extra
        Else
            'If no device is connected then keep waiting
            Button2.Enabled = False
            Label1.Text = "Waiting for iDevice" + cc
            Label3.Text = firmware
            Label2.Text = ""
            Label4.Text = ""
            Label9.Text = ""
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If iphone.IsConnected = False Then
            'The user unplugged their device, wait for them to plug it back in
            'Resetting values
            Button2.Enabled = False
            iPhonev = ""
            firmware = ""
            model = ""
            extra = ""
            Label2.Text = iPhonev
            Label3.Text = firmware
            Label4.Text = model
            Label9.Text = extra
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If cc = "..." Then
                cc = ""
            End If
            cc = cc + "."
            Label1.Text = "Waiting for iDevice" + cc
        ElseIf iphone.IsConnected = True Then
            'The user plugged their devcie back in!
            Button2.Enabled = True
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Label1.Text = "Connected (Automatic Mode)"
            'Once again determine which device they have...

            If dicto.ContainsKey(iphone.DeviceProductType) Then
                Dim listo As New List(Of String)
                Dim blob As String
                listo = dicto.Item(iphone.DeviceProductType)
                For Each blob In listo.GetRange(0, 1)
                    iPhonev = blob
                Next
                For Each blob In listo.GetRange(1, 1)
                    extra = blob
                Next
            End If
            'Display it
            firmware = iphone.DeviceVersion
            model = iphone.DeviceModelNumber
            Label3.Text = firmware + " (" + iphone.DeviceBuildVersion + ")"
            Label2.Text = iPhonev
            Label4.Text = model
            Label9.Text = extra
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Recovery mode stuff...
        'Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Credits!
        MessageBox.Show("Created by Out of Ink Software. If you find any bugs or if there's anything missing, report at https://github.com/outofink/jailbreak-assistant.", "Jailbreak Assistant")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'User wants to know how to jailbreak!

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Timer1.Stop()
            Timer2.Stop()
            Label1.Text = "Manual mode"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 0
            Button2.Enabled = True
            'Form6.Show()
            model = ""
            extra = ""
            Timer3.Start()
        Else
            Timer2.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Stop()
        Timer2.Stop()
        Label1.Text = "Manual mode"
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = 0
        Button2.Enabled = True
        'Form6.Show()
        model = ""
        extra = ""
        Timer3.Start()
        RadioButton2.Checked = True
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label3.Text = firmware
        Label2.Text = iPhonev
        Label4.Text = model
        Label9.Text = extra
    End Sub
End Class