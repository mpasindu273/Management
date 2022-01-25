Imports System.Data.SqlClient
Public Class editschedule

    Dim myDA, myDA1 As SqlDataAdapter
    Dim myDataSet, myDataSet1 As DataSet
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con As New SqlConnection
    Dim sql, course As String

    Sub setComboboxValues()
        con = New SqlConnection(strAccConn)
        sql = "Select Course_long_name From Courses group by Course_long_name"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then

            While oleAccReader.Read()
                course = oleAccReader.GetString(0)
                ComboBox1.Items.Add(course)

            End While
        End If
        ComboBox1.Text = course
    End Sub

    Sub strt()
        con = New SqlConnection(strAccConn)
        sql = "select * from " + ComboBox1.Text.Replace(" ", "_") + "_Schedule" + " order by ID asc"
        con = New SqlConnection(strAccConn)
        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        con.Open()
        myDA = New SqlDataAdapter(cmd)

        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(myDA)
        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
        con.Close()
    End Sub

    Private Sub editschedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        setComboboxValues()
        strt()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            loginform.checkInternet()
            Me.Validate()
            Me.myDA.Update(Me.myDataSet.Tables("MyTable"))
            Me.myDataSet.AcceptChanges()
            Me.myDA1.Update(Me.myDataSet1.Tables("MyTable1"))
            Me.myDataSet1.AcceptChanges()
            MsgBox("Changes saved!")
        Catch
            MsgBox("Done!")
        End Try

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginform.checkInternet()
        strt()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        strt()    
    End Sub
End Class