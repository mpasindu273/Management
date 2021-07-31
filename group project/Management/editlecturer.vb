Imports System.Data.SqlClient
Public Class editlecturer

    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection
    Dim dbs As New BindingSource
    Dim updatepressed As Integer
    Dim lecturername As String

    Sub readon()
        t1.ReadOnly = True
        t3.ReadOnly = True
        t4.ReadOnly = True
        t5.ReadOnly = True
        t6.ReadOnly = True
        t7.ReadOnly = True
        t8.BackColor = SystemColors.Control
        t2.BackColor = SystemColors.Control
    End Sub

    Sub notreadon()
        t1.ReadOnly = False
        t3.ReadOnly = False
        t4.ReadOnly = False
        t5.ReadOnly = False
        t6.ReadOnly = False
        t7.ReadOnly = False
        t8.BackColor = SystemColors.Window
        t2.BackColor = SystemColors.Window
    End Sub

    Sub loaddata()
        readon()
        If ComboBox1.Text = "All Lecturers" Then
            sql = "select * from lecturer"

        ElseIf ComboBox1.Text = "IT Lecturers" Then
            sql = "select * from lecturer where Course= 'IT'"

        ElseIf ComboBox1.Text = "English Lecturers" Then
            sql = "select * from lecturer where Course= 'English'"
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
        bnew.Visible = False
        bdelete.Visible = False
        bupdate.visible = False
        bcommit.Visible = True
        bcancel.Visible = True
    End Sub

    Sub cancelmode()
        bnew.Visible = True
        bdelete.Visible = True
        bupdate.Visible = True
        bcommit.Visible = False
        bcancel.Visible = False
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
        If updatepressed Then
            updat()
            updatepressed = 0
        ElseIf updatepressed = 0 Then
            addnew()
        End If
    End Sub

    Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
        notreadon()
        updatepressed = 0
        dbs.AddNew()
        addnewmode()
        t6.Select()
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
            addnew_or_update()
            readon()
        End If

    End Sub

    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click
        readon()
        If t1.Text <> "" Then
            sql = "select * from lecturer where Username like '%' + @id + '%'"
            Dim con As SqlConnection = New SqlConnection(strAccConn)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("id", t6.Text)
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
            updatepressed = 1
            notreadon()
        End If

    End Sub

    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        If tid.Text = "" Then
            MsgBox("First choose a record to delete!", MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MessageBox.Show("Operation Cancelled")
                Exit Sub
            End If

            sql = "Delete From lecturer where Lec_ID = @id"
            con = New SqlConnection(strAccConn)

            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("id", tid.Text)
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
        readon()
        updatepressed = 0
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
        loaddata()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub editlecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub t8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t8.SelectedIndexChanged
        If t8.Text = "IT" Then
            t2.Items.Clear()
            t2.Text = "DCN"
            t2.Items.Add("DCN")
            t2.Items.Add("OOP")
            t2.Items.Add("STAT")
            t2.Items.Add("DSA")
            t2.Items.Add("SAD")

        ElseIf t8.Text = "English" Then
            t2.Items.Clear()
            t2.Text = "Gen_Eng"
            t2.Items.Add("Gen_Eng")
            t2.Items.Add("Spoken_Eng")
            t2.Items.Add("Grammar")
            t2.Items.Add("Practical")
            t2.Items.Add("Literature")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        loaddata()
    End Sub
End Class
