imports System.Data.SqlClient

Public Class loginform

    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con, con1 As New SqlConnection(strAccConn)
    Dim sql As String
    Public realname, password, account, course, subject As String

    Sub checkInternet()
        While True
            Try
                My.Computer.Network.Ping("www.google.com")
                Exit While
            Catch
                MsgBox("Internet connection error!", MessageBoxIcon.Warning)
            End Try
        End While
    End Sub

    Private Sub stulogin()
        con = New SqlConnection(strAccConn)
        sql = "Select First_name, Course From student Where Student_ID = @id and PW = @pw"
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("id", tuname.Text)
        oleAccCommand.Parameters.AddWithValue("pw", tpass.Text)

            con.Open()
            Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
            If oleAccReader.HasRows Then
            While oleAccReader.Read()

                realname = oleAccReader.GetString(0)
                course = oleAccReader.GetString(1)
                My.Settings.stuID = tuname.Text
                password = tpass.Text
                stumainframe.Show()
                Me.Hide()
            End While

        Else
            luname.ForeColor = Color.Gold
            lpass.ForeColor = Color.Gold
            terror.Text = "**Invalid Index or Password!**"
        End If

            oleAccReader.Close()
            con.Close()
    End Sub

    Sub leclogin()
        con = New SqlConnection(strAccConn)
        sql = "Select Subject, Lecturer_name, Course From lecturer Where Username = @n and PW  = @pw"
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("n", tuname.Text)
        oleAccCommand.Parameters.AddWithValue("pw", tpass.Text)
        con.Open()

        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()
                subject = oleAccReader.GetString(0)
                realname = oleAccReader.GetString(1)
                course = oleAccReader.GetString(2)
                My.Settings.uname = tuname.Text
                password = tpass.Text
                lecturemainframe.Show()
                Me.Hide()
            End While

        Else
            luname.ForeColor = Color.Gold
            lpass.ForeColor = Color.Gold
            terror.Text = "**Invalid Index or Password!**"
        End If

        oleAccReader.Close()
        con.Close()
    End Sub


    Sub adminlogin()
        If tpass.Text.Equals(My.Settings.adminpw) Then
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
        checkInternet()
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
