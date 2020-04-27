Public Class Exitdiag

    Private Sub Exitdiag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load sound settings.
        Variables.Sound_Settings_Question()
    End Sub

    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles YesButton.Click
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles NoButton.Click
        Me.Close()

    End Sub

    
End Class