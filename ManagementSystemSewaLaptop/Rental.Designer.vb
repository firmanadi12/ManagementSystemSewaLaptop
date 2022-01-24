<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rental))
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CustNameTbx = New ns1.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustIdCbx = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdLaptopCbx = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalPriceTbx = New ns1.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DgvRent = New ns1.BunifuCustomDataGrid()
        Me.SnumberTbx = New ns1.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ModelTbx = New ns1.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RentDate = New System.Windows.Forms.DateTimePicker()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.NoTransTbx = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvRent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(70, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(282, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Customer ID"
        '
        'CustNameTbx
        '
        Me.CustNameTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.CustNameTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustNameTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.CustNameTbx.BorderThickness = 3
        Me.CustNameTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustNameTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CustNameTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustNameTbx.isPassword = False
        Me.CustNameTbx.Location = New System.Drawing.Point(375, 272)
        Me.CustNameTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.CustNameTbx.Name = "CustNameTbx"
        Me.CustNameTbx.Size = New System.Drawing.Size(250, 31)
        Me.CustNameTbx.TabIndex = 42
        Me.CustNameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(667, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Serial Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1394, 44)
        Me.Panel1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(490, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Laptop Rental Management System"
        '
        'CustIdCbx
        '
        Me.CustIdCbx.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CustIdCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustIdCbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIdCbx.FormattingEnabled = True
        Me.CustIdCbx.Location = New System.Drawing.Point(375, 206)
        Me.CustIdCbx.Name = "CustIdCbx"
        Me.CustIdCbx.Size = New System.Drawing.Size(250, 28)
        Me.CustIdCbx.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(665, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Laptop ID"
        '
        'IdLaptopCbx
        '
        Me.IdLaptopCbx.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.IdLaptopCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IdLaptopCbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLaptopCbx.FormattingEnabled = True
        Me.IdLaptopCbx.Location = New System.Drawing.Point(669, 136)
        Me.IdLaptopCbx.Name = "IdLaptopCbx"
        Me.IdLaptopCbx.Size = New System.Drawing.Size(250, 28)
        Me.IdLaptopCbx.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(967, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Rent Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(967, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Return Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(967, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 21)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Total Price"
        '
        'TotalPriceTbx
        '
        Me.TotalPriceTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.TotalPriceTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalPriceTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TotalPriceTbx.BorderThickness = 3
        Me.TotalPriceTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalPriceTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TotalPriceTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalPriceTbx.isPassword = False
        Me.TotalPriceTbx.Location = New System.Drawing.Point(968, 272)
        Me.TotalPriceTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPriceTbx.Name = "TotalPriceTbx"
        Me.TotalPriceTbx.Size = New System.Drawing.Size(231, 31)
        Me.TotalPriceTbx.TabIndex = 56
        Me.TotalPriceTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 30)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Rent / Transaction"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 10)
        Me.Panel2.TabIndex = 58
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(800, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 33)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(688, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DgvRent
        '
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvRent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRent.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DgvRent.ColumnHeadersHeight = 35
        Me.DgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvRent.DoubleBuffered = True
        Me.DgvRent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvRent.EnableHeadersVisualStyles = False
        Me.DgvRent.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvRent.HeaderForeColor = System.Drawing.Color.White
        Me.DgvRent.Location = New System.Drawing.Point(70, 409)
        Me.DgvRent.Name = "DgvRent"
        Me.DgvRent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRent.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DgvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvRent.Size = New System.Drawing.Size(1236, 276)
        Me.DgvRent.TabIndex = 63
        '
        'SnumberTbx
        '
        Me.SnumberTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.SnumberTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SnumberTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.SnumberTbx.BorderThickness = 3
        Me.SnumberTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SnumberTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SnumberTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SnumberTbx.isPassword = False
        Me.SnumberTbx.Location = New System.Drawing.Point(669, 203)
        Me.SnumberTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.SnumberTbx.Name = "SnumberTbx"
        Me.SnumberTbx.Size = New System.Drawing.Size(250, 31)
        Me.SnumberTbx.TabIndex = 66
        Me.SnumberTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(371, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 21)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Customer Name"
        '
        'ModelTbx
        '
        Me.ModelTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.ModelTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ModelTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.ModelTbx.BorderThickness = 3
        Me.ModelTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ModelTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ModelTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ModelTbx.isPassword = False
        Me.ModelTbx.Location = New System.Drawing.Point(669, 272)
        Me.ModelTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.ModelTbx.Name = "ModelTbx"
        Me.ModelTbx.Size = New System.Drawing.Size(250, 31)
        Me.ModelTbx.TabIndex = 70
        Me.ModelTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(667, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Model"
        '
        'RentDate
        '
        Me.RentDate.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentDate.CustomFormat = ""
        Me.RentDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentDate.Location = New System.Drawing.Point(971, 134)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(228, 29)
        Me.RentDate.TabIndex = 73
        Me.RentDate.Value = New Date(2022, 1, 18, 0, 0, 0, 0)
        '
        'ReturnDate
        '
        Me.ReturnDate.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.CustomFormat = ""
        Me.ReturnDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.Location = New System.Drawing.Point(971, 202)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(228, 29)
        Me.ReturnDate.TabIndex = 74
        Me.ReturnDate.Value = New Date(2022, 1, 18, 0, 0, 0, 0)
        '
        'NoTransTbx
        '
        Me.NoTransTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.NoTransTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NoTransTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.NoTransTbx.BorderThickness = 3
        Me.NoTransTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NoTransTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.NoTransTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NoTransTbx.isPassword = False
        Me.NoTransTbx.Location = New System.Drawing.Point(373, 136)
        Me.NoTransTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.NoTransTbx.Name = "NoTransTbx"
        Me.NoTransTbx.Size = New System.Drawing.Size(252, 31)
        Me.NoTransTbx.TabIndex = 75
        Me.NoTransTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Invoice ID"
        '
        'Rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoTransTbx)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.RentDate)
        Me.Controls.Add(Me.ModelTbx)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.SnumberTbx)
        Me.Controls.Add(Me.DgvRent)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TotalPriceTbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IdLaptopCbx)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CustNameTbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustIdCbx)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvRent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CustNameTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CustIdCbx As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdLaptopCbx As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalPriceTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DgvRent As ns1.BunifuCustomDataGrid
    Friend WithEvents SnumberTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents ModelTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents RentDate As DateTimePicker
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents NoTransTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
End Class
