Public Class lecturemainframe
    Dim s, m, h As Integer
    Dim sec, min, hour As String

    Private Sub lecturemainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lwelcome.Text = "Hello Mr. " & loginform.realname & ", Welcome!"
    End Sub

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


    Private Sub bnotice_Click(sender As Object, e As EventArgs) Handles bnotice.Click
        editnotice.Show()
        Me.Hide()
    End Sub


    Private Sub buname_Click(sender As Object, e As EventArgs) Handles buname.Click
        changeuname.Show()
        Me.Hide()
    End Sub

    Private Sub bpass_Click(sender As Object, e As EventArgs) Handles bpass.Click
        changepwd.Show()
        Me.Hide()
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        loginform.tuname.Text = ""
        loginform.tpass.Text = ""
        start.Show()
        Me.Close()
        loginform.Close()
    End Sub

    Private Sub bschedule_Click(sender As Object, e As EventArgs) Handles bschedule.Click, bschedule.Click
        viewstuschedule.Show()
    End Sub

    Private Sub bresults_Click(sender As Object, e As EventArgs) Handles bresults.Click, bresults.Click
        addresults.Show()
        Me.Hide()
    End Sub

    Private Sub bview_Click(sender As Object, e As EventArgs) Handles bview.Click
        notice.Show()
    End Sub
End Class