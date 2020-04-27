Public Class ScamNums
#Region "Load Settings"
    Private Sub ScamNums_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Select adhoc settings.
        My.Settings.AdhocHandler = 0

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

        'Load database.
        Try
            Dim dbrequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SB/DB.txt")
            Dim dbresponse As System.Net.HttpWebResponse = dbrequest.GetResponse()
            Dim dbsr As System.IO.StreamReader = New System.IO.StreamReader(dbresponse.GetResponseStream())
            Dim dbcontents = dbsr.ReadToEnd()
            TextBox1.Text = dbcontents
        Catch
            Errordiag.Show()
            Errordiag.Label1.Text = "Error collecting database information."
        End Try
    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://tech-support-scam.wikia.com/wiki/List_of_known/possible_scammers")
    End Sub
End Class