Imports System.Data.SqlClient

Public Class editstudent
    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection
    Dim dbs As New BindingSource
    Dim addnewpressed As Integer
    Dim stuid As String

    Sub readon()
        t1.ReadOnly = True
        t2.ReadOnly = True
        t3.ReadOnly = True
        t6.ReadOnly = True
        t7.ReadOnly = True
        t8.ReadOnly = True
        t9.BackColor = SystemColors.Control
    End Sub

    Sub notreadon()
        t1.ReadOnly = False
        t2.ReadOnly = False
        t3.ReadOnly = False
        t6.ReadOnly = False
        t7.ReadOnly = False
        t8.ReadOnly = False
        t9.BackColor = SystemColors.Window
    End Sub

    Sub loaddata()
        If combo1.Text = "All students" Then
            sql = "select * from student order by Student_ID asc"
        ElseIf combo1.Text = "IT students" Then
            sql = "select * from student where Course ='IT' order by Student_ID asc"
        ElseIf combo1.Text = "English students" Then
            sql = "select * from student where Course ='English' order by Student_ID asc"
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
        t1.ReadOnly = True
        t9.Enabled = False
        addnewpressed = 0

    End Sub

    Sub cancelmode()
        bnew.Visible = True
        bdelete.Visible = True
        bupdate.Visible = True
        bcommit.Visible = False
        bcancel.Visible = False
        t9.Enabled = True
        addnewpressed = 0
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
        con.Close()

        If t9.Text = "IT" Then
            sql1 = "Insert Into ITresults (Stu_ID) Values (@stuid)"
        ElseIf t9.Text = "English" Then
            sql1 = "Insert Into ENGresults (Stu_ID) Values (@stuid)"
        End If

        con1 = New SqlConnection(strAccConn)
        Dim oleAccCommand1 As New SqlCommand(sql1, con1)
        oleAccCommand1.Parameters.AddWithValue("stuid", t1.Text)
        con1.Open()
        oleAccCommand1.ExecuteNonQuery()
        con1.Close()

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
            con = New SqlConnection(strAccConn)
            sql = "Select Student_ID from student Where Student_ID = @id"
            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("id", t1.Text)

            con.Open()
            Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
            If oleAccReader.HasRows Then
                MsgBox("This Student ID already exists!", MessageBoxIcon.Warning)
                Exit Sub
            Else
                addnew()
            End If
            oleAccReader.Close()
            con.Close()

        ElseIf addnewpressed = 0 Then
            updat()
        End If

        cancelmode()
        readon()
    End Sub

    Private Sub editstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ReadOnly = True
        readon()
        loaddata()
    End Sub

    Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
        notreadon()
        addnewmode()
        loaddata()
        dbs.AddNew()
        t1.Select()
    End Sub

    Private Sub bcommit_Click(sender As Object, e As EventArgs) Handles bcommit.Click
        If t1.TextLength < 5 Then
            MsgBox("Invalid Student ID! Fill as the example", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Integer.Parse(t1.Text.Substring(2, 3))
        Catch
            MsgBox("Invalid Student ID! Fill as the example", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        Try
            Integer.Parse(t7.Text)
        Catch
            MsgBox("Fill all boxes with valid inputs!", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t6.Text = "" Or t7.Text = "" Or t8.Text = "" Then
            MsgBox("Fill all boxes with valid inputs!", MessageBoxIcon.Warning)
        ElseIf t7.TextLength < 10 Then
            MsgBox("Phone number must have 10 digits!", MessageBoxIcon.Warning)
        Else

            addnew_or_update()
        End If
    End Sub

    Private Sub bupdate_Click(sender As Object, e As EventArgs) Handles bupdate.Click
        If t1.Text = "" Then
            MsgBox("First choose a record to Update!", MessageBoxIcon.Warning)
        Else
            stuid = t1.Text
            updatemode()
            loaddata()
            notreadon()
            t1.ReadOnly = True
        End If
    End Sub

    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click
        readon()
        cancelmode()

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
    End Sub

    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        If t1.Text = "" Then
            MsgBox("First choose a record to delete!", MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MessageBox.Show("Operation Cancelled")
                Exit Sub
            End If

            If t9.Text = "IT" Then
                sql1 = "Delete From ITresults where Stu_ID = @stuid"
            ElseIf t9.Text = "English" Then
                sql1 = "Delete From ENGresults where Stu_ID = @stuid"
            End If

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
        loaddata()
        cancelmode()
        addnewpressed = 0
        readon()
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
        combo1.Text = "All students"
        cancelmode()
        loaddata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        t4.Text = DateTimePicker1.Text
    End Sub

    Private Sub combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo1.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub t9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t9.SelectedIndexChanged
        If addnewpressed Then
            If t9.Text = "IT" Then
                t1.Text = "IT"
            ElseIf t9.Text = "English" Then
                t1.Text = "EN"
            End If
        End If
    End Sub
End Class
