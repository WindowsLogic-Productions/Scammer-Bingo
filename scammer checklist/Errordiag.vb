Public Class Errordiag

    Private Sub sserror_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load sound settings.
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Critical2, AudioPlayMode.Background)
        End If
        If My.Settings.HubSounds = 2 Then
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class