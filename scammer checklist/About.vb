Public Class About
#Region "Load Settings"
    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Information2, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Information2, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 0 Then

        End If

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load version number and license.
        Variables.ParseVariables(verinfo)
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles MoreButton.Click
        Dedicate.ShowDialog()
    End Sub
#End Region
End Class