Public Class SettingsPanel
#Region "Load Settings"
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load update settings.
        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SB/SB.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then

                Else
                    UpdaterPrompt.Show()
                End If

            Catch
                Errordiag.Show()
                Errordiag.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 2 Then
            
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
#Region "Links"
    Private Sub GeneralSettingsLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GeneralSettingsLink.LinkClicked
        SettingsPanelGeneral.Show()
        Me.Close()
    End Sub

    Private Sub PersonaliseLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PersonaliseLink.LinkClicked
        SettingsPanelPersonalise.Show()
        Me.Close()
    End Sub

    Private Sub UpdatesLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles UpdatesLink.LinkClicked
        SettingsPanelUpdates.Show()
        Me.Close()
    End Sub

#End Region
#Region "Other"

#End Region

    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        Resetdiag.ShowDialog()

        
    End Sub

    Private Sub HelpButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpButton.Click
        Errordiag.Show()
        Errordiag.Label1.Text = "This feature is not available yet."
    End Sub
End Class