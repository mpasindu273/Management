Imports System.Data.SqlClient
Public Class editlecturer

    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection
    Dim dbs As New BindingSource
    Dim addnewpressed As Integer
    Dim lecturername As String
    Dim oleAccCommand As New SqlCommand
    Dim oleAccReader As SqlDataReader
    Dim lstlongcourse As New List(Of String)
    Dim shortCourse As String
    Dim minnum As Integer = 0
    Dim maxnum As Integer = 100

    Sub getSubject()
        t2.Items.Clear()
        con = New SqlConnection(strAccConn)
        sql = "Select Subject_long_name From Courses where Course_long_name = '" + t8.Text + "'"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                t2.Items.Add(oleAccReader.GetString(0))
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub


    Sub getShortcourse()
        con = New SqlConnection(strAccConn)
        sql = "select Course_short_name from Courses where Course_long_name='" + t8.Text + "'"
        Dim oleAccCommand As New SqlCommand(sql, con)
        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read
                shortCourse = oleAccReader.GetString(0)
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub


    Sub generateIndex()
        getShortcourse()

        While (True)
            Dim randomNUM As Integer
            Dim randomID As String

            randomNUM = CInt(Math.Ceiling(Rnd() * maxnum) + minnum)
            randomID = shortCourse + "_" + randomNUM.ToString

            con = New SqlConnection(strAccConn)
            sql = "Select Username From lecturer where Username = '" + randomID + "'"
            Dim oleAccCommand As New SqlCommand(sql, con)
            con.Open()
            Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
            If oleAccReader.HasRows = False Then
                t6.Text = randomID
                Exit While
            End If
            oleAccReader.Close()
            con.Close()
        End While
    End Sub


    Sub generatePassword()
        Dim randomNUM As Integer

        randomNUM = CInt(Math.Ceiling(Rnd() * 5000) + 1000)
        t7.Text = randomNUM.ToString
    End Sub


    Sub setComboboxValues()
        con = New SqlConnection(strAccConn)
        sql = "Select Course_long_name, Course_short_name From Courses group by Course_long_name, Course_short_name"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                t8.Items.Add(oleAccReader.GetString(0))
                ComboBox1.Items.Add(oleAccReader.GetString(1) + " Lecturers")
                lstlongcourse.Add(oleAccReader.GetString(0))
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub


    Sub loaddata()
        If ComboBox1.Text = "All Lecturers" Then
            sql = "select * from lecturer"

        Else
            sql = "select * from lecturer where Course= '" + lstlongcourse(ComboBox1.SelectedIndex - 1) + "' order by Lec_ID asc"
        End If

        Dim con As SqlConnection = New SqlConnection(strAccConn)
        Dim cmd As SqlCommand = New SqlCommand(sql, con)

        con.Open()
        myDA = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(myDA)
        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        dbs.DataSource = myDataSet.Tables("MyTable").DefaultView
        DataGridView1.DataSource = dbs
        con.Close()

        tid.DataBindings.Clear()
        t1.DataBindings.Clear()
        t2.DataBindings.Clear()
        t3.DataBindings.Clear()
        t4.DataBindings.Clear()
        t5.DataBindings.Clear()
        t6.DataBindings.Clear()
        t7.DataBindings.Clear()
        t8.DataBindings.Clear()

        tid.DataBindings.Add("text", dbs, "Lec_ID")
        t1.DataBindings.Add("text", dbs, "Lecturer_name")
        t2.DataBindings.Add("text", dbs, "Subject")
        t3.DataBindings.Add("text", dbs, "City")
        t4.DataBindings.Add("text", dbs, "Email")
        t5.DataBindings.Add("text", dbs, "Phone_no")
        t6.DataBindings.Add("text", dbs, "Username")
        t7.DataBindings.Add("text", dbs, "PW")
        t8.DataBindings.Add("text", dbs, "Course")

        lecturername = t1.Text
    End Sub

    Sub addnewmode()
        t1.Select()
        bnew.Visible = False
        bdelete.Visible = False
        bupdate.Visible = False
        bcommit.Visible = True
        bcancel.Visible = True
        addnewpressed = 1
    End Sub

    Sub cancelmode()
        bnew.Visible = True
        bdelete.Visible = True
        bupdate.Visible = True
        bcommit.Visible = False
        bcancel.Visible = False
        addnewpressed = 0
    End Sub

    Sub addnew()
        sql = "Insert Into lecturer (Lecturer_name, Course, Subject, City, Email, Phone_no, Username, PW) Values (@lname, @course, @subject, @city, @e, @phn, @uname, @pw)"
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("lname", t1.Text)
        oleAccCommand.Parameters.AddWithValue("subject", t2.Text)
        oleAccCommand.Parameters.AddWithValue("city", t3.Text)
        oleAccCommand.Parameters.AddWithValue("e", t4.Text)
        oleAccCommand.Parameters.AddWithValue("phn", t5.Text)
        oleAccCommand.Parameters.AddWithValue("uname", t6.Text)
        oleAccCommand.Parameters.AddWithValue("pw", t7.Text)
        oleAccCommand.Parameters.AddWithValue("course", t8.Text)
        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()

        MsgBox("Record added")
        loaddata()
        dbs.MoveLast()
        cancelmode()
    End Sub

    Sub updat()
        loginform.checkInternet()
        sql = "update lecturer set Lecturer_name = @name, Course = @course, Subject = @subject, City = @city, Email = @e, Phone_no = @phn, Username = @uname, PW = @pw where Lec_ID = @lid"
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("name", t1.Text)
        oleAccCommand.Parameters.AddWithValue("subject", t2.Text)
        oleAccCommand.Parameters.AddWithValue("city", t3.Text)
        oleAccCommand.Parameters.AddWithValue("e", t4.Text)
        oleAccCommand.Parameters.AddWithValue("phn", t5.Text)
        oleAccCommand.Parameters.AddWithValue("uname", t6.Text)
        oleAccCommand.Parameters.AddWithValue("pw", t7.Text)
        oleAccCommand.Parameters.AddWithValue("lid", tid.Text)
        oleAccCommand.Parameters.AddWithValue("course", t8.Text)

        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()

        MsgBox("Record updated")
        loaddata()
        dbs.MoveLast()
        cancelmode()
    End Sub

    Sub addnew_or_update()
        If addnewpressed Then
            addnew()
            addnewpressed = 0
        ElseIf addnewpressed = 0 Then
            updat()
        End If
    End Sub

    Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
        addnewpressed = 0
        dbs.AddNew()
        addnewmode()
    End Sub

    Private Sub bcommit_Click(sender As Object, e As EventArgs) Handles bcommit.Click
        Try
            Integer.Parse(t5.Text)
        Catch
            MsgBox("Enter a valid phone number", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t5.Text = "" Or t6.Text = "" Or t7.Text = "" Then
            MsgBox("Fill all boxes with valid inputs!", MessageBoxIcon.Warning)

        ElseIf t5.TextLength < 10 Then
            MsgBox("Phone number must have 10 digits!", MessageBoxIcon.Warning)

        Else
            loginform.checkInternet()
            addnew_or_update()
        End If

    End Sub

    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click

        If t1.Text <> "" Then
            loginform.checkInternet()
            sql = "select * from lecturer where Lecturer_name like '%' + @id + '%'"
            Dim con As SqlConnection = New SqlConnection(strAccConn)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("id", t1.Text)
            con.Open()
            myDA = New SqlDataAdapter(cmd)
            Dim builder As SqlCommandBuilder = New SqlCommandBuilder(myDA)

            myDataSet = New DataSet()
            myDA.Fill(myDataSet, "MyTable")
            dbs.DataSource = myDataSet.Tables("MyTable").DefaultView
            DataGridView1.DataSource = dbs
            con.Close()

            tid.DataBindings.Clear()
            t1.DataBindings.Clear()
            t2.DataBindings.Clear()
            t3.DataBindings.Clear()
            t4.DataBindings.Clear()
            t5.DataBindings.Clear()
            t6.DataBindings.Clear()
            t7.DataBindings.Clear()
            t8.DataBindings.Clear()

            tid.DataBindings.Add("text", dbs, "Lec_ID")
            t1.DataBindings.Add("text", dbs, "Lecturer_name")
            t2.DataBindings.Add("text", dbs, "Subject")
            t3.DataBindings.Add("text", dbs, "City")
            t4.DataBindings.Add("text", dbs, "Email")
            t5.DataBindings.Add("text", dbs, "Phone_no")
            t6.DataBindings.Add("text", dbs, "Username")
            t7.DataBindings.Add("text", dbs, "PW")
            t8.DataBindings.Add("text", dbs, "Course")
        End If
    End Sub

    Private Sub bupdate_Click(sender As Object, e As EventArgs) Handles bupdate.Click
        If tid.Text = "" Then
            MsgBox("First choose a record to Update!", MessageBoxIcon.Warning)
        Else
            addnewmode()
        End If

    End Sub

    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click

        loginform.checkInternet()
        If tid.Text = "" Then
            MsgBox("First choose a record to delete!", MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If

            sql = "Delete From lecturer where Lec_ID = '" + tid.Text + "';"
            sql = sql + "Delete from notice where Lecturer = '" + t1.Text + "'"

            con = New SqlConnection(strAccConn)

            Dim oleAccCommand As New SqlCommand(sql, con)
            con.Open()
            oleAccCommand.ExecuteNonQuery()
            con.Close()

            MsgBox("Record removed!")
            loaddata()
            dbs.MoveLast()
        End If
    End Sub

    Private Sub bcancel_Click(sender As Object, e As EventArgs) Handles bcancel.Click
        loginform.checkInternet()
        loaddata()
        cancelmode()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dbs.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dbs.MoveNext()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dbs.MoveFirst()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        dbs.MoveLast()
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        loginform.checkInternet()
        loaddata()
    End Sub

    Private Sub editlecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        setComboboxValues()
        loaddata()
    End Sub

    Private Sub t8_click(sender As Object, e As EventArgs) Handles t8.Click
        t8.DroppedDown = True
    End Sub

    Private Sub t2_click(sender As Object, e As EventArgs) Handles t2.Click
        t2.DroppedDown = True
    End Sub

    Private Sub ComboBox1_click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.DroppedDown = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        loginform.checkInternet()
        loaddata()
    End Sub

    Private Sub t8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t8.SelectedIndexChanged
        If addnewpressed Then
            If t8.Text <> "" Then
                loginform.checkInternet()
                generateIndex()
                generatePassword()
                getSubject()
            End If
        End If
    End Sub
End Class
