Imports MySql.Data.MySqlClient

Public Class Staff
    Dim gender As String
    Dim key = 0
    Public Property Uname As String

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Updatedata()
        Clear()

    End Sub

    Sub Updatedata()
        da = New MySqlDataAdapter("select * from tb_staff order by IdStaff", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_staff")
        Me.DgvStaff.DataSource = (ds.Tables("tb_staff"))

    End Sub

    Sub Clear()
        UsernameTbx.Text = ""
        EmailStaffTbx.Text = ""
        NameStaffTbx.Text = ""
        PhoneStaffTbx.Text = ""
        PasswordTbx.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
        key = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTbx.Text = "" Or NameStaffTbx.Text = "" Or gender = "" Or EmailStaffTbx.Text = "" Or PhoneStaffTbx.Text = "" Or PasswordTbx.Text = "" Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim inputdata As String
            inputdata = "insert into tb_staff values(NULL,'" & UsernameTbx.Text & "','" & NameStaffTbx.Text & "','" & gender & "','" & EmailStaffTbx.Text & "','" & PhoneStaffTbx.Text & "','" & MD5Encription(PasswordTbx.Text) & "')"
            cmd = New MySqlCommand(inputdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Staff Berhasil Di Daftarkan")
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

    Private Sub DgvStaff_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvStaff.CellMouseClick
        Dim row As DataGridViewRow = DgvStaff.Rows(e.RowIndex)
        UsernameTbx.Text = row.Cells(1).Value.ToString
        NameStaffTbx.Text = row.Cells(2).Value.ToString
        EmailStaffTbx.Text = row.Cells(4).Value.ToString
        PhoneStaffTbx.Text = row.Cells(5).Value.ToString
        gender = row.Cells(3).Value.ToString
        If gender = "Men" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        If NameStaffTbx.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If UsernameTbx.Text = "" Or NameStaffTbx.Text = "" Or gender = "" Or EmailStaffTbx.Text = "" Or PhoneStaffTbx.Text = "" Or PasswordTbx.Text = "" Then
            MsgBox("Sorry Sepertinya Data Yang Anda Input Belum Lengkap")
        Else
            Dim Editdata As String
            Editdata = "update tb_Staff set Username  = '" & UsernameTbx.Text & "',NameStaff ='" & NameStaffTbx.Text & "', GenderStaff=  '" & gender & "',EmailStaff = '" & EmailStaffTbx.Text & "',PhoneStaff = '" & PhoneStaffTbx.Text & "', PassStaff = '" & MD5Encription(PasswordTbx.Text) & "' where IdStaff='" & key & "'  "
            cmd = New MySqlCommand(Editdata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Staff Berhasil")
            Updatedata()
            Clear()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Anda Belum Memilih Item")
        ElseIf UsernameTbx.Text = "admin" Then
            MsgBox("Anda Tidak Bisa Menghapus username Admin", MessageBoxIcon.Error)
        Else
            Dim deletedata As String
            deletedata = "delete from tb_staff where IdStaff = " & key & " "
            cmd = New MySqlCommand(deletedata, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Staff Berhasil Di Hapus")
            Updatedata()
            Clear()
        End If
    End Sub
End Class