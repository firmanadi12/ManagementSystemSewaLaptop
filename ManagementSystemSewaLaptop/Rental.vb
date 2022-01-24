Imports MySql.Data.MySqlClient
Public Class Rental
    Public Property Uname As String
    Private Sub Rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi2()
        FillCustomer()
        FillSnumber()
        Updatedata()

        Clear()
        ModelTbx.Enabled = False
        CustNameTbx.Enabled = False
        SnumberTbx.Enabled = False
        TotalPriceTbx.Enabled = False
        NoTransTbx.Enabled = False


        RentDate.MinDate = DateTime.Now
        ReturnDate.MinDate = DateTime.Now
        ReturnDate.Value = Now.Date.AddDays(+1)
    End Sub

    Sub InoviceNum()
        Dim DR As DataRow
        Dim s As String
        DR = SQLTable("select max(right(InvoiceID,1)) as nomor from tb_rent").Rows(0)
        If DR.IsNull("Nomor") Then
            s = "INVOICE-0001"
        Else
            s = "INVOICE-000" & Format(DR("Nomor") + 1, "0")
        End If
        NoTransTbx.Text = s
    End Sub


    Private Sub GetModel()
        Con.Open()
        Dim GetMod = "select * from tb_laptop where Idlaptop='" & IdLaptopCbx.SelectedValue.ToString() & "'"
        Dim cmd As New MySqlCommand(GetMod, Con)
            Dim dtb As New DataTable
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                SnumberTbx.Text = "" + reader("SerialNumber")
                ModelTbx.Text = "" + reader("Model")

            End While
        Con.Close()
    End Sub
    Dim cost = 0
    Private Sub GetLaptopPrice()
        Con.Open()
        Dim GetPrice = "select * from tb_laptop where Idlaptop='" & IdLaptopCbx.SelectedValue.ToString() & "'"
        Dim cmd As New MySqlCommand(GetPrice, Con)
        Dim dtb As New DataTable
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            cost = Convert.ToInt32(reader("Price").ToString())

        End While
        Con.Close()
    End Sub

    Private Sub GetCustomerName()
        Con.Open()
        Dim GetCust = "select * from tb_customers where IdCustomer='" & CustIdCbx.SelectedValue.ToString() & "'"
        Dim cmd As New MySqlCommand(GetCust, Con)
            Dim dtb As New DataTable
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                CustNameTbx.Text = "" + reader("NameCustomer")
            End While
        Con.Close()
    End Sub


    Private Sub CustIdCbx_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustIdCbx.SelectionChangeCommitted
        GetCustomerName()
    End Sub

    Private Sub SnumberCbx_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles IdLaptopCbx.SelectionChangeCommitted
        GetModel()
        GetLaptopPrice()
    End Sub

    Private Sub Clear()
        CustNameTbx.Text = ""
        ModelTbx.Text = ""
        SnumberTbx.Text = ""
        TotalPriceTbx.Text = ""
        Updatedata()
    End Sub
    Sub Updatedata()
        Con.Open()
        da = New MySqlDataAdapter("select * from tb_rent", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_rent")
        Me.DgvRent.DataSource = (ds.Tables("tb_rent"))
        InoviceNum()
        Con.Close

    End Sub

    Sub UpdateStatus()
        Con.Open()
        Dim status = "No"
        Dim Editdata As String
        Editdata = "update tb_laptop set Available = '" & status & "' where Idlaptop='" & IdLaptopCbx.SelectedValue.ToString() & "' "
        cmd = New MySqlCommand(Editdata, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
    End Sub

    Sub Calculateprice()
        Dim diff As System.TimeSpan = ReturnDate.Value.Date.Subtract(RentDate.Value.Date)
        Dim days = diff.TotalDays
        Dim totalprice = days * cost
        TotalPriceTbx.Text = totalprice

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SnumberTbx.Text = "" Or ModelTbx.Text = "" Or CustNameTbx.Text = "" Or TotalPriceTbx.Text = "" Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Con.Open()
            Dim statustransaksi = "Transaksi Berhasil / Dalam Penyewaan"
                Dim inputdata As String
            inputdata = "insert into tb_rent values('" & NoTransTbx.Text & "','" & Format(DateTime.Now, "yyyy-MM-dd") & "','" & IdLaptopCbx.SelectedValue.ToString() & "','" & SnumberTbx.Text & "','" & ModelTbx.Text & "','" & CustIdCbx.SelectedValue.ToString() & "','" & CustNameTbx.Text & "','" & Format(RentDate.Value, "yyyy-MM-dd") & "','" & Format(ReturnDate.Value, "yyyy-MM-dd") & "', '" & TotalPriceTbx.Text & "','" & statustransaksi & "' )"
            cmd = New MySqlCommand(inputdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Transaksi Berhasil")
            Con.Close()
            UpdateStatus()
            Clear()
            Updatedata()
            FillSnumber()
            Invoice.ShowDialog()

        End If
    End Sub



    Private Sub ReturnDate_CloseUp(sender As Object, e As EventArgs) Handles ReturnDate.CloseUp
        Calculateprice()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class