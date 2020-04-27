Public Class SettingsPanelPersonalise
#Region "Load Settings"
    Private Sub SettingsPanelPersonalise_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load bingo sound settings.
        If My.Settings.HubSounds = 0 Then
            DefaultSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            ModernSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 2 Then
            MuteSoundSwitch.Checked = True
        End If

        'Load background settings.
        If My.Settings.DHBHUC = 0 Then
            HDBSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 1 Then
            HUCSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 2 Then
            RB1.Checked = True
            CB1Button.Enabled = True
            HubBackgroundPicture.Load(My.Settings.CB1)
        End If

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            CheckBox1.Checked = True
        End If
    End Sub
#End Region
#Region "Background"
    Private Sub RB1Box_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.Click
        If RB1.Checked = True Then
            CB1Button.Enabled = True
            Try
                HubBackgroundPicture.Load(My.Settings.CB1)
                Bingo.HubBackground.Load(My.Settings.CB1)
                My.Settings.DHBHUC = 2
            Catch
                Errordiag.Show()
                Errordiag.Label1.Text = "You have not chosen a background yet."
            End Try
        End If

        If RB1.Checked = False Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            HubBackgroundPicture.Image = Nothing
        End If

        My.Settings.Save()
    End Sub

    Private Sub CB1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1Button.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            HubBackgroundPicture.Load(OpenFileDialog1.FileName)
            My.Settings.CB1 = OpenFileDialog1.FileName
            Bingo.HubBackground.Load(My.Settings.CB1)
            My.Settings.Save()
        End If
    End Sub

    Private Sub HDBSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDBSwitch.CheckedChanged
        If HDBSwitch.Checked = True Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            RB1.Checked = False
            HubBackgroundPicture.Image = My.Resources.ssLegacy
            Bingo.HubBackground.Image = My.Resources.ssLegacy
            My.Settings.Save()
        End If
    End Sub

    Private Sub HUCSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HUCSwitch.CheckedChanged
        If HUCSwitch.Checked = True Then
            My.Settings.DHBHUC = 1
            CB1Button.Enabled = False
            RB1.Checked = False
            HubBackgroundPicture.Image = Nothing
            Bingo.HubBackground.Image = Nothing
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Colour Settings"

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CustomColourButton.Enabled = True
            My.Settings.CCE = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            Bingo.BackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Sound Settings"
    Private Sub DefaultSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultSoundSwitch.CheckedChanged
        If DefaultSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub ModernSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ModernSoundSwitch.CheckedChanged
        If ModernSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub MuteSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MuteSoundSwitch.CheckedChanged
        If MuteSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 2
            My.Settings.Save()
        End If
    End Sub


#End Region
#Region "Other"
    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        My.Settings.Save()
        Me.Close()
    End Sub
#End Region
End Class