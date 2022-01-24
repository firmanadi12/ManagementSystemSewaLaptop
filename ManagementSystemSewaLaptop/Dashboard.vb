Imports MySql.Data.MySqlClient
Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Revenue()
        CountLaptopAll()
        CountLaptopReady()
        CountLaptopRented()
        CountCustomers()
        CountTransaction()
        TotalRev()
        Listdasbord()
        TitelListLb.Text = "List Data Transaksi"
        DataTransaksi()
    End Sub

    Private Sub TotalRev()
        Dim total As Integer
        total = Revenue() + CountFine()
        RevenueLb.Text = FormatCurrency(total)
    End Sub

    Private Function Revenue()
        Dim CRev As Integer
        Dim query = "select SUM(TotalPrice) from tb_rent"
        cmd = New MySqlCommand(query, Con)
        CRev = cmd.ExecuteScalar
        Return CRev
    End Function

    Private Function CountFine()
        Dim CFine As Integer
        Dim query = "select SUM(FineFee) from tb_return"
        cmd = New MySqlCommand(query, Con)
        CFine = cmd.ExecuteScalar
        Return CFine
    End Function

    Private Sub CountCustomers()
        Dim CCustomer As Integer
        Dim query = "select COUNT(*) from tb_customers"
        cmd = New MySqlCommand(query, Con)
        CCustomer = cmd.ExecuteScalar
        CustomersCountLb.Text = CCustomer
    End Sub

    Private Sub CountTransaction()
        Dim CTrans As Integer
        Dim query = "select COUNT(*) from tb_rent"
        cmd = New MySqlCommand(query, Con)
        CTrans = cmd.ExecuteScalar
        TransCountLb.Text = CTrans
    End Sub

    Private Sub CountLaptopAll()
        Dim ClaptopA As Integer
        Dim query = "select COUNT(*) from tb_laptop"
        cmd = New MySqlCommand(query, Con)
        ClaptopA = cmd.ExecuteScalar
        AllLaptopCountLb.Text = ClaptopA
    End Sub

    Private Sub CountLaptopReady()
        Dim ClaptopR As Integer
        Dim query = "select COUNT(*) from tb_laptop where Available='Yes' "
        cmd = New MySqlCommand(query, Con)
        ClaptopR = cmd.ExecuteScalar
        ReadyLaptoCountLb.Text = ClaptopR
    End Sub

    Private Sub CountLaptopRented()
        Dim ClaptopRent As Integer
        Dim query = "select COUNT(*) from tb_laptop where Available='No' "
        cmd = New MySqlCommand(query, Con)
        ClaptopRent = cmd.ExecuteScalar
        RentedCountLb.Text = ClaptopRent
    End Sub
    Dim Tlist As String
    Sub Listdasbord()

        Select Case ListCbx.Text
            Case "Data Laptop"
                Tlist = "List Data Laptop"
                DataLaptop()

            Case "Data Customer"
                Tlist = "List Data Customer"
                DataCustomer()

            Case "Data Transaksi"
                Tlist = "List Data Transaksi"
                DataTransaksi()

            Case "Data Return"
                Tlist = "List Data Return"
                DataReturn()
        End Select
        TitelListLb.Text = Tlist
    End Sub

    Private Sub ListCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCbx.SelectedIndexChanged
        Listdasbord()
    End Sub

    Sub DataTransaksi()
        da = New MySqlDataAdapter("select * from tb_rent order by InvoiceID", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_rent")
        Me.DgvDasboard.DataSource = (ds.Tables("tb_rent"))
    End Sub

    Sub DataReturn()
        da = New MySqlDataAdapter("select * from tb_return order by IdReturn", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_return")
        Me.DgvDasboard.DataSource = (ds.Tables("tb_return"))
    End Sub

    Sub DataLaptop()
        da = New MySqlDataAdapter("select * from tb_laptop order by idlaptop", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_laptop")
        Me.DgvDasboard.DataSource = (ds.Tables("tb_laptop"))
    End Sub

    Sub DataCustomer()
        da = New MySqlDataAdapter("select * from tb_customers order by IdCustomer", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_customers")
        Me.DgvDasboard.DataSource = (ds.Tables("tb_customers"))
    End Sub


End Class