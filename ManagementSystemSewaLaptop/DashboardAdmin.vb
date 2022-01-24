Public Class DashboardAdmin

    Public Property Uname As String
    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.MdiParent = Me
        Customer.Show()
        Laptop.Close()
        Staff.Close()
        Rental.Close()
        Returns.Close()
        Dashboard.Close()



    End Sub

    Private Sub DataLaptopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLaptopToolStripMenuItem.Click
        Laptop.MdiParent = Me
        Laptop.Show()
        Customer.Close()
        Staff.Close()
        Rental.Close()
        Returns.Close()
        Dashboard.Close()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Staff.MdiParent = Me
        Staff.Show()
        Customer.Close()
        Laptop.Close()
        Rental.Close()
        Returns.Close()
        Dashboard.Close()

    End Sub

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim log = New UserLogin
        UsernameLb.Text = Uname
        Dashboard.MdiParent = Me
        Dashboard.Show()
    End Sub

    Private Sub TransactionRentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionRentToolStripMenuItem.Click
        Rental.MdiParent = Me
        Rental.Show()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
        Returns.Close()
        Dashboard.Close()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Returns.MdiParent = Me
        Returns.Show()
        Rental.Close()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
        Dashboard.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
        UserLogin.Show()

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        UserLogin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dashboard.MdiParent = Me
        Dashboard.Show()
        Returns.Close()
        Rental.Close()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
    End Sub

    Private Sub DashboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem1.Click
        Dashboard.MdiParent = Me
        Dashboard.Show()
        Returns.Close()
        Rental.Close()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem1.Click
        Staff.MdiParent = Me
        Staff.Show()
        Customer.Close()
        Laptop.Close()
        Rental.Close()
        Returns.Close()
        Dashboard.Close()
    End Sub

    Private Sub DataLaptopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataLaptopToolStripMenuItem1.Click
        Laptop.MdiParent = Me
        Laptop.Show()
        Customer.Close()
        Staff.Close()
        Rental.Close()
        Returns.Close()
        Dashboard.Close()
    End Sub

    Private Sub RentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentToolStripMenuItem.Click
        Rental.MdiParent = Me
        Rental.Show()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
        Returns.Close()
        Dashboard.Close()
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem1.Click
        Returns.MdiParent = Me
        Returns.Show()
        Rental.Close()
        Customer.Close()
        Laptop.Close()
        Staff.Close()
        Dashboard.Close()
    End Sub
End Class