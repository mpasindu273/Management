Imports System.Data.SqlClient

Public Class editstudent
    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection
    Dim dbs As New BindingSource
    Dim addnewpressed, updatepressed As Integer
    Dim stuid, course, shortCourse, stuIndex As String
    Dim lstlongcourse As New List(Of String)
    Dim minnum As Integer = 0
    Dim maxnum As Integer = 100

    Sub addnewmode()
        bnew.Visible = False
        bdelete.Visible = False
        bupdate.Visible = False
        bcommit.Visible = True
        bcancel.Visible = True
        addnewpressed = 1
    End Sub

    Sub updatemode()
        bnew.Visible = False
        bdelete.Visible = False
        bupdate.Visible = False
        bcommit.Visible = True
        bcancel.Visible = True
        updatepressed = 1
    End Sub

    Sub cancelmode()
        bnew.Visible = True
        bdelete.Visible = True
        bupdate.Visible = True
        bcommit.Visible = False
        bcancel.Visible = False
        tsearch.Clear()
        t9.Enabled = True
        addnewpressed = 0
        updatepressed = 0
    End Sub

    Sub getShortcourse()
        con = New SqlConnection(strAccConn)
        sql = "select Course_short_name from Courses where Course_long_name='" + t9.Text + "'"
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
            sql = "Select Student_ID From student where Student_ID = '" + randomID + "'"
            Dim oleAccCommand As New SqlCommand(sql, con)
            con.Open()
            Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
            If oleAccReader.HasRows = False Then
                t1.Text = randomID
                Exit While
            End If
            oleAccReader.Close()
            con.Close()
        End While
    End Sub


    Sub generatePassword()
        Dim randomNUM As Integer

        randomNUM = CInt(Math.Ceiling(Rnd() * 5000) + 1000)
        t8.Text = randomNUM.ToString
    End Sub


    Sub setComboboxValues()
        con = New SqlConnection(strAccConn)
        sql = "Select Course_long_name, Course_short_name From Courses group by Course_long_name, Course_short_name"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                shortCourse = oleAccReader.GetString(1)
                combo1.Items.Add(oleAccReader.GetString(1) + " Students")
                t9.Items.Add(oleAccReader.GetString(0))
                lstlongcourse.Add(oleAccReader.GetString(0))
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub


    Sub loaddata()
        If combo1.Text = "All students" Then
            sql = "select * from student order by Student_ID asc"
        Else
            sql = "select * from student where Course = " + "'" + lstlongcourse(combo1.SelectedIndex - 1) + "' order by Student_ID asc"
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

        t1.DataBindings.Clear()
        t2.DataBindings.Clear()
        t3.DataBindings.Clear()
        t4.DataBindings.Clear()
        t6.DataBindings.Clear()
        t7.DataBindings.Clear()
        t8.DataBindings.Clear()
        t9.DataBindings.Clear()

        t1.DataBindings.Add("text", dbs, "Student_ID")
        t2.DataBindings.Add("text", dbs, "First_name")
        t3.DataBindings.Add("text", dbs, "Last_name")
        t4.DataBindings.Add("text", dbs, "Date_enrolled")
        t6.DataBindings.Add("text", dbs, "Email")
        t7.DataBindings.Add("text", dbs, "Phone_no")
        t8.DataBindings.Add("text", dbs, "PW")
        t9.DataBindings.Add("text", dbs, "Course")
    End Sub


    Sub addnew()
        sql = "Insert Into student (Student_ID, First_name, Last_name, Course, Date_enrolled, Email, Phone_no, PW) Values (@id, @fn, @ln, @c, @d, @e, @phn, @pw)"
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("id", t1.Text)
        oleAccCommand.Parameters.AddWithValue("fn", t2.Text)
        oleAccCommand.Parameters.AddWithValue("ln", t3.Text)
        oleAccCommand.Parameters.AddWithValue("d", t4.Text)
        oleAccCommand.Parameters.AddWithValue("e", t6.Text)
        oleAccCommand.Parameters.AddWithValue("phn", t7.Text)
        oleAccCommand.Parameters.AddWithValue("pw", t8.Text)
        oleAccCommand.Parameters.AddWithValue("c", t9.Text)
        con.Open()
        oleAccCommand.ExecuteNonQuery()

        oleAccCommand.CommandText = "Insert Into " + t9.Text.Replace(" ", "_") + "_Results" + " (Stu_ID) Values (@stuid)"
        oleAccCommand.Parameters.AddWithValue("stuid", t1.Text)
        oleAccCommand.ExecuteNonQuery()
        con.Close()

        MsgBox("Record added")
        loaddata()
        dbs.MoveLast()
        addnewpressed = 0
    End Sub

    Sub updat()
        sql = "update student set Student_ID= @stuid, First_name = @fname, Last_name = @lname, Course = @course, Date_enrolled = @dt, Email = @e, Phone_no = @phn, PW = @pw where Student_ID= @id"
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("stuid", t1.Text)
        oleAccCommand.Parameters.AddWithValue("fname", t2.Text)
        oleAccCommand.Parameters.AddWithValue("lname", t3.Text)
        oleAccCommand.Parameters.AddWithValue("dt", t4.Text)
        oleAccCommand.Parameters.AddWithValue("e", t6.Text)
        oleAccCommand.Parameters.AddWithValue("phn", t7.Text)
        oleAccCommand.Parameters.AddWithValue("pw", t8.Text)
        oleAccCommand.Parameters.AddWithValue("course", t9.Text)
        oleAccCommand.Parameters.AddWithValue("id", stuid)
        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()

        MsgBox("Record updated")
        loaddata()
        dbs.MoveLast()
        cancelmode()
    End Sub

    Sub addnew_or_update()
        If addnewpressed = 1 Then        
                addnew()
        ElseIf addnewpressed = 0 Then
            updat()
        End If

        cancelmode()
    End Sub

    Private Sub editstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        DataGridView1.ReadOnly = True
        loaddata()
        setComboboxValues()
    End Sub

    Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
        loginform.checkInternet()
        addnewmode()
        loaddata()
        dbs.AddNew()
        t1.Select()
    End Sub

    Private Sub bcommit_Click(sender As Object, e As EventArgs) Handles bcommit.Click
        Try
            Integer.Parse(t7.Text)
        Catch
            MsgBox("Fill all boxes with valid inputs!", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        If t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t6.Text = "" Or t7.Text = "" Or t8.Text = "" Then
            MsgBox("Fill all boxes with valid inputs!", MessageBoxIcon.Warning)
        ElseIf t7.TextLength < 10 Then
            MsgBox("Phone number must have 10 digits!", MessageBoxIcon.Warning)
        Else
            loginform.checkInternet()
            addnew_or_update()
        End If
    End Sub

    Private Sub bupdate_Click(sender As Object, e As EventArgs) Handles bupdate.Click
        If t1.Text = "" Then
            MsgBox("First choose a record to Update!", MessageBoxIcon.Warning)
        Else
            loginform.checkInternet()
            stuid = t1.Text
            updatemode()
            loaddata()
        End If
    End Sub

    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click
        If tsearch.Text <> "" Then
            sql = "select * from student where Student_ID like '%' + @id + '%'"
            Dim con As SqlConnection = New SqlConnection(strAccConn)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("id", tsearch.Text)
            con.Open()
            myDA = New SqlDataAdapter(cmd)

            Dim builder As SqlCommandBuilder = New SqlCommandBuilder(myDA)

            myDataSet = New DataSet()
            myDA.Fill(myDataSet, "MyTable")
            dbs.DataSource = myDataSet.Tables("MyTable").DefaultView
            DataGridView1.DataSource = dbs
            con.Close()
            con = Nothing

            t1.DataBindings.Clear()
            t2.DataBindings.Clear()
            t3.DataBindings.Clear()
            t4.DataBindings.Clear()
            t6.DataBindings.Clear()
            t7.DataBindings.Clear()
            t8.DataBindings.Clear()
            t9.DataBindings.Clear()

            t1.DataBindings.Add("text", dbs, "Student_ID")
            t2.DataBindings.Add("text", dbs, "First_name")
            t3.DataBindings.Add("text", dbs, "Last_name")
            t4.DataBindings.Add("text", dbs, "Date_enrolled")
            t6.DataBindings.Add("text", dbs, "Email")
            t7.DataBindings.Add("text", dbs, "Phone_no")
            t8.DataBindings.Add("text", dbs, "PW")
            t9.DataBindings.Add("text", dbs, "Course")
        End If

    End Sub

    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        If t1.Text = "" Then
            MsgBox("First choose a record to delete!", MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If

            loginform.checkInternet()
            sql1 = "Delete From " + t9.Text.Replace(" ", "_") + "_Results " + "where Stu_ID = @stuid"
            con1 = New SqlConnection(strAccConn)
            Dim oleAccCommand1 As New SqlCommand(sql1, con1)
            oleAccCommand1.Parameters.AddWithValue("stuid", t1.Text)
            con1.Open()
            oleAccCommand1.ExecuteNonQuery()

            sql = "Delete From student where Student_ID = @stuid"
            con = New SqlConnection(strAccConn)

            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("stuid", t1.Text)
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
        addnewpressed = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dbs.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        dbs.MoveNext()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        dbs.MoveFirst()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dbs.MoveLast()
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        loginform.checkInternet()
        combo1.Text = "All students"
        cancelmode()
        loaddata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        t4.Text = DateTimePicker1.Text
    End Sub

    Private Sub combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo1.SelectedIndexChanged
        loginform.checkInternet()
        loaddata()
    End Sub

    Private Sub t9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t9.SelectedIndexChanged
        If addnewpressed Or updatepressed Then
            loginform.checkInternet()
            generateIndex()
            generatePassword()
        End If
    End Sub

    Private Sub t9_click(sender As Object, e As EventArgs) Handles t9.Click
        t9.DroppedDown = True
    End Sub

    Private Sub combo1_click(sender As Object, e As EventArgs) Handles combo1.Click
        combo1.DroppedDown = True
    End Sub
End Class
