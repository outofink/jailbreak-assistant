<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.iosCombo = New System.Windows.Forms.ComboBox()
        Me.deviceCombo = New System.Windows.Forms.ComboBox()
        Me.useManual = New System.Windows.Forms.Button()
        Me.cancelManual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "iOS:"
        '
        'iosCombo
        '
        Me.iosCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iosCombo.FormattingEnabled = True
        Me.iosCombo.Location = New System.Drawing.Point(73, 47)
        Me.iosCombo.Name = "iosCombo"
        Me.iosCombo.Size = New System.Drawing.Size(121, 21)
        Me.iosCombo.TabIndex = 2
        '
        'deviceCombo
        '
        Me.deviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deviceCombo.FormattingEnabled = True
        Me.deviceCombo.Location = New System.Drawing.Point(73, 12)
        Me.deviceCombo.Name = "deviceCombo"
        Me.deviceCombo.Size = New System.Drawing.Size(121, 21)
        Me.deviceCombo.TabIndex = 3
        '
        'useManual
        '
        Me.useManual.Location = New System.Drawing.Point(15, 81)
        Me.useManual.Name = "useManual"
        Me.useManual.Size = New System.Drawing.Size(102, 23)
        Me.useManual.TabIndex = 4
        Me.useManual.Text = "Use this iDevice"
        Me.useManual.UseVisualStyleBackColor = True
        '
        'cancelManual
        '
        Me.cancelManual.Location = New System.Drawing.Point(123, 81)
        Me.cancelManual.Name = "cancelManual"
        Me.cancelManual.Size = New System.Drawing.Size(71, 23)
        Me.cancelManual.TabIndex = 5
        Me.cancelManual.Text = "Cancel"
        Me.cancelManual.UseVisualStyleBackColor = True
        '
        'ManualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 116)
        Me.Controls.Add(Me.cancelManual)
        Me.Controls.Add(Me.useManual)
        Me.Controls.Add(Me.deviceCombo)
        Me.Controls.Add(Me.iosCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManualForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents iosCombo As System.Windows.Forms.ComboBox
    Friend WithEvents deviceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents useManual As System.Windows.Forms.Button
    Friend WithEvents cancelManual As System.Windows.Forms.Button
End Class
