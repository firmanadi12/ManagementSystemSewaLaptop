<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneCustTbx = New ns1.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressCustTbx = New ns1.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmailCustTbx = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameCustTbx = New ns1.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdentNumberTbx = New ns1.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DgvCustomer = New ns1.BunifuCustomDataGrid()
        Me.CustIDTbx = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(187, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Women"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(70, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(51, 20)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Men"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(45, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 266)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(809, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(370, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Phone"
        '
        'PhoneCustTbx
        '
        Me.PhoneCustTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.PhoneCustTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneCustTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.PhoneCustTbx.BorderThickness = 3
        Me.PhoneCustTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneCustTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PhoneCustTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneCustTbx.isPassword = False
        Me.PhoneCustTbx.Location = New System.Drawing.Point(374, 276)
        Me.PhoneCustTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneCustTbx.Name = "PhoneCustTbx"
        Me.PhoneCustTbx.Size = New System.Drawing.Size(327, 31)
        Me.PhoneCustTbx.TabIndex = 42
        Me.PhoneCustTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(370, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(374, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 42)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1395, 44)
        Me.Panel1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(509, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Laptop Rental Management System"
        '
        'AddressCustTbx
        '
        Me.AddressCustTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.AddressCustTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddressCustTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.AddressCustTbx.BorderThickness = 3
        Me.AddressCustTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressCustTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.AddressCustTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddressCustTbx.isPassword = False
        Me.AddressCustTbx.Location = New System.Drawing.Point(813, 276)
        Me.AddressCustTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressCustTbx.Name = "AddressCustTbx"
        Me.AddressCustTbx.Size = New System.Drawing.Size(311, 91)
        Me.AddressCustTbx.TabIndex = 46
        Me.AddressCustTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(809, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 21)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Email"
        '
        'EmailCustTbx
        '
        Me.EmailCustTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.EmailCustTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailCustTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.EmailCustTbx.BorderThickness = 3
        Me.EmailCustTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailCustTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.EmailCustTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailCustTbx.isPassword = False
        Me.EmailCustTbx.Location = New System.Drawing.Point(813, 216)
        Me.EmailCustTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailCustTbx.Name = "EmailCustTbx"
        Me.EmailCustTbx.Size = New System.Drawing.Size(311, 31)
        Me.EmailCustTbx.TabIndex = 36
        Me.EmailCustTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(809, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Customer Name"
        '
        'NameCustTbx
        '
        Me.NameCustTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.NameCustTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameCustTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.NameCustTbx.BorderThickness = 3
        Me.NameCustTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameCustTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.NameCustTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameCustTbx.isPassword = False
        Me.NameCustTbx.Location = New System.Drawing.Point(813, 156)
        Me.NameCustTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.NameCustTbx.Name = "NameCustTbx"
        Me.NameCustTbx.Size = New System.Drawing.Size(311, 31)
        Me.NameCustTbx.TabIndex = 34
        Me.NameCustTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Identity Number"
        '
        'IdentNumberTbx
        '
        Me.IdentNumberTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.IdentNumberTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdentNumberTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.IdentNumberTbx.BorderThickness = 3
        Me.IdentNumberTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdentNumberTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.IdentNumberTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdentNumberTbx.isPassword = False
        Me.IdentNumberTbx.Location = New System.Drawing.Point(374, 216)
        Me.IdentNumberTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.IdentNumberTbx.Name = "IdentNumberTbx"
        Me.IdentNumberTbx.Size = New System.Drawing.Size(327, 31)
        Me.IdentNumberTbx.TabIndex = 32
        Me.IdentNumberTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Customer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(17, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 10)
        Me.Panel2.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(463, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 33)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(661, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 33)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(862, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 33)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1046, 395)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 33)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DgvCustomer
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvCustomer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCustomer.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCustomer.ColumnHeadersHeight = 35
        Me.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvCustomer.DoubleBuffered = True
        Me.DgvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvCustomer.EnableHeadersVisualStyles = False
        Me.DgvCustomer.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvCustomer.HeaderForeColor = System.Drawing.Color.White
        Me.DgvCustomer.Location = New System.Drawing.Point(47, 451)
        Me.DgvCustomer.Name = "DgvCustomer"
        Me.DgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCustomer.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvCustomer.Size = New System.Drawing.Size(1241, 237)
        Me.DgvCustomer.TabIndex = 55
        '
        'CustIDTbx
        '
        Me.CustIDTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.CustIDTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustIDTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.CustIDTbx.BorderThickness = 3
        Me.CustIDTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustIDTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CustIDTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustIDTbx.isPassword = False
        Me.CustIDTbx.Location = New System.Drawing.Point(374, 156)
        Me.CustIDTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.CustIDTbx.Name = "CustIDTbx"
        Me.CustIDTbx.Size = New System.Drawing.Size(327, 31)
        Me.CustIDTbx.TabIndex = 56
        Me.CustIDTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Customer ID"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1386, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustIDTbx)
        Me.Controls.Add(Me.DgvCustomer)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PhoneCustTbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddressCustTbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EmailCustTbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameCustTbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdentNumberTbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneCustTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressCustTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents EmailCustTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents NameCustTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdentNumberTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DgvCustomer As ns1.BunifuCustomDataGrid
    Friend WithEvents CustIDTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
End Class
