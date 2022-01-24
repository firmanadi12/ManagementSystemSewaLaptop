Imports MySql.Data.MySqlClient
Public Class Returns
    Dim Fine As Integer
    Dim delaysday As Integer
    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetIdTbx.Enabled = False
        CustNameTbx.Enabled = False
        InvoiceTbx.Enabled = False
        ReturnDateTbx.Enabled = False
        DelayTbx.Enabled = False
        FineFeeTbx.Enabled = False
        SnumTbx.Enabled = False
        Koneksi()
        Updatedata()
        UpdatedataReturn()
        Clear()


    End Sub
    Sub ReturnID()
        Dim DR As DataRow
        Dim s As String
        DR = SQLTable("select max(right(IdReturn,1)) as nomor from tb_Return").Rows(0)
        If DR.IsNull("Nomor") Then
            s = "R-0001"
        Else
            s = "R-000" & Format(DR("Nomor") + 1, "0")
        End If
        RetIdTbx.Text = s
    End Sub
    Sub UpdateStatus()
        Dim status = "Yes"
        Dim edit As String
        edit = "update tb_laptop set Available = '" & status & "' where SerialNumber='" & SnumTbx.Text & "' "
        cmd = New MySqlCommand(edit, Con)
        cmd.ExecuteNonQuery()
    End Sub

    Sub Updatetransaction()
        Dim statustranscation = "Selesai / Telah Dikembalikan"
        Dim edit As String
        edit = "update tb_rent set status ='" & statustranscation & "' where InvoiceID='" & InvoiceTbx.Text & "'  "
        cmd = New MySqlCommand(edit, Con)
        cmd.ExecuteNonQuery()

    End Sub
    Sub Updatedata()
        Dim status = "Transaksi Berhasil / Dalam Penyewaan"
        da = New MySqlDataAdapter("select * from tb_rent where Status = '" & status & "' ", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_rent")
        Me.DgvRent.DataSource = (ds.Tables("tb_rent"))

    End Sub

    Sub UpdatedataReturn()
        da = New MySqlDataAdapter("select * from tb_return order by IdReturn", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_return")
        Me.DgvReturn.DataSource = (ds.Tables("tb_return"))
        ReturnID()

    End Sub


    Sub Caldelay()

        Dim diff As System.TimeSpan = DateTime.Today.Date.Subtract(Convert.ToDateTime(ReturnDateTbx.Text))

        Dim days = diff.TotalDays
        If days <= 0 Then
            days = 0
            DelayTbx.Text = "Pengembalian Tepat Waktu"
            FineFeeTbx.Text = "Tidak Ada Denda"
            Fine = 0
            delaysday = 0
        Else
            delaysday = days
            DelayTbx.Text = days & " Days"
            Fine = days * 50000
            FineFeeTbx.Text = FormatCurrency(Fine)
        End If

    End Sub

    Private Sub DgvRent_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvRent.CellMouseClick
        Dim row As DataGridViewRow = DgvRent.Rows(e.RowIndex)

        InvoiceTbx.Text = row.Cells("InvoiceID").Value.ToString
        SnumTbx.Text = row.Cells("SerialNumber").Value.ToString
        CustNameTbx.Text = row.Cells("NameCustomer").Value.ToString
        ReturnDateTbx.Text = row.Cells("DateReturn").Value.ToString

    End Sub

    Private Sub ReturnDateTbx_OnValueChanged(sender As Object, e As EventArgs) Handles ReturnDateTbx.OnValueChanged
        Caldelay()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CustNameTbx.Text = "" Or DelayTbx.Text = "" Then
            MsgBox("Anda Belum Memilih")
        Else
            Dim inputdata As String
            inputdata = "insert into tb_return values('" & RetIdTbx.Text & "','" & InvoiceTbx.Text & "','" & SnumTbx.Text & "','" & CustNameTbx.Text & "','" & Format(DateTime.Now, "yyyy-MM-dd") & "','" & delaysday & "','" & Fine & "')"
            cmd = New MySqlCommand(inputdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Transaksi Selesai Laptop Telah Dikembalikan")
            UpdateStatus()
            Updatetransaction()
            Updatedata()
            UpdatedataReturn()
            Clear()

        End If

    End Sub


    Sub Clear()
        RetIdTbx.Text = ""
        CustNameTbx.Text = ""
        DelayTbx.Text = ""
        FineFeeTbx.Text = ""
        UpdatedataReturn()

    End Sub




    Private Sub SearchTbx_OnValueChanged(sender As Object, e As EventArgs) Handles SearchTbx.OnValueChanged
        da = New MySqlDataAdapter("select * from tb_rent where InvoiceID like '%" & SearchTbx.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "tb_rent")
        DgvRent.DataSource = (ds.Tables("tb_rent"))
    End Sub
End Class