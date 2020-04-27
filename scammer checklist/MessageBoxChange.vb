Public Class MessageBoxChange

    Private Sub MessageBoxChange1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If My.Settings.MessageBoxHandler = 1 Then
            My.Settings.MsgBox1 = Me.TextBox1.Text
            My.Settings.Save()
            Me.Dispose()
        End If

        If My.Settings.MessageBoxHandler = 2 Then
            My.Settings.MsgBox2 = Me.TextBox1.Text
            My.Settings.Save()
            Me.Dispose()
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class