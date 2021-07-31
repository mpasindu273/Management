Imports System.Data.SqlClient
Public Class editschedule

    Dim myDA, myDA1 As SqlDataAdapter
    Dim myDataSet, myDataSet1 As DataSet
    Dim sql As String


    Sub strt()
        If ComboBox1.Text = "IT Time Table" Then
            sql = "select ID, Time, Monday, Tuesday, Wednesday, Thursday, Friday from IT_Time order by ID asc"
        ElseIf ComboBox1.Text = "English Time Table" Then
            sql = "select ID, Time, Monday, Tuesday, Wednesday, Thursday, Friday from ENG_Time order by ID asc"
        End If

        Dim con As SqlConnection = New SqlConnection("Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu")
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
        strt()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
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
        strt()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        strt()
    End Sub
End Class