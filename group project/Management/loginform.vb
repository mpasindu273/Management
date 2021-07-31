imports System.Data.SqlClient

Public Class loginform

    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con, con1 As New SqlConnection(strAccConn)
    Dim sql As String
    Public realname, password, account, uname As String

    Private Sub stulogin()
        con = New SqlConnection(strAccConn)
        sql = "Select PW, First_name, Course From student Where Student_ID = @id"
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("id", tuname.Text)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()
                password = oleAccReader.GetValue(0)
                realname = oleAccReader.GetString(1)
                My.Settings.course = oleAccReader.GetString(2)
                My.Settings.Save()
            End While
        End If

        oleAccReader.Close()
        con.Close()

        If tpass.Text.Equals(password) Then         
            My.Settings.stuID = tuname.Text
            My.Settings.stuPW = tpass.Text
            stumainframe.Show()
            Me.Hide()
        Else
            luname.ForeColor = Color.Gold
            lpass.ForeColor = Color.Gold
            terror.Text = "**Invalid Index or Password!**"
        End If
    End Sub

    Sub leclogin()
        con = New SqlConnection(strAccConn)
        sql = "Select PW, Subject, Lecturer_name, Username, Course From lecturer Where Username = @n"
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("n", tuname.Text)
        'oleAccCommand.Parameters.AddWithValue("p", tpass.Text)

        con.Open()

        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                password = oleAccReader.GetString(0)
                My.Settings.field = oleAccReader.GetString(1)
                My.Settings.Save()
                realname = oleAccReader.GetString(2)
                uname = oleAccReader.GetString(3)
                My.Settings.course = oleAccReader.GetString(4)
                My.Settings.Save()
            End While

        End If

        oleAccReader.Close()
        con.Close()

        If tpass.Text.Equals(password) And tuname.Text.Equals(uname) Then
            My.Settings.lecID = tuname.Text
            My.Settings.lecPW = tpass.Text
            lecturemainframe.Show()
            Me.Hide()
        Else
            luname.ForeColor = Color.Gold
            lpass.ForeColor = Color.Gold
            terror.Text = "**Invalid Index or Password!**"
        End If
    End Sub

    Sub adminlogin()
        If tpass.Text.Equals(My.Settings.adminpw) Then
            My.Settings.lecID = tuname.Text
            My.Settings.lecPW = tpass.Text
            adminmainframe.Show()
            Me.Hide()
        Else
            luname.ForeColor = Color.Gold
            lpass.ForeColor = Color.Gold
            terror.Text = "**Incorrect Password!**"
        End If
    End Sub



    Private Sub tuname_TextChanged(sender As Object, e As EventArgs) Handles tuname.TextChanged
        terror.Text = ""
        luname.ForeColor = Color.White
        lpass.ForeColor = Color.White
    End Sub

    Private Sub tpass_TextChanged(sender As Object, e As EventArgs) Handles tpass.TextChanged
        terror.Text = ""
        luname.ForeColor = Color.White
        lpass.ForeColor = Color.White
    End Sub

    Private Sub clrbtn_Click(sender As Object, e As EventArgs) Handles clrbtn.Click
        tuname.Text = ""
        tpass.Text = ""
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        If My.Settings.account = "student" Then
            stulogin()
        End If
        If My.Settings.account = "lecturer" Then
            leclogin()
        End If
        If My.Settings.account = "admin" Then
            tuname.Text = "Admin"
            adminlogin()
        End If
    End Sub

    Private Sub bback_Click(sender As Object, e As EventArgs) Handles bback.Click
        tuname.Text = ""
        tpass.Text = ""
        Me.Hide()
        start.Show()
    End Sub

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub


End Class
