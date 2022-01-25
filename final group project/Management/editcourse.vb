Imports System.Data.SqlClient

Public Class editcourse
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1, sql2, sql3 As String
    Dim con, con1 As New SqlConnection(strAccConn)
    Dim addnewpressed As Integer
    Dim lstLong, lstShort, lstsublong, lstsubshort, lstchecklong, lstcheckshort As New List(Of String)
    Dim courseShort As String


    Sub addnewmode()
        ptop.Visible = True
        bsub.Visible = True
        bdelete.Visible = False
        bcommit.Visible = True
        bcancel.Visible = True
        searchpanel.Visible = False
        llongname.Visible = False
        lshortname.Visible = False
        plong.Visible = False
        pshort.Visible = False
        tcourse.Clear()
        tcourseShort.Clear()
        tsub.Clear()
        plong.Controls.Clear()
        pshort.Controls.Clear()
        lstsublong.Clear()
        lstsubshort.Clear()
    End Sub

    Sub cancelmode()
        setcomboboxValue()
        plong.Controls.Clear()
        pshort.Controls.Clear()
        tcourse.Clear()
        tcourseShort.Clear()
        tsub.Clear()       

        llongname.Visible = False
        lshortname.Visible = False
        badd.Visible = True
        bdelete.Visible = True
        bcommit.Visible = False
        bcancel.Visible = False
        searchpanel.Visible = True
        plong.Visible = False
        pshort.Visible = False
        lsub.Visible = True
        tsub.Visible = True
        ptop.Visible = False    
    End Sub

    Sub checkSimilar(lst As List(Of String), txt As TextBox)
        For i = 0 To lst.Count - 1
            If txt.Text = lst(i) Then
                MsgBox("This course already exists. Pick different name", MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next
    End Sub

    Sub setcomboboxValue()
        loginform.checkInternet()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        con = New SqlConnection(strAccConn)
        sql = "Select Course_long_name, Course_short_name From Courses group by Course_long_name, Course_short_name"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                ComboBox1.Items.Add(oleAccReader.GetString(0))
                lstchecklong.Add(oleAccReader.GetString(0))
                lstcheckshort.Add(oleAccReader.GetString(1))
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub

    Sub getCourseDetails()
        loginform.checkInternet()
        lstsublong.Clear()
        lstsubshort.Clear()
        con = New SqlConnection(strAccConn)
        sql = "Select Course_short_name, Subject_long_name, Subject_short_name From Courses where Course_long_name = '" + ComboBox1.Text + "'"
        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("ln", ComboBox1.Text)
        con.Open()
        Dim oleAccReader As SqlDataReader = cmd.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                courseShort = oleAccReader.GetString(0)
                lstsublong.Add(oleAccReader.GetString(1))
                lstsubshort.Add(oleAccReader.GetString(2))
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub

    Sub generate_tb()
        plong.Controls.Clear()
        pshort.Controls.Clear()

        Dim i As Integer
        Dim high = 42

        If lstsublong.Count > 0 Then
            tcourse.Text = ComboBox1.Text
            tcourseShort.Text = courseShort
            tsub.Text = lstsublong.Count
        End If
        For i = 1 To Integer.Parse(tsub.Text)
            Dim lbl = New Label()
            lbl.Name = "lbl" + ToString(i)
            lbl.Font = New Font("Arial", 11)
            lbl.ForeColor = Color.Black
            lbl.Text = "Sub" & i
            lbl.SetBounds(12, high, 39, 13)
            plong.Controls.Add(lbl)

            Dim txtLong = New TextBox()
            txtLong.Name = "txtLong" + ToString(i)
            lbl.Font = New Font("Arial", 13)
            lbl.ForeColor = Color.Black
            txtLong.SetBounds(57, high, 243, 23)
            plong.Controls.Add(txtLong)

            Dim txtShort = New TextBox()
            txtShort.Name = "txtShort" + ToString(i)
            lbl.Font = New Font("Arial", 13)
            lbl.ForeColor = Color.White
            txtShort.SetBounds(14, high, 77, 23)
            pshort.Controls.Add(txtShort)

            high = high + 30

            If lstsublong.Count > 0 Then
                txtLong.Text = lstsublong(i - 1)
                txtShort.Text = lstsubshort(i - 1)
            End If
        Next i

        plong.Visible = True
        pshort.Visible = True
        ptop.Visible = True
        bsub.Visible = False
        llongname.Visible = True
        lshortname.Visible = True
    End Sub

    Function getInitials(txt As String)
        Dim Initials As String = ""
        Dim AllWords() As String = txt.Split(" "c)
        For Each Word As String In AllWords
            If Word.Length > 0 Then
                Initials = Initials & Word.Chars(0).ToString.ToUpper
            End If
        Next
        Return Initials
    End Function

    Sub fill_coursesTable()
        sql = ""
        For i = 0 To lstLong.Count - 1
            sql = sql + "insert into Courses (Course_long_name, Course_short_name, Subject_long_name, Subject_short_name) values ('" + tcourse.Text + "', '" + tcourseShort.Text + "', '" + lstLong(i) + "', '" + lstShort(i) + "');"
        Next

        con = New SqlConnection(strAccConn)
        Dim oleAccCommand As New SqlCommand(sql, con)
        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()
    End Sub


    Sub create_resultTable()
        sql = ""
        Dim tableName = tcourse.Text.Replace(" ", "_") + "_Results"
        sql = "create table " + tableName + "(ID int IDENTITY(1,1) PRIMARY KEY, Stu_ID varchar(50) not null, "

        For i = 0 To lstShort.Count - 1
            If i = lstLong.Count - 1 Then
                sql = sql + (lstShort(i).Replace(" ", "_") + " varchar(3)")
            Else
                sql = sql + (lstShort(i).Replace(" ", "_") + " varchar(3), ")
            End If
        Next
        sql = sql + ")"

        con = New SqlConnection(strAccConn)
        Dim oleAccCommand As New SqlCommand(sql, con)
        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()
    End Sub


    Sub create_scheduleTable()
        sql = ""
        Dim tableName = tcourse.Text.Replace(" ", "_") + "_Schedule"
        sql = "create table " + tableName + "(ID int IDENTITY(1,1) PRIMARY KEY, Time varchar(50), Monday varchar(20), Tuesday varchar(20), Wednesday varchar(20), Thursday varchar(20), Friday varchar(20), Saturday varchar(20), Sunday varchar(20))"
        con = New SqlConnection(strAccConn)
        Dim oleAccCommand As New SqlCommand(sql, con)
        con.Open()
        oleAccCommand.ExecuteNonQuery()
        con.Close()
    End Sub


    Sub collect_data()
        lstLong.Clear()
        lstShort.Clear()

        For Each item As Control In plong.Controls
            If TypeOf item Is TextBox Then
                Dim tb1 As TextBox = CType(item, TextBox)
                lstLong.Add(tb1.Text)
            End If
        Next

        For Each item As Control In pshort.Controls
            If TypeOf item Is TextBox Then
                Dim tb1 As TextBox = CType(item, TextBox)
                lstShort.Add(tb1.Text)
            End If
        Next
    End Sub


    Sub addnew()
        collect_data()
        fill_coursesTable()
        create_resultTable()
        create_scheduleTable()
        MsgBox("Course Added!")
    End Sub


    Sub delete()
        sql = ""
        If MessageBox.Show("Do you really want to remove this course? " + "All students, lecturers and results of this course will be deleted!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        Else
            sql = "Delete from Courses where Course_long_name = '" + ComboBox1.Text + "';"
            sql = sql + "Drop table " + tcourse.Text.Replace(" ", "_") + "_Schedule;"
            sql = sql + "Drop table " + tcourse.Text.Replace(" ", "_") + "_Results;"
            sql = sql + "Delete from student where Course = '" + ComboBox1.Text + "';"
            sql = sql + "Delete from lecturer where Course = '" + ComboBox1.Text + "';"

            con = New SqlConnection(strAccConn)
            Dim oleAccCommand As New SqlCommand(sql, con)
            con.Open()
            oleAccCommand.ExecuteNonQuery()
            con.Close()
            MsgBox("Course Removed!")
            cancelmode()
        End If
    End Sub


    Private Sub bsub_Click(sender As Object, e As EventArgs) Handles bsub.Click
        Try
            generate_tb()
        Catch ex As Exception
            MsgBox("Invalid Input!", MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        addnewmode()
    End Sub

    Private Sub bcommit_Click(sender As Object, e As EventArgs) Handles bcommit.Click

        If tcourse.Text = "" Or tcourseShort.Text = "" Then
            MsgBox("Fill all boxes!", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            loginform.checkInternet()
            addnew()
            cancelmode()
        Catch
            MsgBox("Fill all boxes!", MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub bcancel_Click(sender As Object, e As EventArgs) Handles bcancel.Click
        cancelmode()
    End Sub


    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        If tcourse.Text = "" Then
            MsgBox("Select a course to delete", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            loginform.checkInternet()
            delete()
        Catch
            MsgBox("Error! Operation canceled")
        End Try
    End Sub

    Private Sub tcourse_TextChanged(sender As Object, e As EventArgs) Handles tcourse.TextChanged
        tcourseShort.Text = getInitials(tcourse.Text)
    End Sub

    Private Sub tcourse_LostFocus(sender As Object, e As EventArgs) Handles tcourse.LostFocus
        checkSimilar(lstchecklong, tcourse)
    End Sub

    Private Sub tcourseShort_LostFocus(sender As Object, e As EventArgs) Handles tcourseShort.LostFocus
        checkSimilar(lstcheckshort, tcourseShort)
    End Sub

    Private Sub editcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setcomboboxValue()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged       
        getCourseDetails()
        generate_tb()
    End Sub

    Private Sub tsub_TextChanged(sender As Object, e As EventArgs) Handles tsub.TextChanged
        If tsub.Text = "" Then
            plong.Visible = False
            pshort.Visible = False
        End If

    End Sub

  
End Class