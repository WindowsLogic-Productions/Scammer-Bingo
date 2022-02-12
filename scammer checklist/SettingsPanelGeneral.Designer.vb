<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ResetBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MsgBox1Button = New System.Windows.Forms.Button()
        Me.MsgBox2Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MsgBoxOFF = New System.Windows.Forms.RadioButton()
        Me.MsgBoxON = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BingoSlot12 = New System.Windows.Forms.Button()
        Me.BingoSlot1 = New System.Windows.Forms.Button()
        Me.BingoSlot11 = New System.Windows.Forms.Button()
        Me.BingoSlot2 = New System.Windows.Forms.Button()
        Me.BingoSlot10 = New System.Windows.Forms.Button()
        Me.BingoSlot3 = New System.Windows.Forms.Button()
        Me.BingoSlot9 = New System.Windows.Forms.Button()
        Me.BingoSlot4 = New System.Windows.Forms.Button()
        Me.BingoSlot8 = New System.Windows.Forms.Button()
        Me.BingoSlot5 = New System.Windows.Forms.Button()
        Me.BingoSlot7 = New System.Windows.Forms.Button()
        Me.BingoSlot6 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 7
        '
        'BackButton
        '
        Me.BackButton.Image = Global.SCAMbingo1.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 13)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(275, 32)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change General settings..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 206)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 180)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Automatic Reset"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ResetBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 61)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Automatic Reset"
        '
        'ResetBox
        '
        Me.ResetBox.AutoSize = True
        Me.ResetBox.Location = New System.Drawing.Point(44, 36)
        Me.ResetBox.Name = "ResetBox"
        Me.ResetBox.Size = New System.Drawing.Size(143, 17)
        Me.ResetBox.TabIndex = 2
        Me.ResetBox.Text = "Enable automatic reset"
        Me.ResetBox.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SCAMbingo1.My.Resources.Resources.ssRefresh
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 180)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Message Boxes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.MsgBox1Button)
        Me.GroupBox3.Controls.Add(Me.MsgBox2Button)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 68)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modify Message Boxes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modify the ""6/12"" or ""12/12"" message box to say what you want."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SCAMbingo1.My.Resources.Resources.ssInfo
        Me.PictureBox3.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'MsgBox1Button
        '
        Me.MsgBox1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MsgBox1Button.Location = New System.Drawing.Point(44, 37)
        Me.MsgBox1Button.Name = "MsgBox1Button"
        Me.MsgBox1Button.Size = New System.Drawing.Size(157, 23)
        Me.MsgBox1Button.TabIndex = 6
        Me.MsgBox1Button.Text = "Modify ""6/12"" Message Box"
        Me.MsgBox1Button.UseVisualStyleBackColor = True
        '
        'MsgBox2Button
        '
        Me.MsgBox2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MsgBox2Button.Location = New System.Drawing.Point(207, 37)
        Me.MsgBox2Button.Name = "MsgBox2Button"
        Me.MsgBox2Button.Size = New System.Drawing.Size(157, 23)
        Me.MsgBox2Button.TabIndex = 5
        Me.MsgBox2Button.Text = "Modify ""12/12"" Message Box"
        Me.MsgBox2Button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.MsgBoxOFF)
        Me.GroupBox1.Controls.Add(Me.MsgBoxON)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 61)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message Boxes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turn the ""6/12"" and ""12/12"" message boxes on or off."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCAMbingo1.My.Resources.Resources.ssExclamation
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MsgBoxOFF
        '
        Me.MsgBoxOFF.AutoSize = True
        Me.MsgBoxOFF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MsgBoxOFF.Location = New System.Drawing.Point(92, 35)
        Me.MsgBoxOFF.Name = "MsgBoxOFF"
        Me.MsgBoxOFF.Size = New System.Drawing.Size(52, 18)
        Me.MsgBoxOFF.TabIndex = 1
        Me.MsgBoxOFF.TabStop = True
        Me.MsgBoxOFF.Text = "OFF"
        Me.MsgBoxOFF.UseVisualStyleBackColor = True
        '
        'MsgBoxON
        '
        Me.MsgBoxON.AutoSize = True
        Me.MsgBoxON.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MsgBoxON.Location = New System.Drawing.Point(44, 35)
        Me.MsgBoxON.Name = "MsgBoxON"
        Me.MsgBoxON.Size = New System.Drawing.Size(48, 18)
        Me.MsgBoxON.TabIndex = 0
        Me.MsgBoxON.TabStop = True
        Me.MsgBoxON.Text = "ON"
        Me.MsgBoxON.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 180)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bingo Slots"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.BingoSlot12)
        Me.GroupBox4.Controls.Add(Me.BingoSlot1)
        Me.GroupBox4.Controls.Add(Me.BingoSlot11)
        Me.GroupBox4.Controls.Add(Me.BingoSlot2)
        Me.GroupBox4.Controls.Add(Me.BingoSlot10)
        Me.GroupBox4.Controls.Add(Me.BingoSlot3)
        Me.GroupBox4.Controls.Add(Me.BingoSlot9)
        Me.GroupBox4.Controls.Add(Me.BingoSlot4)
        Me.GroupBox4.Controls.Add(Me.BingoSlot8)
        Me.GroupBox4.Controls.Add(Me.BingoSlot5)
        Me.GroupBox4.Controls.Add(Me.BingoSlot7)
        Me.GroupBox4.Controls.Add(Me.BingoSlot6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 169)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Modify Bingo Slots"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Click a button below to modify its slot. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All buttons are placed in the exact pl" &
    "acement as the bingo board."
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'BingoSlot12
        '
        Me.BingoSlot12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot12.Location = New System.Drawing.Point(292, 129)
        Me.BingoSlot12.Name = "BingoSlot12"
        Me.BingoSlot12.Size = New System.Drawing.Size(100, 35)
        Me.BingoSlot12.TabIndex = 11
        Me.BingoSlot12.Text = "Slot 12"
        Me.BingoSlot12.UseVisualStyleBackColor = True
        '
        'BingoSlot1
        '
        Me.BingoSlot1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot1.Location = New System.Drawing.Point(4, 59)
        Me.BingoSlot1.Name = "BingoSlot1"
        Me.BingoSlot1.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot1.TabIndex = 0
        Me.BingoSlot1.Text = "Slot 1"
        Me.BingoSlot1.UseVisualStyleBackColor = True
        '
        'BingoSlot11
        '
        Me.BingoSlot11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot11.Location = New System.Drawing.Point(196, 129)
        Me.BingoSlot11.Name = "BingoSlot11"
        Me.BingoSlot11.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot11.TabIndex = 10
        Me.BingoSlot11.Text = "Slot 11"
        Me.BingoSlot11.UseVisualStyleBackColor = True
        '
        'BingoSlot2
        '
        Me.BingoSlot2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot2.Location = New System.Drawing.Point(100, 59)
        Me.BingoSlot2.Name = "BingoSlot2"
        Me.BingoSlot2.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot2.TabIndex = 1
        Me.BingoSlot2.Text = "Slot 2"
        Me.BingoSlot2.UseVisualStyleBackColor = True
        '
        'BingoSlot10
        '
        Me.BingoSlot10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot10.Location = New System.Drawing.Point(100, 129)
        Me.BingoSlot10.Name = "BingoSlot10"
        Me.BingoSlot10.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot10.TabIndex = 9
        Me.BingoSlot10.Text = "Slot 10"
        Me.BingoSlot10.UseVisualStyleBackColor = True
        '
        'BingoSlot3
        '
        Me.BingoSlot3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot3.Location = New System.Drawing.Point(196, 59)
        Me.BingoSlot3.Name = "BingoSlot3"
        Me.BingoSlot3.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot3.TabIndex = 2
        Me.BingoSlot3.Text = "Slot 3"
        Me.BingoSlot3.UseVisualStyleBackColor = True
        '
        'BingoSlot9
        '
        Me.BingoSlot9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot9.Location = New System.Drawing.Point(4, 129)
        Me.BingoSlot9.Name = "BingoSlot9"
        Me.BingoSlot9.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot9.TabIndex = 8
        Me.BingoSlot9.Text = "Slot 9"
        Me.BingoSlot9.UseVisualStyleBackColor = True
        '
        'BingoSlot4
        '
        Me.BingoSlot4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot4.Location = New System.Drawing.Point(292, 59)
        Me.BingoSlot4.Name = "BingoSlot4"
        Me.BingoSlot4.Size = New System.Drawing.Size(100, 35)
        Me.BingoSlot4.TabIndex = 3
        Me.BingoSlot4.Text = "Slot 4"
        Me.BingoSlot4.UseVisualStyleBackColor = True
        '
        'BingoSlot8
        '
        Me.BingoSlot8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot8.Location = New System.Drawing.Point(292, 94)
        Me.BingoSlot8.Name = "BingoSlot8"
        Me.BingoSlot8.Size = New System.Drawing.Size(100, 35)
        Me.BingoSlot8.TabIndex = 7
        Me.BingoSlot8.Text = "Slot 8"
        Me.BingoSlot8.UseVisualStyleBackColor = True
        '
        'BingoSlot5
        '
        Me.BingoSlot5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot5.Location = New System.Drawing.Point(4, 94)
        Me.BingoSlot5.Name = "BingoSlot5"
        Me.BingoSlot5.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot5.TabIndex = 4
        Me.BingoSlot5.Text = "Slot 5"
        Me.BingoSlot5.UseVisualStyleBackColor = True
        '
        'BingoSlot7
        '
        Me.BingoSlot7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot7.Location = New System.Drawing.Point(196, 94)
        Me.BingoSlot7.Name = "BingoSlot7"
        Me.BingoSlot7.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot7.TabIndex = 6
        Me.BingoSlot7.Text = "Slot 7"
        Me.BingoSlot7.UseVisualStyleBackColor = True
        '
        'BingoSlot6
        '
        Me.BingoSlot6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingoSlot6.Location = New System.Drawing.Point(100, 94)
        Me.BingoSlot6.Name = "BingoSlot6"
        Me.BingoSlot6.Size = New System.Drawing.Size(96, 35)
        Me.BingoSlot6.TabIndex = 5
        Me.BingoSlot6.Text = "Slot 6"
        Me.BingoSlot6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Automatically reset the bingo board when the score reaches 12/12."
        '
        'SettingsPanelGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsPanelGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MsgBoxOFF As System.Windows.Forms.RadioButton
    Friend WithEvents MsgBoxON As System.Windows.Forms.RadioButton
    Friend WithEvents MsgBox2Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MsgBox1Button As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BingoSlot12 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot11 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot10 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot9 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot8 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot7 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot6 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot5 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot4 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot3 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot2 As System.Windows.Forms.Button
    Friend WithEvents BingoSlot1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ResetBox As CheckBox
    Friend WithEvents Label4 As Label
End Class
