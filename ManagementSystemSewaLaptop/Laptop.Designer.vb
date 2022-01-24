<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laptop
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laptop))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SnumberTbx = New ns1.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpekTbx = New ns1.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ModelTbx = New ns1.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BrandCbx = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PriceTbx = New ns1.BunifuMetroTextbox()
        Me.AvailableCbx = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ColorTbx = New ns1.BunifuMetroTextbox()
        Me.DgvLaptop = New ns1.BunifuCustomDataGrid()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LaptopIDTbx = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvLaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1388, 44)
        Me.Panel1.TabIndex = 0
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
        Me.SnumberTbx.Location = New System.Drawing.Point(375, 227)
        Me.SnumberTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.SnumberTbx.Name = "SnumberTbx"
        Me.SnumberTbx.Size = New System.Drawing.Size(228, 31)
        Me.SnumberTbx.TabIndex = 8
        Me.SnumberTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Serial Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(678, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Spesifikasi"
        '
        'SpekTbx
        '
        Me.SpekTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.SpekTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpekTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.SpekTbx.BorderThickness = 3
        Me.SpekTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SpekTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SpekTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpekTbx.isPassword = False
        Me.SpekTbx.Location = New System.Drawing.Point(682, 301)
        Me.SpekTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.SpekTbx.Name = "SpekTbx"
        Me.SpekTbx.Size = New System.Drawing.Size(234, 31)
        Me.SpekTbx.TabIndex = 10
        Me.SpekTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(678, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Model"
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
        Me.ModelTbx.Location = New System.Drawing.Point(682, 227)
        Me.ModelTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.ModelTbx.Name = "ModelTbx"
        Me.ModelTbx.Size = New System.Drawing.Size(234, 31)
        Me.ModelTbx.TabIndex = 12
        Me.ModelTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(678, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Brand"
        '
        'BrandCbx
        '
        Me.BrandCbx.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BrandCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrandCbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandCbx.FormattingEnabled = True
        Me.BrandCbx.Location = New System.Drawing.Point(682, 157)
        Me.BrandCbx.Name = "BrandCbx"
        Me.BrandCbx.Size = New System.Drawing.Size(234, 28)
        Me.BrandCbx.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(77, 20)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Windows"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(89, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 20)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Linux"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(375, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 42)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Operating System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1002, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Price"
        '
        'PriceTbx
        '
        Me.PriceTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.PriceTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.PriceTbx.BorderThickness = 3
        Me.PriceTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PriceTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTbx.isPassword = False
        Me.PriceTbx.Location = New System.Drawing.Point(1006, 227)
        Me.PriceTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTbx.Name = "PriceTbx"
        Me.PriceTbx.Size = New System.Drawing.Size(217, 31)
        Me.PriceTbx.TabIndex = 21
        Me.PriceTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AvailableCbx
        '
        Me.AvailableCbx.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.AvailableCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvailableCbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableCbx.FormattingEnabled = True
        Me.AvailableCbx.Items.AddRange(New Object() {"Yes", "No"})
        Me.AvailableCbx.Location = New System.Drawing.Point(1006, 304)
        Me.AvailableCbx.Name = "AvailableCbx"
        Me.AvailableCbx.Size = New System.Drawing.Size(217, 28)
        Me.AvailableCbx.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1002, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Available"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1002, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 21)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Color"
        '
        'ColorTbx
        '
        Me.ColorTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.ColorTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ColorTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.ColorTbx.BorderThickness = 3
        Me.ColorTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ColorTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ColorTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ColorTbx.isPassword = False
        Me.ColorTbx.Location = New System.Drawing.Point(1006, 157)
        Me.ColorTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.ColorTbx.Name = "ColorTbx"
        Me.ColorTbx.Size = New System.Drawing.Size(217, 31)
        Me.ColorTbx.TabIndex = 25
        Me.ColorTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DgvLaptop
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvLaptop.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvLaptop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLaptop.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvLaptop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvLaptop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvLaptop.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvLaptop.ColumnHeadersHeight = 35
        Me.DgvLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvLaptop.DoubleBuffered = True
        Me.DgvLaptop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvLaptop.EnableHeadersVisualStyles = False
        Me.DgvLaptop.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvLaptop.HeaderForeColor = System.Drawing.Color.White
        Me.DgvLaptop.Location = New System.Drawing.Point(157, 405)
        Me.DgvLaptop.Name = "DgvLaptop"
        Me.DgvLaptop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvLaptop.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvLaptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvLaptop.Size = New System.Drawing.Size(1066, 253)
        Me.DgvLaptop.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(157, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 216)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 30)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Laptop"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(16, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(122, 10)
        Me.Panel2.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(932, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 33)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(745, 351)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 33)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(558, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 33)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(376, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 33)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LaptopIDTbx
        '
        Me.LaptopIDTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.LaptopIDTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LaptopIDTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.LaptopIDTbx.BorderThickness = 3
        Me.LaptopIDTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LaptopIDTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LaptopIDTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LaptopIDTbx.isPassword = False
        Me.LaptopIDTbx.Location = New System.Drawing.Point(376, 154)
        Me.LaptopIDTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.LaptopIDTbx.Name = "LaptopIDTbx"
        Me.LaptopIDTbx.Size = New System.Drawing.Size(217, 31)
        Me.LaptopIDTbx.TabIndex = 59
        Me.LaptopIDTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(377, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ID Laptop"
        '
        'Laptop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LaptopIDTbx)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DgvLaptop)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ColorTbx)
        Me.Controls.Add(Me.AvailableCbx)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PriceTbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BrandCbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ModelTbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SpekTbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SnumberTbx)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laptop"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laptop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvLaptop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents SnumberTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SpekTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents ModelTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents BrandCbx As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PriceTbx As ns1.BunifuMetroTextbox
    Friend WithEvents AvailableCbx As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ColorTbx As ns1.BunifuMetroTextbox
    Friend WithEvents DgvLaptop As ns1.BunifuCustomDataGrid
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LaptopIDTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
End Class
