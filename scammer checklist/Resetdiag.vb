Public Class Resetdiag

    Private Sub Resetdiag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load sound settings.
        Variables.Sound_Settings_Question()

    End Sub

    Private Sub YesButton_Click(sender As System.Object, e As System.EventArgs) Handles YesButton.Click
        My.Settings.BingoSlot1 = "Fake English Name"
        My.Settings.BingoSlot2 = "Windows Key + R"
        My.Settings.BingoSlot3 = "Do One Thing"
        My.Settings.BingoSlot4 = "One Time Charge"
        My.Settings.BingoSlot5 = "Six Digit Code"
        My.Settings.BingoSlot6 = "Wiruses"
        My.Settings.BingoSlot7 = "Network Security"
        My.Settings.BingoSlot8 = "Command Prompt"
        My.Settings.BingoSlot9 = "Each and Everything"
        My.Settings.BingoSlot10 = "Command Prompt"
        My.Settings.BingoSlot11 = "Dablu Dablu Dablu"
        My.Settings.BingoSlot12 = "Stopped Services"
        Bingo.BingoSlot1.Text = My.Settings.BingoSlot1
        Bingo.BingoSlot2.Text = My.Settings.BingoSlot2
        Bingo.BingoSlot3.Text = My.Settings.BingoSlot3
        Bingo.BingoSlot4.Text = My.Settings.BingoSlot4
        Bingo.BingoSlot5.Text = My.Settings.BingoSlot5
        Bingo.BingoSlot6.Text = My.Settings.BingoSlot6
        Bingo.BingoSlot7.Text = My.Settings.BingoSlot7
        Bingo.BingoSlot8.Text = My.Settings.BingoSlot8
        Bingo.BingoSlot9.Text = My.Settings.BingoSlot9
        Bingo.BingoSlot10.Text = My.Settings.BingoSlot10
        Bingo.BingoSlot11.Text = My.Settings.BingoSlot11
        Bingo.BingoSlot12.Text = My.Settings.BingoSlot12
        My.Settings.CCE = 1
        My.Settings.CustomColour = Color.DodgerBlue
        Me.BackColor = Color.DodgerBlue
        SettingsPanel.BackColor = Color.DodgerBlue
        My.Settings.Updates = 1
        My.Settings.DHBHUC = 0
        Bingo.HubBackground.Image = My.Resources.ssLegacy
        My.Settings.MsgBox = 1
        My.Settings.HubSounds = 0
        My.Settings.ScamReset = 1
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As System.Object, e As System.EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class