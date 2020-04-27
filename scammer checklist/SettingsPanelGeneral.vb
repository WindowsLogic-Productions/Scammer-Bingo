Public Class SettingsPanelGeneral
#Region "Load Settings"
    Private Sub SettingsPanelGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load automatic reset settings.
        If My.Settings.ScamReset = 1 Then
            Me.ResetON.Checked = True
        End If

        If My.Settings.ScamReset = 0 Then
            Me.ResetOFF.Checked = True
        End If

        'Load message box settings.
        If My.Settings.MsgBox = 1 Then
            Me.MsgBoxON.Checked = True
        End If

        If My.Settings.MsgBox = 0 Then
            Me.MsgBoxOFF.Checked = True
        End If

        'Load bingo slot settings.
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

        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Settings"
    Private Sub ResetON_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ResetON.CheckedChanged
        If Me.ResetON.Checked = True Then
            My.Settings.ScamReset = 1
        End If
    End Sub

    Private Sub ResetOFF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ResetOFF.CheckedChanged
        If Me.ResetOFF.Checked = True Then
            My.Settings.ScamReset = 0
        End If
    End Sub

    Private Sub MsgBoxON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgBoxON.CheckedChanged
        If Me.MsgBoxON.Checked = True Then
            My.Settings.MsgBox = 1
        End If
    End Sub

    Private Sub MsgBoxOFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgBoxOFF.CheckedChanged
        If Me.MsgBoxOFF.Checked = True Then
            My.Settings.MsgBox = 0
        End If
    End Sub

    Private Sub MsgBox1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgBox1Button.Click
        My.Settings.MessageBoxHandler = 1
        Dim MBC As New MessageBoxChange
        MBC.TextBox1.Text = My.Settings.MsgBox1
        MBC.Text = "Modify '6/12' Message Box"
        MBC.ShowDialog()
    End Sub

    Private Sub MsgBox2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgBox2Button.Click
        My.Settings.MessageBoxHandler = 2
        Dim MBC As New MessageBoxChange
        MBC.TextBox1.Text = My.Settings.MsgBox2
        MBC.Text = "Modify '12/12' Message Box"
        MBC.ShowDialog() 
    End Sub

    Private Sub BingoSlot1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot1.Click
        My.Settings.BingoSlotHandler = 1
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot1
        BC.Text = "Modify Bingo Slot 1"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot2.Click
        My.Settings.BingoSlotHandler = 2
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot2
        BC.Text = "Modify Bingo Slot 2"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot3.Click
        My.Settings.BingoSlotHandler = 3
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot3
        BC.Text = "Modify Bingo Slot 3"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot4.Click
        My.Settings.BingoSlotHandler = 4
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot4
        BC.Text = "Modify Bingo Slot 4"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot5.Click
        My.Settings.BingoSlotHandler = 5
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot5
        BC.Text = "Modify Bingo Slot 5"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot6.Click
        My.Settings.BingoSlotHandler = 6
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot6
        BC.Text = "Modify Bingo Slot 6"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot7.Click
        My.Settings.BingoSlotHandler = 7
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot7
        BC.Text = "Modify Bingo Slot 7"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot8.Click
        My.Settings.BingoSlotHandler = 8
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot8
        BC.Text = "Modify Bingo Slot 8"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot9.Click
        My.Settings.BingoSlotHandler = 9
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot9
        BC.Text = "Modify Bingo Slot 9"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot10.Click
        My.Settings.BingoSlotHandler = 10
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot10
        BC.Text = "Modify Bingo Slot 10"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot11.Click
        My.Settings.BingoSlotHandler = 11
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot11
        BC.Text = "Modify Bingo Slot 11"
        BC.ShowDialog()
    End Sub

    Private Sub BingoSlot12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingoSlot12.Click
        My.Settings.BingoSlotHandler = 12
        Dim BC As New ButtonChange
        BC.TextBox1.Text = My.Settings.BingoSlot12
        BC.Text = "Modify Bingo Slot 12"
        BC.ShowDialog()
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