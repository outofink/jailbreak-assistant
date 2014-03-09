<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.statusText = New System.Windows.Forms.Label()
        Me.deviceText = New System.Windows.Forms.Label()
        Me.iosText = New System.Windows.Forms.Label()
        Me.AutoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.recoveryButton = New System.Windows.Forms.Button()
        Me.modelText = New System.Windows.Forms.Label()
        Me.iosStatic = New System.Windows.Forms.Label()
        Me.deviceStatic = New System.Windows.Forms.Label()
        Me.modelStatic = New System.Windows.Forms.Label()
        Me.CarrierStatic = New System.Windows.Forms.Label()
        Me.CarrierText = New System.Windows.Forms.Label()
        Me.jailbreakButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.manualTimer = New System.Windows.Forms.Timer(Me.components)
        Me.manualButton = New System.Windows.Forms.Button()
        Me.AutoRadio = New System.Windows.Forms.RadioButton()
        Me.ManualRadio = New System.Windows.Forms.RadioButton()
        Me.optionsBox = New System.Windows.Forms.GroupBox()
        Me.optionsBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusText
        '
        Me.statusText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.statusText.AutoSize = True
        Me.statusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.statusText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.statusText.Location = New System.Drawing.Point(12, 159)
        Me.statusText.Name = "statusText"
        Me.statusText.Size = New System.Drawing.Size(97, 13)
        Me.statusText.TabIndex = 0
        Me.statusText.Text = "Waiting for iDevice"
        Me.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.statusText.UseMnemonic = False
        '
        'deviceText
        '
        Me.deviceText.AutoSize = True
        Me.deviceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.deviceText.Location = New System.Drawing.Point(81, 12)
        Me.deviceText.Name = "deviceText"
        Me.deviceText.Size = New System.Drawing.Size(0, 19)
        Me.deviceText.TabIndex = 2
        '
        'iosText
        '
        Me.iosText.AutoSize = True
        Me.iosText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.iosText.Location = New System.Drawing.Point(81, 42)
        Me.iosText.Name = "iosText"
        Me.iosText.Size = New System.Drawing.Size(0, 19)
        Me.iosText.TabIndex = 4
        '
        'AutoTimer
        '
        Me.AutoTimer.Interval = 500
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(11, 176)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(455, 20)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 6
        '
        'recoveryButton
        '
        Me.recoveryButton.Enabled = False
        Me.recoveryButton.Location = New System.Drawing.Point(352, 108)
        Me.recoveryButton.Name = "recoveryButton"
        Me.recoveryButton.Size = New System.Drawing.Size(114, 31)
        Me.recoveryButton.TabIndex = 7
        Me.recoveryButton.Text = "Recovery Assistant"
        Me.recoveryButton.UseVisualStyleBackColor = True
        '
        'modelText
        '
        Me.modelText.AutoSize = True
        Me.modelText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.modelText.Location = New System.Drawing.Point(81, 72)
        Me.modelText.Name = "modelText"
        Me.modelText.Size = New System.Drawing.Size(0, 19)
        Me.modelText.TabIndex = 8
        '
        'iosStatic
        '
        Me.iosStatic.AutoSize = True
        Me.iosStatic.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.iosStatic.Location = New System.Drawing.Point(12, 47)
        Me.iosStatic.Name = "iosStatic"
        Me.iosStatic.Size = New System.Drawing.Size(27, 13)
        Me.iosStatic.TabIndex = 9
        Me.iosStatic.Text = "iOS:"
        '
        'deviceStatic
        '
        Me.deviceStatic.AutoSize = True
        Me.deviceStatic.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.deviceStatic.Location = New System.Drawing.Point(12, 17)
        Me.deviceStatic.Name = "deviceStatic"
        Me.deviceStatic.Size = New System.Drawing.Size(43, 13)
        Me.deviceStatic.TabIndex = 10
        Me.deviceStatic.Text = "Device:"
        '
        'modelStatic
        '
        Me.modelStatic.AutoSize = True
        Me.modelStatic.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.modelStatic.Location = New System.Drawing.Point(12, 77)
        Me.modelStatic.Name = "modelStatic"
        Me.modelStatic.Size = New System.Drawing.Size(39, 13)
        Me.modelStatic.TabIndex = 11
        Me.modelStatic.Text = "Model:"
        '
        'CarrierStatic
        '
        Me.CarrierStatic.AutoSize = True
        Me.CarrierStatic.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.CarrierStatic.Location = New System.Drawing.Point(12, 107)
        Me.CarrierStatic.Name = "CarrierStatic"
        Me.CarrierStatic.Size = New System.Drawing.Size(44, 13)
        Me.CarrierStatic.TabIndex = 12
        Me.CarrierStatic.Text = "Carrier:"
        '
        'CarrierText
        '
        Me.CarrierText.AutoSize = True
        Me.CarrierText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CarrierText.Location = New System.Drawing.Point(81, 102)
        Me.CarrierText.Name = "CarrierText"
        Me.CarrierText.Size = New System.Drawing.Size(0, 19)
        Me.CarrierText.TabIndex = 13
        Me.CarrierText.UseMnemonic = False
        '
        'jailbreakButton
        '
        Me.jailbreakButton.Enabled = False
        Me.jailbreakButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jailbreakButton.Location = New System.Drawing.Point(274, 12)
        Me.jailbreakButton.Name = "jailbreakButton"
        Me.jailbreakButton.Size = New System.Drawing.Size(192, 90)
        Me.jailbreakButton.TabIndex = 14
        Me.jailbreakButton.Text = "Help me Jailbreak!"
        Me.jailbreakButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(352, 143)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(114, 29)
        Me.aboutButton.TabIndex = 15
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'manualTimer
        '
        '
        'manualButton
        '
        Me.manualButton.Location = New System.Drawing.Point(5, 36)
        Me.manualButton.Name = "manualButton"
        Me.manualButton.Size = New System.Drawing.Size(145, 23)
        Me.manualButton.TabIndex = 19
        Me.manualButton.Text = "Manually choose device"
        Me.manualButton.UseVisualStyleBackColor = True
        '
        'AutoRadio
        '
        Me.AutoRadio.AutoSize = True
        Me.AutoRadio.Location = New System.Drawing.Point(6, 13)
        Me.AutoRadio.Name = "AutoRadio"
        Me.AutoRadio.Size = New System.Drawing.Size(72, 17)
        Me.AutoRadio.TabIndex = 20
        Me.AutoRadio.TabStop = True
        Me.AutoRadio.Text = "Automatic"
        Me.AutoRadio.UseVisualStyleBackColor = True
        '
        'ManualRadio
        '
        Me.ManualRadio.AutoSize = True
        Me.ManualRadio.Location = New System.Drawing.Point(84, 13)
        Me.ManualRadio.Name = "ManualRadio"
        Me.ManualRadio.Size = New System.Drawing.Size(60, 17)
        Me.ManualRadio.TabIndex = 21
        Me.ManualRadio.TabStop = True
        Me.ManualRadio.Text = "Manual"
        Me.ManualRadio.UseVisualStyleBackColor = True
        '
        'optionsBox
        '
        Me.optionsBox.Controls.Add(Me.AutoRadio)
        Me.optionsBox.Controls.Add(Me.ManualRadio)
        Me.optionsBox.Controls.Add(Me.manualButton)
        Me.optionsBox.Location = New System.Drawing.Point(190, 109)
        Me.optionsBox.Name = "optionsBox"
        Me.optionsBox.Size = New System.Drawing.Size(156, 63)
        Me.optionsBox.TabIndex = 22
        Me.optionsBox.TabStop = False
        Me.optionsBox.Text = "Options:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 209)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.jailbreakButton)
        Me.Controls.Add(Me.CarrierText)
        Me.Controls.Add(Me.CarrierStatic)
        Me.Controls.Add(Me.modelStatic)
        Me.Controls.Add(Me.deviceStatic)
        Me.Controls.Add(Me.iosStatic)
        Me.Controls.Add(Me.modelText)
        Me.Controls.Add(Me.recoveryButton)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.iosText)
        Me.Controls.Add(Me.deviceText)
        Me.Controls.Add(Me.statusText)
        Me.Controls.Add(Me.optionsBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jailbreak Assistant"
        Me.optionsBox.ResumeLayout(False)
        Me.optionsBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusText As System.Windows.Forms.Label
    Friend WithEvents deviceText As System.Windows.Forms.Label
    Friend WithEvents iosText As System.Windows.Forms.Label
    Friend WithEvents AutoTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents recoveryButton As System.Windows.Forms.Button
    Friend WithEvents modelText As System.Windows.Forms.Label
    Friend WithEvents iosStatic As System.Windows.Forms.Label
    Friend WithEvents deviceStatic As System.Windows.Forms.Label
    Friend WithEvents modelStatic As System.Windows.Forms.Label
    Friend WithEvents CarrierStatic As System.Windows.Forms.Label
    Friend WithEvents CarrierText As System.Windows.Forms.Label
    Friend WithEvents jailbreakButton As System.Windows.Forms.Button
    Friend WithEvents aboutButton As System.Windows.Forms.Button
    Friend WithEvents manualTimer As System.Windows.Forms.Timer
    Friend WithEvents manualButton As System.Windows.Forms.Button
    Friend WithEvents AutoRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ManualRadio As System.Windows.Forms.RadioButton
    Friend WithEvents optionsBox As System.Windows.Forms.GroupBox

End Class
