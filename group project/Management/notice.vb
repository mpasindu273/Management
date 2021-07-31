Imports System.Data.SqlClient
Public Class notice

    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con, con1 As New SqlConnection(strAccConn)
    Dim sql, sql1 As String
    Dim msgCount, i, lecnum, adminnum As Integer
    Dim high, ahigh As Integer
    Dim dt As String
    Dim lectabhigh, admintabhigh As Integer


    Sub filllec()
        If my.settings.course = "IT" Then
            sql = "Select Message, Lecturer, Date_added, Time_added From notice where Course = 'IT' Order By ID Desc"
        ElseIf my.settings.course = "English" Then
            sql = "Select Message, Lecturer, Date_added, Time_added From notice where Course = 'English' Order By ID Desc"
        End If

        high = 25
        con = New SqlConnection(strAccConn)

        Dim oleAccCommand As New SqlCommand(sql, con)
        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()

                Dim tname = New TextBox()
                tname.Name = "tb" + lecnum.ToString
                tname.SetBounds(26, high, 318, 20)
                tname.ForeColor = Color.White
                tname.BackColor = Color.DarkGreen
                tname.Font = New Font("Microsoft Sans Serif", 13)
                tname.BorderStyle = BorderStyle.None
                tname.ReadOnly = True
                tname.Text = oleAccReader.GetString(1)

                Dim tdate = New TextBox()
                tdate.Name = "tb" + lecnum.ToString
                tdate.SetBounds(320, high, 304, 20)
                tdate.ForeColor = Color.White
                tdate.BackColor = Color.DarkGreen
                tdate.Font = New Font("Microsoft Sans Serif", 13)
                tdate.BorderStyle = BorderStyle.None
                tdate.ReadOnly = True
                If oleAccReader.GetString(2) <> dt Then
                    tdate.Text = "     " & oleAccReader.GetString(2)
                Else
                    tdate.Text = "     " & Today
                End If

                Dim ttime = New TextBox()
                ttime.Name = "tb" + lecnum.ToString
                ttime.SetBounds(619, high, 123, 20)
                ttime.ForeColor = Color.White
                ttime.BackColor = Color.DarkGreen
                ttime.Font = New Font("Microsoft Sans Serif", 13)
                ttime.BorderStyle = BorderStyle.None
                ttime.ReadOnly = True
                ttime.Text = "        " & oleAccReader.GetString(3)

                Dim rtb = New RichTextBox()
                rtb.Name = "rtb" + lecnum.ToString
                rtb.Padding = New Padding(5, 5, 5, 5)
                rtb.SetBounds(26, high, 716, 167)
                rtb.BackColor = Color.LightGreen
                rtb.Font = New Font("Arial", 15)
                rtb.BorderStyle = BorderStyle.None
                rtb.ReadOnly = True
                rtb.Text = vbCrLf & oleAccReader.GetString(0)

                lectab.Controls.Add(tname)
                lectab.Controls.Add(tdate)
                lectab.Controls.Add(ttime)
                lectab.Controls.Add(rtb)
                high += 190
                lecnum += 1

                lectabhigh = high + 25
                lectab.AutoScrollMinSize = New System.Drawing.Size(0, lectabhigh - 20)
            End While
        End If
        oleAccReader.Close()
        con.Close()
        high = 25
    End Sub

    Sub filladmin()
        high = 25
        con1 = New SqlConnection(strAccConn)
        sql1 = "Select Message, Date_added, Time_added From adminnotice Order By ID Desc"
        Dim oleAccCommand1 As New SqlCommand(sql1, con1)
        con1.Open()
        Dim oleAccReader1 As SqlDataReader = oleAccCommand1.ExecuteReader()
        If oleAccReader1.HasRows Then
            While oleAccReader1.Read()

                Dim tname = New TextBox()
                tname.Name = "tb" + adminnum.ToString
                tname.SetBounds(26, high, 318, 20)
                tname.ForeColor = Color.White
                tname.BackColor = Color.DarkGreen
                tname.Font = New Font("Microsoft Sans Serif", 13)
                tname.BorderStyle = BorderStyle.None
                tname.ReadOnly = True
                tname.Text = "Admin"

                Dim tdate = New TextBox()
                tdate.Name = "tb" + adminnum.ToString
                tdate.SetBounds(320, high, 304, 20)
                tdate.ForeColor = Color.White
                tdate.BackColor = Color.DarkGreen
                tdate.Font = New Font("Microsoft Sans Serif", 13)
                tdate.BorderStyle = BorderStyle.None
                tdate.ReadOnly = True
                If oleAccReader1.GetString(2) <> dt Then
                    tdate.Text = "     " & oleAccReader1.GetString(1)
                Else
                    tdate.Text = "     " & Today
                End If

                Dim ttime = New TextBox()
                ttime.Name = "tb" + adminnum.ToString
                ttime.SetBounds(619, high, 123, 20)
                ttime.ForeColor = Color.White
                ttime.BackColor = Color.DarkGreen
                ttime.Font = New Font("Microsoft Sans Serif", 13)
                ttime.BorderStyle = BorderStyle.None
                ttime.ReadOnly = True
                ttime.Text = "        " & oleAccReader1.GetString(2)

                Dim rtb = New RichTextBox()
                rtb.Name = "rtb" + adminnum.ToString
                rtb.Padding = New Padding(5, 5, 5, 5)
                rtb.SetBounds(26, high, 716, 167)
                rtb.BackColor = Color.LightGreen
                rtb.Font = New Font("Arial", 15)
                rtb.BorderStyle = BorderStyle.None
                rtb.ReadOnly = True
                rtb.Text = vbCrLf & oleAccReader1.GetString(0)

                admintab.Controls.Add(tname)
                admintab.Controls.Add(tdate)
                admintab.Controls.Add(ttime)
                admintab.Controls.Add(rtb)
                high += 190
                adminnum += 1

                admintabhigh = high + 25
            End While
        End If
        oleAccReader1.Close()
        con.Close()

        If admintabhigh > lectabhigh Then
            admintab.AutoScrollMinSize = New System.Drawing.Size(0, admintabhigh - 20)
        End If
    End Sub


    Private Sub notice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.account = "lecturer" Then
            TabControl1.TabPages.Remove(lectab)
            filladmin()
        ElseIf My.Settings.account = "student" Then
            filllec()
            filladmin()
        End If

    End Sub

    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        If My.Settings.account = "lecturer" Then
            lecturemainframe.Show()
        ElseIf My.Settings.account = "student" Then
            stumainframe.Show()
        End If

        Me.Close()
    End Sub

    Private Sub lectab_Click(sender As Object, e As EventArgs) Handles lectab.Click

    End Sub
End Class