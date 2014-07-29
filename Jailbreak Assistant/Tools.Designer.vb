<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.toolIcon = New System.Windows.Forms.PictureBox()
        Me.backupText = New System.Windows.Forms.Label()
        Me.descriptionText = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.siteButton = New System.Windows.Forms.Button()
        Me.leadText = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.Label()
        CType(Me.toolIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolIcon
        '
        Me.toolIcon.Location = New System.Drawing.Point(12, 74)
        Me.toolIcon.Name = "toolIcon"
        Me.toolIcon.Size = New System.Drawing.Size(64, 64)
        Me.toolIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.toolIcon.TabIndex = 0
        Me.toolIcon.TabStop = False
        '
        'backupText
        '
        Me.backupText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupText.Location = New System.Drawing.Point(12, 151)
        Me.backupText.Name = "backupText"
        Me.backupText.Size = New System.Drawing.Size(440, 24)
        Me.backupText.TabIndex = 1
        Me.backupText.Text = "Backup your iDevice before jailbreaking!"
        Me.backupText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'descriptionText
        '
        Me.descriptionText.BackColor = System.Drawing.SystemColors.Control
        Me.descriptionText.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionText.Location = New System.Drawing.Point(82, 74)
        Me.descriptionText.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.Size = New System.Drawing.Size(370, 64)
        Me.descriptionText.TabIndex = 2
        Me.descriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(377, 196)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 2
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'siteButton
        '
        Me.siteButton.Location = New System.Drawing.Point(149, 196)
        Me.siteButton.Name = "siteButton"
        Me.siteButton.Size = New System.Drawing.Size(163, 23)
        Me.siteButton.TabIndex = 1
        Me.siteButton.Text = "Go to 's website"
        Me.siteButton.UseVisualStyleBackColor = True
        '
        'leadText
        '
        Me.leadText.AutoSize = True
        Me.leadText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leadText.Location = New System.Drawing.Point(13, 9)
        Me.leadText.Name = "leadText"
        Me.leadText.Size = New System.Drawing.Size(221, 16)
        Me.leadText.TabIndex = 5
        Me.leadText.Text = "The tool you should jailbreak with is:"
        '
        'nameText
        '
        Me.nameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.Location = New System.Drawing.Point(9, 34)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(443, 37)
        Me.nameText.TabIndex = 6
        Me.nameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(464, 231)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.leadText)
        Me.Controls.Add(Me.siteButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.descriptionText)
        Me.Controls.Add(Me.backupText)
        Me.Controls.Add(Me.toolIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tools"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.toolIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolIcon As System.Windows.Forms.PictureBox
    Friend WithEvents backupText As System.Windows.Forms.Label
    Friend WithEvents descriptionText As System.Windows.Forms.Label
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents siteButton As System.Windows.Forms.Button
    Friend WithEvents leadText As System.Windows.Forms.Label
    Friend WithEvents nameText As System.Windows.Forms.Label
End Class
