Public Class Updater
#Region "Updater"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label1.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            CheckForUpdates()
        End If
    End Sub

    Public Sub CheckForUpdates()
        Try
            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SB/SB.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Label2.Text = ("No updates available.")
                Else
                    WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SB/SB%20Setup.exe")
                    Label2.Text = ("Downloading updates...")
                    Me.Hide()
                End If
            End If

        Catch ex As Exception
            Errordiag.Show()
            Errordiag.Label1.Text = "No connection to the update server."
        End Try
    End Sub
#End Region
#Region "Load Settings"
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load parent settings.
        Label4.Parent = PictureBox2
        PictureBox1.Parent = PictureBox2

        'Start checking for updates
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
    End Sub
#End Region
#Region "Buttons"

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
#End Region
End Class