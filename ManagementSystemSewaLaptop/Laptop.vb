Imports MySql.Data.MySqlClient
Public Class Laptop
    Dim os As String


    Private Sub Laptop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LaptopIDTbx.Enabled = False

        Listbrand()
        koneksi()
        Updatedata()
        Clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SnumberTbx.Text = "" Or BrandCbx.SelectedIndex = -1 Or ModelTbx.Text = "" Or os = "" Or SpekTbx.Text = "" Or ColorTbx.Text = "" Or PriceTbx.Text = "" Or AvailableCbx.SelectedIndex = -1 Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim inputdata As String
            inputdata = "insert into tb_laptop values('" & LaptopIDTbx.Text & "','" & SnumberTbx.Text & "','" & BrandCbx.SelectedItem.ToString() & "','" & ModelTbx.Text & "','" & os & "','" & SpekTbx.Text & "','" & ColorTbx.Text & "','" & PriceTbx.Text & "','" & AvailableCbx.SelectedItem.ToString() & "')"
            cmd = New MySqlCommand(inputdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Laptop Berhasil Ditambahkan")
            Updatedata()
            clear()

        End If

    End Sub

    Sub LaptopID()
        Dim DR As DataRow
        Dim s As String

        DR = SQLTable("select max(right(Idlaptop,1)) as nomor from tb_laptop").Rows(0)

        If DR.IsNull("Nomor") Then
            s = "L-0001"
        Else
            s = "L-000" & Format(DR("Nomor") + 1, "0")
        End If
        LaptopIDTbx.Text = s
    End Sub

    Sub Listbrand()
        Dim brand() As String = {"Lenovo", "Asus", "HP", "Samsung", "Xiaomi", "Acer", "MSI", "DELL"}
        For i As Integer = 0 To 7
            BrandCbx.Items.Add(brand(i))
        Next
    End Sub

    Sub Updatedata()
        da = New MySqlDataAdapter("select * from tb_laptop order by idlaptop", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_laptop")
        Me.DgvLaptop.DataSource = (ds.Tables("tb_laptop"))
        LaptopID()
    End Sub

    Sub Clear()
        LaptopIDTbx.Text = ""
        ColorTbx.Text = ""
        ModelTbx.Text = ""
        PriceTbx.Text = ""
        SnumberTbx.Text = ""
        SpekTbx.Text = ""
        AvailableCbx.SelectedIndex = -1
        BrandCbx.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Updatedata()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        os = "Windows"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        os = "Linux"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub DgvLaptop_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvLaptop.CellMouseClick
        Dim row As DataGridViewRow = DgvLaptop.Rows(e.RowIndex)
        LaptopIDTbx.Text = row.Cells(0).Value.ToString
        SnumberTbx.Text = row.Cells(1).Value.ToString
        BrandCbx.SelectedItem = row.Cells(2).Value.ToString
        ModelTbx.Text = row.Cells(3).Value.ToString
        os = row.Cells(4).Value.ToString

        Select Case os
            Case "Windows"
                RadioButton1.Checked = True
            Case "Linux"
                RadioButton2.Checked = True
        End Select

        SpekTbx.Text = row.Cells(5).Value.ToString
        ColorTbx.Text = row.Cells(6).Value.ToString
        PriceTbx.Text = row.Cells(7).Value.ToString
        AvailableCbx.SelectedItem = row.Cells(8).Value.ToString

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SnumberTbx.Text = "" Then
            MsgBox("Anda Belum Memilih Item")
        Else
            Dim deletedata As String
            deletedata = "delete from tb_laptop where Idlaptop = '" & LaptopIDTbx.Text & "' "
            cmd = New MySqlCommand(deletedata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Laptop Berhasil Di Hapus")
            Updatedata()
            Clear()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SnumberTbx.Text = "" Or BrandCbx.SelectedIndex = -1 Or ModelTbx.Text = "" Or os = "" Or SpekTbx.Text = "" Or ColorTbx.Text = "" Or PriceTbx.Text = "" Or AvailableCbx.SelectedIndex = -1 Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim Editdata As String
            Editdata = "update tb_laptop set SerialNumber = '" & SnumberTbx.Text & "',Brand ='" & BrandCbx.SelectedItem.ToString() & "',Model = '" & ModelTbx.Text & "', Os=  '" & os & "',Spesifikasi = '" & SpekTbx.Text & "',color = '" & ColorTbx.Text & "',price ='" & PriceTbx.Text & "',Available='" & AvailableCbx.SelectedItem.ToString() & "' where Idlaptop='" & LaptopIDTbx.Text & "'  "
            cmd = New MySqlCommand(Editdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Laptop Berhasil")
            Updatedata()
            clear()

        End If
    End Sub

    Private Sub BrandCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BrandCbx.SelectedIndexChanged


    End Sub
End Class