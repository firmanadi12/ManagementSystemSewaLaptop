Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgressBar.Increment(1)
        If MyProgressBar.Value = 100 Then
            Me.Hide()
            Dim login = New UserLogin
            login.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class
