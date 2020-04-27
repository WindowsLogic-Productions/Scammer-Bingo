<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UpdatesLink = New System.Windows.Forms.LinkLabel()
        Me.PersonaliseLink = New System.Windows.Forms.LinkLabel()
        Me.GeneralSettingsLink = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdatesLink
        '
        Me.UpdatesLink.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.UpdatesLink.AutoSize = True
        Me.UpdatesLink.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesLink.LinkColor = System.Drawing.Color.White
        Me.UpdatesLink.Location = New System.Drawing.Point(54, 135)
        Me.UpdatesLink.Name = "UpdatesLink"
        Me.UpdatesLink.Size = New System.Drawing.Size(97, 32)
        Me.UpdatesLink.TabIndex = 2
        Me.UpdatesLink.TabStop = True
        Me.UpdatesLink.Text = "Updates"
        Me.ToolTip1.SetToolTip(Me.UpdatesLink, "Change how updates are installed to your computer.")
        '
        'PersonaliseLink
        '
        Me.PersonaliseLink.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.PersonaliseLink.AutoSize = True
        Me.PersonaliseLink.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaliseLink.LinkColor = System.Drawing.Color.White
        Me.PersonaliseLink.Location = New System.Drawing.Point(276, 76)
        Me.PersonaliseLink.Name = "PersonaliseLink"
        Me.PersonaliseLink.Size = New System.Drawing.Size(125, 32)
        Me.PersonaliseLink.TabIndex = 1
        Me.PersonaliseLink.TabStop = True
        Me.PersonaliseLink.Text = "Personalise"
        Me.ToolTip1.SetToolTip(Me.PersonaliseLink, "Change the settings for colour, backgrounds and sounds.")
        '
        'GeneralSettingsLink
        '
        Me.GeneralSettingsLink.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.GeneralSettingsLink.AutoSize = True
        Me.GeneralSettingsLink.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralSettingsLink.LinkColor = System.Drawing.Color.White
        Me.GeneralSettingsLink.Location = New System.Drawing.Point(54, 76)
        Me.GeneralSettingsLink.Name = "GeneralSettingsLink"
        Me.GeneralSettingsLink.Size = New System.Drawing.Size(93, 32)
        Me.GeneralSettingsLink.TabIndex = 0
        Me.GeneralSettingsLink.TabStop = True
        Me.GeneralSettingsLink.Text = "General"
        Me.ToolTip1.SetToolTip(Me.GeneralSettingsLink, "Change the general settings of the bingo.")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 17
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 10)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(427, 32)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Select a setting to change to your liking..."
        '
        'HelpButton
        '
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HelpButton.Location = New System.Drawing.Point(354, 210)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help..."
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResetButton.Location = New System.Drawing.Point(253, 210)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(95, 23)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "Reset Settings"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SCAMbingo1.My.Resources.Resources.ssUpdate
        Me.PictureBox5.Location = New System.Drawing.Point(16, 135)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.SCAMbingo1.My.Resources.Resources.ssSketchPad
        Me.PictureBox7.Location = New System.Drawing.Point(238, 76)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 21
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.SCAMbingo1.My.Resources.Resources.ssScammer
        Me.PictureBox8.Location = New System.Drawing.Point(16, 76)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 19
        Me.PictureBox8.TabStop = False
        '
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(441, 245)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.UpdatesLink)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PersonaliseLink)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.GeneralSettingsLink)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents UpdatesLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PersonaliseLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents GeneralSettingsLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents HelpButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
End Class
