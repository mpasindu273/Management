imports System.Data.SqlClient

Public Class viewstuschedule
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection(strAccConn)

    Private Sub viewstuschedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If my.settings.course = "IT" Then
            sql = "SELECT Time, Monday, Tuesday, Wednesday, Thursday, Friday FROM IT_Time ORDER BY ID ASC"
        ElseIf my.settings.course = "English" Then
            sql = "SELECT Time, Monday, Tuesday, Wednesday, Thursday, Friday FROM ENG_Time ORDER BY ID ASC"
        End If

        con.Open()
        Dim sqlAccCommand As New SqlCommand(sql, con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sqlAccCommand)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class