<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpCentre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpCentre))
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SupportButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'SettingsButton
        '
        Me.SettingsButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssSettings
        Me.SettingsButton.Location = New System.Drawing.Point(140, 0)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(36, 36)
        Me.SettingsButton.TabIndex = 36
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'SupportButton
        '
        Me.SupportButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssSet
        Me.SupportButton.Location = New System.Drawing.Point(105, 0)
        Me.SupportButton.Name = "SupportButton"
        Me.SupportButton.Size = New System.Drawing.Size(36, 36)
        Me.SupportButton.TabIndex = 35
        Me.SupportButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssHome
        Me.HomeButton.Location = New System.Drawing.Point(70, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(36, 36)
        Me.HomeButton.TabIndex = 34
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(35, 0)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 33
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 32
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 37)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(634, 416)
        Me.WebBrowser1.TabIndex = 0
        '
        'HelpCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(634, 452)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.SupportButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpCentre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help and Support Centre"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents SupportButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
