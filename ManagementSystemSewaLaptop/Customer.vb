Imports MySql.Data.MySqlClient
Public Class Customer

    Dim gender = ""
    Public Property Uname As String
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Updatedata()
        CustIDTbx.Enabled = False
        Clear()
    End Sub

    Sub Updatedata()
        da = New MySqlDataAdapter("select * from tb_customers order by IdCustomer", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_customers")
        Me.DgvCustomer.DataSource = (ds.Tables("tb_customers"))
        CustomerID()

    End Sub

    Sub CustomerID()
        Dim DR As DataRow
        Dim s As String

        DR = SQLTable("select max(right(IdCustomer,1)) as nomor from tb_customers").Rows(0)

        If DR.IsNull("Nomor") Then
            s = "CUST-0001"
        Else
            s = "CUST-000" & Format(DR("Nomor") + 1, "0")
        End If
        CustIDTbx.Text = s
    End Sub

    Sub Clear()
        CustIDTbx.Text = ""
        IdentNumberTbx.Text = ""
        NameCustTbx.Text = ""
        PhoneCustTbx.Text = ""
        EmailCustTbx.Text = ""
        AddressCustTbx.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False


        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
        Updatedata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IdentNumberTbx.Text = "" Or NameCustTbx.Text = "" Or PhoneCustTbx.Text = "" Or EmailCustTbx.Text = "" Or gender = "" Or AddressCustTbx.Text = "" Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim inputdata As String
            inputdata = "insert into tb_customers values('" & CustIDTbx.Text & "','" & IdentNumberTbx.Text & "','" & NameCustTbx.Text & "','" & PhoneCustTbx.Text & "','" & EmailCustTbx.Text & "','" & gender & "','" & AddressCustTbx.Text & "')"
            cmd = New MySqlCommand(inputdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Customer Berhasil Ditambahkan")
            Updatedata()
            Clear()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Men"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Woman"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IdentNumberTbx.Text = "" Or NameCustTbx.Text = "" Then
            MsgBox("Anda Belum Memilih Item")
        Else
            Dim deletedata As String
            deletedata = "delete from tb_customers where IdCustomer = '" & CustIDTbx.Text & "' "
            cmd = New MySqlCommand(deletedata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Customer Berhasil Di Hapus")
            Updatedata()
            Clear()
        End If
    End Sub

    Private Sub DgvCustomer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvCustomer.CellMouseClick
        Dim row As DataGridViewRow = DgvCustomer.Rows(e.RowIndex)
        CustIDTbx.Text = row.Cells(0).Value.ToString
        IdentNumberTbx.Text = row.Cells(1).Value.ToString
        NameCustTbx.Text = row.Cells(2).Value.ToString
        PhoneCustTbx.Text = row.Cells(3).Value.ToString
        EmailCustTbx.Text = row.Cells(4).Value.ToString

        gender = row.Cells(5).Value.ToString
        If gender = "Men" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        AddressCustTbx.Text = row.Cells(6).Value.ToString

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IdentNumberTbx.Text = "" Or NameCustTbx.Text = "" Or PhoneCustTbx.Text = "" Or EmailCustTbx.Text = "" Or gender = "" Or AddressCustTbx.Text = "" Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim Editdata As String
            Editdata = "update tb_customers set IdentityNum  = '" & IdentNumberTbx.Text & "',NameCustomer ='" & NameCustTbx.Text & "',PhoneCustomer = '" & PhoneCustTbx.Text & "',EmailCustomer = '" & EmailCustTbx.Text & "', Gender=  '" & gender & "', AddressCustomer = '" & AddressCustTbx.Text & "' where IdCustomer='" & CustIDTbx.Text & "'  "
            cmd = New MySqlCommand(Editdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Customer Berhasil")
            Updatedata()
            Clear()

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class