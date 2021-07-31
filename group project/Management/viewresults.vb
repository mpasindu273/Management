imports System.Data.SqlClient

Public Class viewresults
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql As String
    Dim con As New SqlConnection(strAccConn)


    Private Sub viewresults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If my.settings.course = "IT" Then
            Label1.Text = "Object Oriented Programming"
            Label2.Text = "System Analysis and Design"
            Label3.Text = "Statistics for IT"
            Label4.Text = "Data Structures and Algorithms"
            Label5.Text = "Data Communication Networks"
            sql = "SELECT OOP, SAD, STAT, DSA, DCN FROM ITresults WHERE Stu_ID = @id"

        ElseIf my.settings.course = "English" Then
            Label1.Text = "General English"
            Label2.Text = "Spoken English"
            Label3.Text = "English Grammer"
            Label4.Text = "Practice Sessions"
            Label5.Text = "English Literature"
            sql = "SELECT Gen_Eng, Spoken_Eng, Grammar, Practical, Literature FROM ENGresults WHERE Stu_ID = @id"
        End If

        tindex.Text = My.Settings.stuID
        Dim oleAccCommand As New SqlCommand(sql, con)
        oleAccCommand.Parameters.AddWithValue("id", My.Settings.stuID)

        con.Open()

        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()
                Try
                    l1.Text = oleAccReader.GetString(0)
                Catch
                    l1.Text = "---"
                End Try

                Try
                    l2.Text = oleAccReader.GetString(1)
                Catch
                    l2.Text = "---"
                End Try

                Try
                    l3.Text = oleAccReader.GetString(2)
                Catch
                    l3.Text = "---"
                End Try

                Try
                    l4.Text = oleAccReader.GetString(3)
                Catch
                    l4.Text = "---"
                End Try

                Try
                    l5.Text = oleAccReader.GetString(4)
                Catch
                    l5.Text = "---"
                End Try

            End While
        End If

        oleAccReader.Close()
        con.Close()
        con.Close()

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