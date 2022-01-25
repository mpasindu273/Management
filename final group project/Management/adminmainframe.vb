Imports System.Data.SqlClient

Public Class adminmainframe
    Dim s, m, h As Integer
    Dim sec, min, hour As String
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql As String
    Dim con As New SqlConnection

    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick
        s = DateTime.Now.TimeOfDay.Seconds
        m = DateTime.Now.TimeOfDay.Minutes
        h = DateTime.Now.TimeOfDay.Hours

        ldate.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        sec = String.Format("{0:0#}", s)
        min = String.Format("{0:0#}", m)
        hour = String.Format("{0:0#}", h)

        ls.Text = sec
        lm.Text = min
        lh.Text = hour
    End Sub



    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        loginform.tuname.Clear()
        loginform.tpass.Clear()
        start.Show()
        Me.Close()
    End Sub

    Private Sub bpassword_Click(sender As Object, e As EventArgs) Handles bpassword.Click
        changepwd.Show()
        Me.Hide()
    End Sub

    Private Sub bnotice_Click(sender As Object, e As EventArgs) Handles bnotice.Click
        editnotice.Show()
        Me.Hide()
    End Sub

    Private Sub adminmainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bschedule_Click(sender As Object, e As EventArgs) Handles bschedule.Click
        editschedule.Show()
    End Sub

    Private Sub bstudent_Click(sender As Object, e As EventArgs) Handles bstudent.Click
        editstudent.Show()
    End Sub

    Private Sub blecturer_Click(sender As Object, e As EventArgs) Handles blecturer.Click
        editlecturer.Show()
    End Sub

    Private Sub beditcourse_Click(sender As Object, e As EventArgs) Handles beditcourse.Click
        editcourse.Show()
    End Sub
End Class