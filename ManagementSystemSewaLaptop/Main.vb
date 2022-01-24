Public Class Main
    Public Property Uname As String
    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.MdiParent = Me
        Customer.Show()
        Rental.Hide()
        Returns.Hide()

    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Rental.MdiParent = Me
        Rental.Show()
        Customer.Hide()
        Returns.Hide()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim log = New UserLogin
        UsernameLb.Text = Uname
        Customer.MdiParent = Me
        Customer.Show()
        Rental.Hide()
        Returns.Hide()
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem1.Click
        Returns.MdiParent = Me
        Returns.Show()
        Rental.Hide()
        Customer.Hide()
        Laptop.Hide()
        Staff.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        UserLogin.Show()
    End Sub
End Class