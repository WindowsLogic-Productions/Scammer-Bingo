Public Class ButtonChange
#Region "Load Settings"
    Private Sub ButtonChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If My.Settings.BingoSlotHandler = 1 Then
            My.Settings.BingoSlot1 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot1.Text = My.Settings.BingoSlot1
            Bingo.BingoSlot1.Text = My.Settings.BingoSlot1
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 2 Then
            My.Settings.BingoSlot2 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot2.Text = My.Settings.BingoSlot2
            Bingo.BingoSlot2.Text = My.Settings.BingoSlot2
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 3 Then
            My.Settings.BingoSlot3 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot3.Text = My.Settings.BingoSlot3
            Bingo.BingoSlot3.Text = My.Settings.BingoSlot3
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 4 Then
            My.Settings.BingoSlot4 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot4.Text = My.Settings.BingoSlot4
            Bingo.BingoSlot4.Text = My.Settings.BingoSlot4
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 5 Then
            My.Settings.BingoSlot5 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot5.Text = My.Settings.BingoSlot5
            Bingo.BingoSlot5.Text = My.Settings.BingoSlot5
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 6 Then
            My.Settings.BingoSlot6 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot6.Text = My.Settings.BingoSlot6
            Bingo.BingoSlot6.Text = My.Settings.BingoSlot6
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 7 Then
            My.Settings.BingoSlot7 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot7.Text = My.Settings.BingoSlot7
            Bingo.BingoSlot7.Text = My.Settings.BingoSlot7
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 8 Then
            My.Settings.BingoSlot8 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot8.Text = My.Settings.BingoSlot8
            Bingo.BingoSlot8.Text = My.Settings.BingoSlot8
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 9 Then
            My.Settings.BingoSlot9 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot9.Text = My.Settings.BingoSlot9
            Bingo.BingoSlot9.Text = My.Settings.BingoSlot9
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 10 Then
            My.Settings.BingoSlot10 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot10.Text = My.Settings.BingoSlot10
            Bingo.BingoSlot10.Text = My.Settings.BingoSlot10
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 11 Then
            My.Settings.BingoSlot11 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot11.Text = My.Settings.BingoSlot11
            Bingo.BingoSlot11.Text = My.Settings.BingoSlot11
            My.Settings.Save()
            Me.Close()
        End If

        If My.Settings.BingoSlotHandler = 12 Then
            My.Settings.BingoSlot12 = Me.TextBox1.Text
            SettingsPanelGeneral.BingoSlot12.Text = My.Settings.BingoSlot12
            Bingo.BingoSlot12.Text = My.Settings.BingoSlot12
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
#End Region
End Class