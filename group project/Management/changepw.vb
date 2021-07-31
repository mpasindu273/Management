imports System.Data.SqlClient

Public Class changepwd
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con As New SqlConnection(strAccConn)
    Dim sql, sql1 As String


    Private Sub changepw()
        con = New SqlConnection(strAccConn)
        If My.Settings.account = "student" Then
            sql = "Update student Set PW = @pass Where Student_ID = @uname"
            con = New SqlConnection(strAccConn)
            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("pass", tnew.Text)
            oleAccCommand.Parameters.AddWithValue("uname", My.Settings.stuID)
            con.Open()
            oleAccCommand.ExecuteNonQuery()

            MessageBox.Show("Password changed!")
            con.Close()
            My.Settings.stuPW = tnew.Text
            My.Settings.Save()
            stumainframe.Show()
            Me.Close()

        ElseIf My.Settings.account = "lecturer" Then
            sql1 = "Update lecturer Set PW = @pass Where Lecturer_name = @uname"
            con = New SqlConnection(strAccConn)
            Dim oleAccCommand As New SqlCommand(sql1, con)
            oleAccCommand.Parameters.AddWithValue("pass", tnew.Text)
            oleAccCommand.Parameters.AddWithValue("uname", loginform.realname)
            con.Open()
            oleAccCommand.ExecuteNonQuery()

            MessageBox.Show("Password changed!")
            con.Close()
            My.Settings.lecPW = tnew.Text
            My.Settings.Save()
            lecturemainframe.Show()
            Me.Close()

        ElseIf My.Settings.account = "admin" Then
            My.Settings.adminpw = tconf.Text
            My.Settings.Save()
            MessageBox.Show("Password changed!")
            adminmainframe.Show()
            Me.Close()
        End If
    End Sub

    Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
        If tnew.Text = tconf.Text Then
            changepw()
        Else
            MsgBox("Password missmatch!", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bcheck_Click(sender As Object, e As EventArgs) Handles bcheck.Click
        If My.Settings.account = "student" Then
            If tcurrent.Text.Equals(My.Settings.stuPW) Then
                lnew.Visible = True
                lconf.Visible = True
                tnew.Visible = True
                tconf.Visible = True
                bok.Visible = True
            Else
                MsgBox("Password incorrect!", MessageBoxIcon.Warning)
            End If
        End If

        If My.Settings.account = "lecturer" Then
            If tcurrent.Text.Equals(My.Settings.lecPW) Then
                lnew.Visible = True
                lconf.Visible = True
                tnew.Visible = True
                tconf.Visible = True
                bok.Visible = True
            Else
                MsgBox("Password incorrect!", MessageBoxIcon.Warning)
            End If
        End If

        If My.Settings.account = "admin" Then
            If tcurrent.Text.Equals(My.Settings.adminpw) Then
                lnew.Visible = True
                lconf.Visible = True
                tnew.Visible = True
                tconf.Visible = True
                bok.Visible = True
            Else
                MsgBox("Password incorrect!", MessageBoxIcon.Warning)
            End If
        End If


    End Sub

    Private Sub changepwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        If My.Settings.account = "student" Then
            stumainframe.Show()
        ElseIf My.Settings.account = "lecturer" Then
            lecturemainframe.Show()
        ElseIf My.Settings.account = "admin" Then
            adminmainframe.Show()
        End If
        Me.Close()
    End Sub
End Class