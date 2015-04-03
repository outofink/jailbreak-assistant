'Copyright (C) <2011>  <PTEC Productions>

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
Imports MobileDevice
Public Class Form1
    Dim iphone As New MobileDevice.iPhone
    Dim cc As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Start checking for a device...
        Timer1.Start()
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label9.Text = ""
        Dim test As String
        test = "zlib.dll"
        Button2.Enabled = False
        RadioButton1.Checked = True
        'Temporary path
        Dim temp As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        'Place where I'm going to store all of the necessary files
        mode = temp & "\PTEC Productions\mode"
        'make sure directory doesn't already exist
        System.IO.Directory.CreateDirectory(temp & "\PTEC Productions")
        System.IO.Directory.CreateDirectory(temp & "\PTEC Productions\mode")
        System.IO.File.WriteAllBytes(mode & "\itunnel.exe", My.Resources.itunnel_mux_r61)
        System.IO.File.WriteAllBytes(mode & "\redsn0w.zip", My.Resources.redsn0w1)
        System.IO.File.WriteAllBytes(mode & "\absinthe.exe", My.Resources.absinthe1)
        System.IO.File.WriteAllBytes(mode & "\greenpois0n61.exe", My.Resources.greenpois0n61)
        System.IO.File.WriteAllBytes(mode & "\greenpois0n4.exe", My.Resources.greenpois0n4)
        System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", My.Resources.IPHUCWIN32)
        System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\readline5.dll", My.Resources.readline5)
        If System.IO.File.Exists("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll") Then
            System.IO.File.Delete("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
        Else
            System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
        End If
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
            'Determine what type of device it is...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod Touch 3G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod5,1" Then
                iPhonev = "iPod Touch 5G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod Touch 4G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod Touch 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod Touch 1G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad3,1" Then
                iPhonev = "iPad 3G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad3,2" Then
                iPhonev = "iPad 3G"
                extra = "CDMA"
            ElseIf iphone.DeviceProductType = "iPad3,3" Then
                iPhonev = "iPad 3G"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPad3,4" Then
                iPhonev = "iPad 4G"
                extra = "Wifi"
            ElseIf iphone.DeviceProductType = "iPad3,5" Then
                iPhonev = "iPad 4G"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPad3,6" Then
                iPhonev = "iPad 4G"
                extra = "Global"
            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2G"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2G"
                extra = "CDMA"
            ElseIf iphone.DeviceProductType = "iPad2,4" Then
                iPhonev = "iPad 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,5" Then
                iPhonev = "iPad Mini"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,6" Then
                iPhonev = "iPad Mini"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPad2,7" Then
                iPhonev = "iPad Mini"
                extra = "Global"
            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3GS"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"
                extra = "CDMA"
            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPhone3,2" Then
                iPhonev = "iPhone 4"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4S"
                extra = "AT&T/Verizon/Sprint"
            ElseIf iphone.DeviceProductType = "iPhone5,1" Then
                iPhonev = "iPhone 5"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPhone5,2" Then
                iPhonev = "iPhone 5"
                extra = "Global"
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
            Label1.Text = "Waiting for device" + cc
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
            Label1.Text = "Waiting for device" + cc
        ElseIf iphone.IsConnected = True Then
            'The user plugged their devcie back in!
            Button2.Enabled = True
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Label1.Text = "Connected (Automatic Mode)"
            'Once again determine which device they have...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod Touch 3G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod5,1" Then
                iPhonev = "iPod Touch 5G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod Touch 4G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod Touch 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod Touch 1G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad3,1" Then
                iPhonev = "iPad 3G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad3,2" Then
                iPhonev = "iPad 3G"
                extra = "Verizon"
            ElseIf iphone.DeviceProductType = "iPad3,3" Then
                iPhonev = "iPad 3G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPad3,3" Then
                iPhonev = "iPad 4G"
                extra = "Wifi"
            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2G"
                extra = "Verizon"
            ElseIf iphone.DeviceProductType = "iPad2,4" Then
                iPhonev = "iPad 2G"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPad2,5" Then
                iPhonev = "iPad Mini"
                extra = "WiFi"
            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3G"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3GS"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"
                extra = "Verizon"
            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone3,2" Then
                iPhonev = "iPhone 4"
                extra = "AT&T"
            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4S"
                extra = "AT&T/Verizon/Sprint"
            ElseIf iphone.DeviceProductType = "iPhone5,1" Then
                iPhonev = "iPhone 5"
                extra = "GSM"
            ElseIf iphone.DeviceProductType = "iPhone5,2" Then
                iPhonev = "iPhone 5"
                extra = "GSM/CDMA"
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
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Credits!
        MessageBox.Show("Originally made by The Private Dev Team as 'Jailbreak Helper', edited and updated by PTEC Productions. If you find any bugs or if there's anything missing, feel free to email me at ptecproductions@gmail.com.", "Jailbreak Assistant")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'User wants to know how to jailbreak!
        If iPhonev = "iPod Touch 2G" And model = "" Then
            Form7.Show()
        End If
        If iPhonev = "iPod Touch 3G" Then
            ipt3(firmware)
        ElseIf iPhonev = "iPod Touch 4G" Then
            ipt4(firmware)
        ElseIf iPhonev = "iPod Touch 5G" Then
            ipt5(firmware)
        ElseIf iPhonev = "iPod Touch 2G" Then
            If model.Contains("MC") Then
                ipt2mc(firmware)
            ElseIf model.Contains("MB") Then
                ipt2mb(firmware)
            End If
        ElseIf iPhonev = "iPod Touch 1G" Then
            ipt1(firmware)
        ElseIf iPhonev = "iPhone 2G" Then
            iph2(firmware)
        ElseIf iPhonev = "iPhone 3G" Then
            iph3(firmware)
        ElseIf iPhonev = "iPhone 3GS" Then
            iph3gs(firmware)
        ElseIf iPhonev = "iPhone 4" Then
            iph4(firmware)
        ElseIf iPhonev = "iPhone 4S" Then
            iph4s(firmware)
        ElseIf iPhonev = "iPhone 5" Then
            iph5(firmware)
        ElseIf iPhonev = "iPad 1G" Then
            ip1(firmware)
        ElseIf iPhonev = "iPad 2G" Then
            ip2(firmware)
        ElseIf iPhonev = "iPad 3G" Then
            ip3(firmware)
        ElseIf iPhonev = "iPad 4G" Then
            ip4(firmware)
        ElseIf iPhonev = "iPad Mini" Then
            ipm(firmware)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Timer1.Stop()
            Timer2.Stop()
            Label1.Text = "Manual mode"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 0
            Button2.Enabled = True
            Form6.Show()
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
        Form6.Show()
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