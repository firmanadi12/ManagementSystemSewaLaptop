<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Returns
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Returns))
        Me.InvoiceTbx = New ns1.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DelayTbx = New ns1.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustNameTbx = New ns1.BunifuMetroTextbox()
        Me.ReturnDateTbx = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgvRent = New ns1.BunifuCustomDataGrid()
        Me.DgvReturn = New ns1.BunifuCustomDataGrid()
        Me.FineFeeTbx = New ns1.BunifuMetroTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RetIdTbx = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTbx = New ns1.BunifuMetroTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SnumTbx = New ns1.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceTbx
        '
        Me.InvoiceTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.InvoiceTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InvoiceTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.InvoiceTbx.BorderThickness = 3
        Me.InvoiceTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InvoiceTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.InvoiceTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InvoiceTbx.isPassword = False
        Me.InvoiceTbx.Location = New System.Drawing.Point(68, 218)
        Me.InvoiceTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.InvoiceTbx.Name = "InvoiceTbx"
        Me.InvoiceTbx.Size = New System.Drawing.Size(263, 31)
        Me.InvoiceTbx.TabIndex = 73
        Me.InvoiceTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(77, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = " Delay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(418, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Return Date"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(496, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Laptop Rental Management System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(76, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 21)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Customer Name"
        '
        'DelayTbx
        '
        Me.DelayTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.DelayTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DelayTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.DelayTbx.BorderThickness = 3
        Me.DelayTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DelayTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DelayTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DelayTbx.isPassword = False
        Me.DelayTbx.Location = New System.Drawing.Point(71, 477)
        Me.DelayTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.DelayTbx.Name = "DelayTbx"
        Me.DelayTbx.Size = New System.Drawing.Size(260, 31)
        Me.DelayTbx.TabIndex = 63
        Me.DelayTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1389, 44)
        Me.Panel1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(73, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Invoice ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(12, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 30)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Return"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 10)
        Me.Panel2.TabIndex = 75
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
        Me.CustNameTbx.Location = New System.Drawing.Point(71, 352)
        Me.CustNameTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.CustNameTbx.Name = "CustNameTbx"
        Me.CustNameTbx.Size = New System.Drawing.Size(260, 31)
        Me.CustNameTbx.TabIndex = 76
        Me.CustNameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ReturnDateTbx
        '
        Me.ReturnDateTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.ReturnDateTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReturnDateTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.ReturnDateTbx.BorderThickness = 3
        Me.ReturnDateTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReturnDateTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ReturnDateTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReturnDateTbx.isPassword = False
        Me.ReturnDateTbx.Location = New System.Drawing.Point(71, 413)
        Me.ReturnDateTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.ReturnDateTbx.Name = "ReturnDateTbx"
        Me.ReturnDateTbx.Size = New System.Drawing.Size(260, 31)
        Me.ReturnDateTbx.TabIndex = 79
        Me.ReturnDateTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(76, 527)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Fine Fee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(409, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 21)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Rentals List"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(409, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Returns List"
        '
        'DgvRent
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvRent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRent.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvRent.ColumnHeadersHeight = 35
        Me.DgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvRent.DoubleBuffered = True
        Me.DgvRent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvRent.EnableHeadersVisualStyles = False
        Me.DgvRent.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvRent.HeaderForeColor = System.Drawing.Color.White
        Me.DgvRent.Location = New System.Drawing.Point(413, 144)
        Me.DgvRent.Name = "DgvRent"
        Me.DgvRent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRent.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DgvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvRent.Size = New System.Drawing.Size(924, 187)
        Me.DgvRent.TabIndex = 83
        '
        'DgvReturn
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvReturn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DgvReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReturn.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvReturn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DgvReturn.ColumnHeadersHeight = 35
        Me.DgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvReturn.DoubleBuffered = True
        Me.DgvReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvReturn.EnableHeadersVisualStyles = False
        Me.DgvReturn.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvReturn.HeaderForeColor = System.Drawing.Color.White
        Me.DgvReturn.Location = New System.Drawing.Point(413, 383)
        Me.DgvReturn.Name = "DgvReturn"
        Me.DgvReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReturn.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvReturn.Size = New System.Drawing.Size(924, 187)
        Me.DgvReturn.TabIndex = 84
        '
        'FineFeeTbx
        '
        Me.FineFeeTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.FineFeeTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FineFeeTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.FineFeeTbx.BorderThickness = 3
        Me.FineFeeTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FineFeeTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FineFeeTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FineFeeTbx.isPassword = False
        Me.FineFeeTbx.Location = New System.Drawing.Point(71, 548)
        Me.FineFeeTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.FineFeeTbx.Name = "FineFeeTbx"
        Me.FineFeeTbx.Size = New System.Drawing.Size(263, 31)
        Me.FineFeeTbx.TabIndex = 85
        Me.FineFeeTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(68, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 33)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RetIdTbx
        '
        Me.RetIdTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.RetIdTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RetIdTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.RetIdTbx.BorderThickness = 3
        Me.RetIdTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RetIdTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.RetIdTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RetIdTbx.isPassword = False
        Me.RetIdTbx.Location = New System.Drawing.Point(68, 158)
        Me.RetIdTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.RetIdTbx.Name = "RetIdTbx"
        Me.RetIdTbx.Size = New System.Drawing.Size(263, 31)
        Me.RetIdTbx.TabIndex = 87
        Me.RetIdTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(74, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Return ID"
        '
        'SearchTbx
        '
        Me.SearchTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.SearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.SearchTbx.BorderThickness = 3
        Me.SearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SearchTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchTbx.isPassword = False
        Me.SearchTbx.Location = New System.Drawing.Point(1103, 103)
        Me.SearchTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchTbx.Name = "SearchTbx"
        Me.SearchTbx.Size = New System.Drawing.Size(190, 25)
        Me.SearchTbx.TabIndex = 89
        Me.SearchTbx.Tag = ""
        Me.SearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1300, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'SnumTbx
        '
        Me.SnumTbx.BorderColorFocused = System.Drawing.Color.Blue
        Me.SnumTbx.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SnumTbx.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.SnumTbx.BorderThickness = 3
        Me.SnumTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SnumTbx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SnumTbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SnumTbx.isPassword = False
        Me.SnumTbx.Location = New System.Drawing.Point(69, 284)
        Me.SnumTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.SnumTbx.Name = "SnumTbx"
        Me.SnumTbx.Size = New System.Drawing.Size(263, 31)
        Me.SnumTbx.TabIndex = 92
        Me.SnumTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(74, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 21)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Serial Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(76, 392)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 21)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Date Return"
        '
        'Returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 720)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SnumTbx)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SearchTbx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RetIdTbx)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FineFeeTbx)
        Me.Controls.Add(Me.DgvReturn)
        Me.Controls.Add(Me.DgvRent)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ReturnDateTbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustNameTbx)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.InvoiceTbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DelayTbx)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Returns"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Returns"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InvoiceTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DelayTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CustNameTbx As ns1.BunifuMetroTextbox
    Friend WithEvents ReturnDateTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvRent As ns1.BunifuCustomDataGrid
    Friend WithEvents DgvReturn As ns1.BunifuCustomDataGrid
    Friend WithEvents FineFeeTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents RetIdTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchTbx As ns1.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SnumTbx As ns1.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
