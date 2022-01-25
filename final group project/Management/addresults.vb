imports System.Data.SqlClient

Public Class addresults

    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim sql, sql2 As String
    Dim subject As String
    Dim strAccConn As String = "Server=sql.bsite.net\MSSQL2016;Database=pasindu_institute;Uid=pasindu_institute;Pwd=m3A1i32pgu"
    Dim con As SqlConnection = New SqlConnection(strAccConn)

    Sub getSubject()
        con = New SqlConnection(strAccConn)
        sql = "Select Subject_short_name From Courses Where Subject_long_name = '" + loginform.subject + "'"
        Dim oleAccCommand As New SqlCommand(sql, con)

        con.Open()
        Dim oleAccReader As SqlDataReader = oleAccCommand.ExecuteReader()
        If oleAccReader.HasRows Then
            While oleAccReader.Read()
                subject = oleAccReader.GetValue(0)             
            End While
        End If

        oleAccReader.Close()
        con.Close()
    End Sub


    Sub strt()
        getSubject()

        sql = "select ID, Stu_ID, " + subject.Replace(" ", "_") + " from " + loginform.course.Replace(" ", "_") + "_Results"

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
        loginform.checkInternet()
        strt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            loginform.checkInternet()
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

End Class

