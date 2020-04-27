<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhatsNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 53)
        Me.Panel1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "See what's changed in the application..."
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~Version 5.1.2.0~ (5.2's Service Pack 2 Update)", "1. Fixed issue when finding an update, the update dialogue would stay on top.", "2. Added character limit to bingo slot modification.", "3. Added 'Reset Settings' option.", "4. Added reset settings confirmation dialogue.", "5. Added 'Help...' button in 'Settings Panel' for version 6.0.0.0.", "", "~Version 5.1.1.0~ (5.1's Service Pack 1 Update)", "1. Fixed bug that was stopping the sound from being muted.", "2. Added 'About - More...' dialogue.", "3. Cleaned up code.", "4. 'Scammer Database' now connects to an external database.", "5. Added exit confirmation dialogue.", "", "~Version 5.1.0.1~", "1. Fixed a bug that stopped the custom background from saving.", "2. Fixed a bug where the sound scheme would not change.", "3. Minor interface design changes.", "4. Fixed message box settings.", "5. Fixed bingo slot settings.", "", "~Version 5.1.0.0~", "1. Redesigned the whole application.", "2. Fixed issue where the half way point was at 5/12 instead of 6/12.", "3. Restarted 'Scammer Credentials' from scratch and renamed it to 'Scammer Databa" & _
                "se'.", "4. Changed one of the buttons to, Dablu Dablu Dablu.", "5. Redesigned 'Settings' and renamed it to 'Settings Panel'.", "6. Added personalisation settings.", "7. Added message box and bingo slot settings.", "8. Added update settings.", "9. Removed 'Member Dashboard' link.", "10. Cleaned up code.", "", "~Version 5.0.0.1~", "1. Fixed issue with 'Fake English Name' button.", "2. Changed tooltip for 'Member Dashboard' link.", "", "~Version 5.0.0.0~", "1. Updated 'Scammer Credentials' database.", "2. Changed buttons.", "3. Slight interface design change.", "4. Changed application name to 'Scam Helper'.", "5. Added the placeholder for the 'Help Centre'.", "6. Renamed 'Scam Credentials' to 'Scam Database'.", "7. Renamed 'Send Scammer Credentials' to 'Add to Scammer Database'.", "8. Added advertisement for WLP member dashboard.", "", "~Version 4.0.0.3~", "1. Updated 'Scammer Credentials' database.", "", "~Version 4.0.0.2~", "1. Updated 'Scammer Credentials' database.", "2. Fixed an issue when updating and being bumped to the new server.", "", "~Version 4.0.0.1~", "1. Updated 'Scammer Credentials' database.", "2. Fixed 'Send Scammer Credentials' dialogue to redirect to the right web page.", "", "~Version 4.0.0.0~", "1. Added tooltip for 'WLP Navigator' link.", "2. Added ability to check for updates.", "3. Updated 'Lewis's Tech' logo to match YouTube.", "", "~Version 3.0.1.0~", "1. Added 'Update Log'.", "2. Added a group box on 'Bingo' to advertise more applications made by WLP.", "3. Updated 'Scammer Credentials'.", "4. Cleaned up code."})
        Me.ListBox1.Location = New System.Drawing.Point(0, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 314)
        Me.ListBox1.TabIndex = 48
        '
        'WhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(531, 367)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WhatsNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What's New?"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
