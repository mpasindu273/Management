imports System.Data.SqlClient

Public Class addresults

    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim sql, sql2 As String
    Dim subject As String
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"

    Sub strt()
        If My.Settings.course = "IT" Then

            If My.Settings.field = "OOP" Then
                sql = "select ID, Stu_ID, OOP from ITresults"
                sql2 = "Update ITresults Set OOP = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "SAD" Then
                sql = "select ID, Stu_ID, SAD from ITresults"
                sql2 = "Update ITresults Set SAD = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "STAT" Then
                sql = "select ID, Stu_ID, STAT from ITresults"
                sql2 = "Update ITresults Set STAT = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "DSA" Then
                sql = "select ID, Stu_ID, DSA from ITresults"
                sql2 = "Update ITresults Set DSA = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "DCN" Then
                sql = "select ID, Stu_ID, DCN from ITresults"
                sql2 = "Update ITresults Set DCN = '---' Where Stu_ID = @id"

            End If

        ElseIf My.Settings.course = "English" Then

            If My.Settings.field = "Gen_Eng" Then
                sql = "select ID, Stu_ID, Gen_Eng from ENGresults"
                sql2 = "Update ENGresults Set Gen_Eng = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "Spoken_Eng" Then
                sql = "select ID, Stu_ID, Spoken_Eng from ENGresults"
                sql2 = "Update ENGresults Set Spoken_Eng = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "Grammar" Then
                sql = "select ID, Stu_ID, Grammar from ENGresults"
                sql2 = "Update ENGresults Set Grammar = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "Practical" Then
                sql = "select ID, Stu_ID, Practical from ENGresults"
                sql2 = "Update ENGresults Set Practical = '---' Where Stu_ID = @id"

            ElseIf My.Settings.field = "Literature" Then
                sql = "select ID, Stu_ID, Literature from ENGresults"
                sql2 = "Update ENGresults Set Literature = '---' Where Stu_ID = @id"
            End If
        End If

        Dim con As SqlConnection = New SqlConnection(strAccConn)
        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        con.Open()
        myDA = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(myDA)
        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        con.Close()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.myDA.Update(Me.myDataSet.Tables("MyTable"))
            Me.myDataSet.AcceptChanges()
            MsgBox("changes saved!")
            lecturemainframe.Show()
            Me.Close()
        Catch
            MsgBox("Please fill all slots with valid details ", MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        lecturemainframe.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

