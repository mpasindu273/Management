﻿Public Class stumainframe
    Dim s, m, h As Integer
    Dim sec, min, hour As String


    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick
        s = DateTime.Now.TimeOfDay.Seconds
        m = DateTime.Now.TimeOfDay.Minutes
        h = DateTime.Now.TimeOfDay.Hours

        ldate.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        sec = String.Format("{0:0#}", s)
        min = String.Format("{0:0#}", m)
        Hour = String.Format("{0:0#}", h)

        ls.Text = sec
        lm.Text = min
        lh.Text = hour
    End Sub


    Private Sub stumainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lwelcome.Text = "Hello " & loginform.realname & ", Welcome!"
    End Sub

    Private Sub bpassword_Click(sender As Object, e As EventArgs) Handles bpassword.Click
        changepwd.Show()
        Me.Hide()
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        loginform.tuname.Clear()
        loginform.tpass.Clear()
        start.Show()
        Me.Close()
    End Sub

    Private Sub bschedule_Click(sender As Object, e As EventArgs) Handles bschedule.Click, bschedule.Click
        viewstuschedule.Show()       
    End Sub

    Private Sub bnotice_Click(sender As Object, e As EventArgs) Handles bnotice.Click
        notice.Show()
        Me.Hide()
    End Sub

    Private Sub bresults_Click(sender As Object, e As EventArgs) Handles bresults.Click
        viewresults.Show()
        Me.Hide()
    End Sub
End Class