imports System.Data.SqlClient

Public Class viewresults
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql As String
    Dim con As New SqlConnection(strAccConn)
    Dim lstSubs, lstMarks As New List(Of String)

    Sub loadLabels()
        con = New SqlConnection(strAccConn)
        sql = "select Subject_Long_name from Courses where Course_long_name = " + "'" + loginform.course + "'"
        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        con.Open()
        Dim oleAccReader As SqlDataReader = cmd.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                Try
                    lstSubs.Add(oleAccReader.GetString(0))
                Catch
                End Try
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub

    Sub loadMarks()
        Dim i As Integer
        con = New SqlConnection(strAccConn)
        sql = "select * from " + loginform.course.Replace(" ", "_") + "_Results where Stu_ID = '" + tindex.Text + "'"

        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        con.Open()
        Dim oleAccReader As SqlDataReader = cmd.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()
                For i = 2 To lstSubs.Count + 1
                    Try
                        lstMarks.Add(oleAccReader.GetString(i))
                    Catch
                        lstMarks.Add("N/A")
                    End Try
                Next
            End While
        End If
        oleAccReader.Close()
        con.Close()
    End Sub

    Sub draw()
        Dim high = 157
        For i = 0 To lstSubs.Count - 1
            Dim lbl = New Label()
            lbl.Name = "lbl" + ToString(i)
            lbl.Font = New Font("Arial", 16)
            lbl.ForeColor = Color.White
            lbl.Text = (i + 1).ToString + ". " + lstSubs(i)
            lbl.SetBounds(42, high, 400, 30)
            Me.Controls.Add(lbl)

            Dim lbl1 = New Label()
            lbl1.Name = "lbl" + ToString(i)
            lbl1.Font = New Font("Arial", 16)
            lbl1.ForeColor = Color.White
            lbl1.Text = lstMarks(i)
            lbl1.SetBounds(519, high, 86, 30)
            Me.Controls.Add(lbl1)

            high = high + 51
        Next
    End Sub

    Private Sub viewresults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        tindex.Text = My.Settings.stuID
        loadLabels()
        loadMarks()
        draw()
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