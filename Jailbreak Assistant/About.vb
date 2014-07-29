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

Public Class About

    
    
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githubLink.LinkClicked
        Process.Start("https://github.com/outofink/jailbreak-assistant")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles siteButton.Click
        Process.Start("http://outofinksoftware.com")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles licenseButton.Click
        Process.Start("notepad.exe", "LICENSE.txt")
    End Sub
End Class
