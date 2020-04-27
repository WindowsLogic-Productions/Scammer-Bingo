Public Class UpdaterPrompt
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Information.Show()
        Information.Label1.Text = "It is important to install updates for the latest features and fixes."
    End Sub

    Private Sub UpdaterPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load parent settings.
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Updater.Dispose()
        Updater.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PostponeButton_Click(sender As Object, e As EventArgs) Handles PostponeButton.Click
        Me.Close()
    End Sub
End Class