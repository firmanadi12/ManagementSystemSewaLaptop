Imports MySql.Data.MySqlClient
Public Class UserLogin

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

    End Sub
    Sub Clear()
        PasswordTbx.Text = ""
        UsernameTbx.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTbx.Text = "" Then
            MsgBox("Enter The Username")
        ElseIf PasswordTbx.Text = "" Then
            MsgBox("Enter the Password")
        Else
            Dim query = "select * from tb_staff where Username ='" & UsernameTbx.Text & "' and PassStaff='" & MD5Encription(PasswordTbx.Text) & "' "
            cmd = New MySqlCommand(query, Con)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wronge Username or Password ")
                Clear()
            Else
                If UsernameTbx.Text = "admin" Then
                    MsgBox("Login Sebagai User Admin Berhasil")
                    Dim admin = New DashboardAdmin
                    admin.Uname = UsernameTbx.Text
                    admin.Show()
                    Clear()

                    Me.Hide()
                Else
                    MsgBox("Selamat Datang " & UsernameTbx.Text & " Semoga Hari Mu Menyenangkan ")
                    Dim users = New Main
                    users.Uname = UsernameTbx.Text
                    users.Show()
                    Clear()

                    Me.Hide()

                End If

            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            PasswordTbx.UseSystemPasswordChar = False
        Else
            PasswordTbx.UseSystemPasswordChar = True
        End If
    End Sub
End Class