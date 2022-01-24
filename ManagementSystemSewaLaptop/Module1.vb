Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Module Module1
    Public Con As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public db As String
    Public dtb As DataTable

    Public Sub Koneksi()
        db = "Server=localhost;user id=root;password=;database=db_sewalaptop;Convert Zero Datetime=true"
        Con = New MySqlConnection(db)

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()

            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub Koneksi2()
        db = "Server=localhost;user id=root;password=;database=db_sewalaptop;Convert Zero Datetime=true"
        Con = New MySqlConnection(db)
    End Sub

    Public Function MD5Encription(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If
        Bytes = Encoding.Default.GetBytes(Source)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function

    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim adp As New MySqlDataAdapter(Source, Con)
            dtb = New DataTable
            adp.Fill(dtb)
            SQLTable = dtb
        Catch ex As MySqlException
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function

    Public Sub FillCustomer()
        Dim FillCust = "select * from tb_customers"
        cmd = New MySqlCommand(FillCust, Con)
        da = New MySqlDataAdapter(cmd)
        dtb = New DataTable()
        da.Fill(dtb)
        Rental.CustIdCbx.DataSource = dtb
        Rental.CustIdCbx.DisplayMember = "IdCustomer"
        Rental.CustIdCbx.ValueMember = "IdCustomer"
        Con.Close()
    End Sub

    Public Sub FillSnumber()
        Dim status = "Yes"
        Dim FillSnum = "select * from tb_laptop where Available ='" & status & "'"
        cmd = New MySqlCommand(FillSnum, Con)
        da = New MySqlDataAdapter(cmd)
        dtb = New DataTable()
        da.Fill(dtb)
        Rental.IdLaptopCbx.DataSource = dtb
        Rental.IdLaptopCbx.DisplayMember = "Idlaptop"
        Rental.IdLaptopCbx.ValueMember = "Idlaptop"
        Con.Close()

    End Sub

End Module
