Imports System.Data.SqlClient

Public Class editnotice

    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con As New SqlConnection(strAccConn)
    Dim sql As String
    Dim i, lnum, rows As Integer
    Dim listnav As New List(Of String)
    Dim listdt As New List(Of String)
    Dim listtime As New List(Of String)
    Dim count As Integer = 0
    Dim time, dt, showdate As String

    Private Function checkToday() As String
        If listdt(count) = dt Then
            showdate = "Today"
        Else
            showdate = listdt(count)
        End If
        Return showdate
    End Function

    Private Sub minimize()

        tnote.ReadOnly = True
        bcommit.Visible = False
        badd.Visible = True
        bdelete.Visible = True
        bback.Visible = False

        ldate.Visible = True
        ltime.Visible = True
        tdate.Visible = True
        ttime.Visible = True
        bnxt.Visible = True
        bprev.Visible = True
        tnote.SetBounds(25, 114, 533, 306)
    End Sub

    Private Sub maximize()
        tnote.ReadOnly = False
        bcommit.Visible = True
        badd.Visible = False
        bdelete.Visible = False
        bback.Visible = True

        ldate.Visible = False
        ltime.Visible = False
        tdate.Visible = False
        ttime.Visible = False
        bnxt.Visible = False
        bprev.Visible = False

        tnote.SetBounds(-2, -2, 586, 504)
    End Sub

    Sub getNotes()
        If My.Settings.account = "lecturer" Then
            getLecNotes()
        ElseIf My.Settings.account = "admin" Then
            getAdminNotes()
        End If
    End Sub

    Private Sub getLecNotes()
        bnxt.Visible = False

        con = New SqlConnection(strAccConn)
        sql = "Select Message, Date_added, Time_added From notice where Lecturer = @nm and Lec_ID = @id"
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("id", My.Settings.uname)
        oleAccCommand.Parameters.AddWithValue("nm", loginform.realname)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                listnav.Add(oleAccReader.GetString(0))
                listdt.Add(oleAccReader.GetString(1))
                listtime.Add(oleAccReader.GetString(2))
                count += 1
                rows += 1
            End While

            count = listnav.Count - 1

            tnote.Text = listnav(count)
            tdate.Text = checkToday()
            ttime.Text = listtime(count)
        End If


        If rows > 1 Then
            bprev.Visible = True
        Else
            bprev.Visible = False
        End If

        rows = 0

        oleAccReader.Close()
        con.Close()
    End Sub


    Sub lecCommit()
        If tnote.Text <> "" Then
            sql = "Insert Into notice (Lec_ID, Message, Lecturer, Course, Date_added, Time_added) Values (@id, @mess, @lec, @c, @dt, @time)"
            con = New SqlConnection(strAccConn)

            Using con
                Dim oleAccCommand As New SqlCommand(sql, con)
                oleAccCommand.Parameters.AddWithValue("id", My.Settings.uname)
                oleAccCommand.Parameters.AddWithValue("mess", tnote.Text)
                oleAccCommand.Parameters.AddWithValue("lec", loginform.realname)
                oleAccCommand.Parameters.AddWithValue("c", loginform.course)
                oleAccCommand.Parameters.AddWithValue("dt", dt)
                oleAccCommand.Parameters.AddWithValue("time", time)

                con.Open()
                oleAccCommand.ExecuteNonQuery()

                minimize()

                listnav.Clear()
                listdt.Clear()
                listtime.Clear()

                getNotes()
                tnote.Text = listnav(count)
                tdate.Text = checkToday()
                ttime.Text = listtime(count)
                MsgBox("Added!")
            End Using
        Else
            MsgBox("Type the notice before submitting")
        End If
    End Sub


    Sub lecDelete()
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        sql = "Delete From notice where Message = @note and Lec_ID = @id"
        con = New SqlConnection(strAccConn)
        Using con
            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("id", My.Settings.uname)
            oleAccCommand.Parameters.AddWithValue("note", tnote.Text)
            con.Open()
            oleAccCommand.ExecuteNonQuery()

            listnav.Clear()
            listdt.Clear()
            listtime.Clear()
            tnote.Clear()
            getNotes()
            MsgBox("Deleted!")
        End Using
    End Sub

    Private Sub getAdminNotes()
        bnxt.Visible = False

        con = New SqlConnection(strAccConn)
        sql = "Select Message, Date_added, Time_added From adminnotice"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                listnav.Add(oleAccReader.GetString(0))
                listdt.Add(oleAccReader.GetString(1))
                listtime.Add(oleAccReader.GetString(2))
                count += 1
                rows += 1
            End While

            count = listnav.Count - 1

            tnote.Text = listnav(count)
            tdate.Text = checkToday()
            ttime.Text = listtime(count)
        End If


        If rows > 1 Then
            bprev.Visible = True
        Else
            bprev.Visible = False
        End If

        rows = 0

        oleAccReader.Close()
        con.Close()
    End Sub


    Sub adminCommit()
        If tnote.Text <> "" Then
            sql = "Insert Into adminnotice (Message, Date_added, Time_added) Values (@1, @dt, @time)"
            con = New SqlConnection(strAccConn)

            Using con
                Dim oleAccCommand As New SqlCommand(sql, con)
                oleAccCommand.Parameters.AddWithValue("1", tnote.Text)
                oleAccCommand.Parameters.AddWithValue("dt", dt)
                oleAccCommand.Parameters.AddWithValue("time", time)

                con.Open()
                oleAccCommand.ExecuteNonQuery()

                minimize()

                listnav.Clear()
                listdt.Clear()
                listtime.Clear()

                getNotes()
                tnote.Text = listnav(count)
                tdate.Text = checkToday()
                ttime.Text = listtime(count)
                MsgBox("Added!")
            End Using
        Else
            MsgBox("Type the notice before submitting")
        End If
    End Sub


    Sub adminDelete()
        If MessageBox.Show("Do you really want to Delete this Notice?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        sql = "Delete From adminnotice where Message = @note"
        con = New SqlConnection(strAccConn)
        Using con
            Dim oleAccCommand As New SqlCommand(sql, con)
            oleAccCommand.Parameters.AddWithValue("note", tnote.Text)
            con.Open()
            oleAccCommand.ExecuteNonQuery()

            listnav.Clear()
            listdt.Clear()
            listtime.Clear()
            tnote.Clear()
            getNotes()
            MsgBox("Deleted!")
        End Using
    End Sub


    Private Sub editnotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        dt = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        time = Format(Now, "hh:mm tt")
        getNotes()
    End Sub

    Private Sub bnxt_Click(sender As Object, e As EventArgs) Handles bnxt.Click
        If count < listnav.Count - 1 Then
            bprev.Visible = True
            count += 1
            tnote.Text = listnav(count)
            tdate.Text = checkToday()
            ttime.Text = listtime(count)
        End If

        If count = listnav.Count - 1 Then
            bnxt.Visible = False
        End If
    End Sub


    Private Sub bprev_Click(sender As Object, e As EventArgs) Handles bprev.Click
        If count >= 1 Then
            bnxt.Visible = True
            count -= 1
            tnote.Text = listnav(count)
            tdate.Text = checkToday()
            ttime.Text = listtime(count)
        End If

        If count = 0 Then
            bprev.Visible = False
        End If
    End Sub


    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        tnote.Clear()
        tdate.Clear()
        ttime.Clear()
        tnote.Focus()
        maximize()
    End Sub


    Private Sub bcommit_Click(sender As Object, e As EventArgs) Handles bcommit.Click
        loginform.checkInternet()
        If My.Settings.account = "lecturer" Then
            lecCommit()
        ElseIf My.Settings.account = "admin" Then
            adminCommit()
        End If
    End Sub


    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        loginform.checkInternet()
        If My.Settings.account = "lecturer" Then
            lecDelete()
        ElseIf My.Settings.account = "admin" Then
            adminDelete()
        End If
    End Sub


    Private Sub bback_Click(sender As Object, e As EventArgs) Handles bback.Click
        minimize()
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