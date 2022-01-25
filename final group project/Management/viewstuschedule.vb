imports System.Data.SqlClient

Public Class viewstuschedule
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim sql, sql1 As String
    Dim con, con1 As New SqlConnection(strAccConn)

    Private Sub viewstuschedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.checkInternet()
        sql = "SELECT Time, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM " + loginform.course.Replace(" ", "_") + "_Schedule ORDER BY ID ASC"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class