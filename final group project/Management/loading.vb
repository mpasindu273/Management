Public Class loading

    Private Sub t1_Tick(sender As Object, e As EventArgs) Handles t1.Tick
        pb1.Increment(1)
        If pb1.Value = 95 Then
            Try
                My.Computer.Network.Ping("www.google.com")
            Catch
                MsgBox("Internet connection error!" & vbCrLf & "This is an online database project. So please make sure you have a steady internet connection and try again", MessageBoxIcon.Warning)
                Application.Exit()
            End Try

            start.Show()
            t1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub
End Class