imports System.Data.SqlClient
Public Class changeuname
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"

    Private Sub bpw_Click(sender As Object, e As EventArgs) Handles bpw.Click
        If tpass.Text.Equals(My.Settings.lecPW) Then
            luname.Visible = True
            tuname.Visible = True
            buname.Visible = True
        Else
            MsgBox("Incorrect Password!")
        End If
    End Sub

    Private Sub buname_Click(sender As Object, e As EventArgs) Handles buname.Click
        Dim con As New SqlConnection(strAccConn)
        Dim sql As String
        con = New SqlConnection(strAccConn)

        sql = "Update lecturer Set Username = @newuser Where Lecturer_name = @lecnm"
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("newuser", tuname.Text)
        oleAccCommand.Parameters.AddWithValue("lecnm", loginform.realname)
        con.Open()
        oleAccCommand.ExecuteNonQuery()

        MessageBox.Show("Username changed!")      
        con.Close()
        My.Settings.lecID = tuname.Text
        My.Settings.Save()
        lecturemainframe.Show()
        Me.Close()
    End Sub

  
    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        lecturemainframe.Show()
        Me.Close()
    End Sub

    Private Sub changeuname_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class