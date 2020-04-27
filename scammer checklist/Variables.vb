Public Class Variables
    Public Shared ver As String = My.Application.Info.Version.ToString
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user)
    End Sub

#Region "Settings"
#Region "Personalisation Settings"
    Public Sub Background_Settings()

    End Sub

    Public Shared Sub Sound_Settings_Bingo()
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Opening, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Opening2, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 2 Then
        End If
    End Sub

    Public Shared Sub Sound_Settings_Question()
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Exclamation, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Exclamation2, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 2 Then
        End If
    End Sub
#End Region



    Public Shared Sub Update_Settings()
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
            If My.Settings.AdhocHandler = 1 Then
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

            If My.Settings.AdhocHandler = 0 Then

            End If
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region


End Class
