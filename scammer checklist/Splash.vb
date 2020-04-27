Public Class Splash

    Private Sub Splash_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.NT, AudioPlayMode.Background)
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        CancelButton1.Parent = PictureBox1
        Timer1.Start()
    End Sub

    Public Sub CheckForUpdates()

        Try
            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/Scammer%20Checklist%20Updates/Scammer.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Bingo.Show()
                    Me.Close()
                Else
                    Information.Show()
                    Information.Label1.Text = "Updates are available."
                    WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/Scammer%20Checklist%20Updates/Scammer%20Bingo%20Setup.exe")
                    Me.Hide()
                End If
            End If

        Catch

        End Try

    End Sub

    Private Sub CancelButton1_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            CheckForUpdates()
        End If
    End Sub
End Class