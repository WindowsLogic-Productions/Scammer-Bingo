Public Class Bingo
#Region "Integers"
    Dim Score As Integer
    Dim numone As Integer
    Dim scamtotal As Integer
#End Region
#Region "Load Settings"

    

    Private Sub Bingo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Select adhoc settings.
        My.Settings.AdhocHandler = 1

        'Sound Settings
        Variables.Sound_Settings_Bingo()

        'Parent Settings.
        BingoSlot1.Parent = HubBackground
        BingoSlot8.Parent = HubBackground
        BingoSlot11.Parent = HubBackground
        BingoSlot7.Parent = HubBackground
        BingoSlot9.Parent = HubBackground
        BingoSlot4.Parent = HubBackground
        BingoSlot2.Parent = HubBackground
        BingoSlot5.Parent = HubBackground
        BingoSlot3.Parent = HubBackground
        BingoSlot10.Parent = HubBackground
        BingoSlot12.Parent = HubBackground
        BingoSlot6.Parent = HubBackground
        GroupBox1.Parent = HubBackground
        GroupBox2.Parent = HubBackground
        MenuStrip1.Parent = HubBackground
        Label2.Parent = HubBackground
        HubBackground.Show()


        'Automatic updates.
        Variables.Update_Settings()

        'Custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Bingo slot settings.
        BingoSlot1.Text = My.Settings.BingoSlot1
        BingoSlot2.Text = My.Settings.BingoSlot2
        BingoSlot3.Text = My.Settings.BingoSlot3
        BingoSlot4.Text = My.Settings.BingoSlot4
        BingoSlot5.Text = My.Settings.BingoSlot5
        BingoSlot6.Text = My.Settings.BingoSlot6
        BingoSlot7.Text = My.Settings.BingoSlot7
        BingoSlot8.Text = My.Settings.BingoSlot8
        BingoSlot9.Text = My.Settings.BingoSlot9
        BingoSlot10.Text = My.Settings.BingoSlot10
        BingoSlot11.Text = My.Settings.BingoSlot11
        BingoSlot12.Text = My.Settings.BingoSlot12

        'Load background settings.
        If My.Settings.DHBHUC = 0 Then
            HubBackground.Image = My.Resources.ssLegacy
        End If

        If My.Settings.DHBHUC = 1 Then
            HubBackground.Image = Nothing
        End If

        If My.Settings.DHBHUC = 2 Then
            HubBackground.Load(My.Settings.CB1)
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub btncerti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot1.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot1.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnrun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot2.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot2.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnsuppme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot3.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot3.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnpaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot4.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot4.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot5.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot5.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnwiruses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot6.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot6.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot7.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot7.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btncmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot8.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot8.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnnetstat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot9.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot9.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btntree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot10.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot10.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnkoob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot11.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot11.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub btnvwr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot12.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot12.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub

    Private Sub lblscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblscore.Click
        lblscore.Text = 1 + lblscore.Text
        Me.BingoSlot12.Enabled = False
        ErrorA()
        ErrorB()
        Reset()
    End Sub
#End Region
#Region "Messages"

    Public Sub ErrorA()
        If My.Settings.MsgBox = 1 Then
            If lblscore.Text = 6 Then
                Information.Show()
                Information.Label1.Text = My.Settings.MsgBox1
            End If
        End If

        If My.Settings.MsgBox = 0 Then

        End If
    End Sub

    Public Sub ErrorB()
        If My.Settings.MsgBox = 1 Then
            If lblscore.Text = 12 Then
                Information.Show()
                Information.Label1.Text = My.Settings.MsgBox2
            End If
        End If

        If My.Settings.MsgBox = 0 Then

        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub ResetBingoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBingoToolStripMenuItem.Click
        If lblscore.Text = lblscore.Text Then
            lblscore.Text = "0"
            BingoSlot1.Enabled = True
            BingoSlot2.Enabled = True
            BingoSlot3.Enabled = True
            BingoSlot4.Enabled = True
            BingoSlot5.Enabled = True
            BingoSlot6.Enabled = True
            BingoSlot7.Enabled = True
            BingoSlot8.Enabled = True
            BingoSlot9.Enabled = True
            BingoSlot10.Enabled = True
            BingoSlot11.Enabled = True
            BingoSlot12.Enabled = True
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsPanel.Show()
    End Sub

    Private Sub AddToScammerDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToScammerDatabaseToolStripMenuItem.Click
        SendNum.Show()
    End Sub

    Private Sub ScammerDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScammerDatabaseToolStripMenuItem.Click
        ScamNums.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Updater.Dispose()
        Updater.ShowDialog()
    End Sub

    Private Sub WhatsNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatsNewToolStripMenuItem.Click
        WhatsNew.Show()
    End Sub

    Private Sub HelpAndSupportCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAndSupportCentreToolStripMenuItem.Click
        Errordiag.Show()
        Errordiag.Label1.Text = "This feature is not available yet."
        'HelpCentre.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "Auto Reset"
    Public Sub Reset()
        If My.Settings.ScamReset = 1 And Me.lblscore.Text = "12" Then
            lblscore.Text = "0"
            BingoSlot1.Enabled = True
            BingoSlot2.Enabled = True
            BingoSlot3.Enabled = True
            BingoSlot4.Enabled = True
            BingoSlot5.Enabled = True
            BingoSlot6.Enabled = True
            BingoSlot7.Enabled = True
            BingoSlot8.Enabled = True
            BingoSlot9.Enabled = True
            BingoSlot10.Enabled = True
            BingoSlot11.Enabled = True
            BingoSlot12.Enabled = True
        End If

        If My.Settings.ScamReset = 0 And Me.lblscore.Text = "12" Then

        End If
    End Sub
#End Region
#Region "Advertisement"
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.windowslogic.co.uk/wlp-hub")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.windowslogic.co.uk/wlp-navigator")
    End Sub
#End Region

    Private Sub Bingo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Exitdiag.ShowDialog()
        e.Cancel = True
    End Sub
End Class
