Public Class WhatsNew

    Private Sub WhatsNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.ListBox1.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class