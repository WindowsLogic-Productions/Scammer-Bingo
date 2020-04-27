Public Class Form1
    Dim Score As Integer
    Dim numone As Integer
    Dim scamtotal As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub
    Private Sub btncerti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerti.Click
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btncerti.Enabled = False
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnrun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrun.Click
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnrun.Enabled = False
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnsuppme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuppme.Click
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnsuppme.Enabled = False
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnpaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaid.Click
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        Me.btnpaid.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscan.Click
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        If Val(lblscore.Text) = 6 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        Me.btnscan.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnwiruses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwiruses.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnwiruses.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnet.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnnet.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btncmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncmd.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btncmd.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnnetstat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnetstat.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnnetstat.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btntree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntree.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btntree.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub btnkoob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkoob.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnkoob.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
        End If
    End Sub

    Private Sub btnvwr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvwr.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        lblscore.Text = Val(lbl1.Text) + Val(lblscore.Text)
        Me.btnvwr.Enabled = False
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub lblscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblscore.Click
        If Val(lblscore.Text) = 5 Then
            MsgBox("You're Half Way There, You can reveal yourself now if it's taking too long.")
        End If
        If Val(lblscore.Text) = 12 Then
            MsgBox("Well done, you Win - You have found a typical Scammer! - time to reveal yourself!!")
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("https://www.youtube.com/channel/UCLZxPVkEvf9XuifStuHK_gA")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://www.mediafire.com/download/gocjn2yf3kryc18/SCAMMER_Numbers%2C_IPs%2C_Skypes%2C_and_Websites.txt")
    End Sub
End Class
