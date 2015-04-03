<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jail41mc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jail41mc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This is your choice for an untethered jailbreak:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "What is an untethered jailbreak?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(322, 80)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Run selected tool and view video tutorial"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(359, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.RadioButton2.Image = Global.JailbreakAssistant.My.Resources.Resources.greenpois0n
        Me.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton2.Location = New System.Drawing.Point(31, 25)
        Me.RadioButton2.MaximumSize = New System.Drawing.Size(440, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.RadioButton2.Size = New System.Drawing.Size(440, 102)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "GreenPois0n is a quick simple jailbreak by Chronic Dev-Team. It does not require " & _
    "reinstallation of your iPod firmware if you are running a supported firmware ver" & _
    "sion."
        Me.RadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'jail41mc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 221)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "jail41mc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jailbreak Assistant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
