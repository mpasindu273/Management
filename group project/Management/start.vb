Public Class start

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'addresults.Show()
        'notice.Show()
        'viewstuschedule.Show()       
    End Sub

    Private Sub bstudent_Click(sender As Object, e As EventArgs) Handles bstudent.Click
        My.Settings.account = "student"
        My.Settings.Save()
        loginform.Show()
        loginform.luname.Text = "Index :"
        loginform.tuname.Clear()
        loginform.tuname.ReadOnly = False
        loginform.tuname.Focus()
        'loginform.tuname.Text = "IT001"
        'loginform.tpass.Text = "123"
        Me.Close()
    End Sub


    Private Sub blecturer_Click(sender As Object, e As EventArgs) Handles blecturer.Click
        My.Settings.account = "lecturer"
        My.Settings.Save()
        loginform.Show()
        loginform.luname.Text = "Username :"
        loginform.tuname.Clear()
        loginform.tuname.ReadOnly = False
        loginform.tuname.Focus()
        Me.Close()
    End Sub


    Private Sub badmin_Click(sender As Object, e As EventArgs) Handles badmin.Click
        My.Settings.account = "admin"
        My.Settings.Save()
        loginform.Show()
        loginform.luname.Text = "User :"
        loginform.tuname.ReadOnly = True
        loginform.tuname.Text = "Admin"
        loginform.tpass.Focus()
        Me.Close()
    End Sub


    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class