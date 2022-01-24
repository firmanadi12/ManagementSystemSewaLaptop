<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RentedCountLb = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ReadyLaptoCountLb = New System.Windows.Forms.Label()
        Me.AllLaptopCountLb = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CustomersCountLb = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TransCountLb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RevenueLb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DgvDasboard = New ns1.BunifuCustomDataGrid()
        Me.ListCbx = New System.Windows.Forms.ComboBox()
        Me.TitelListLb = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDasboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(509, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Laptop Rental Management System"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1395, 58)
        Me.Panel1.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Controls.Add(Me.RentedCountLb)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.ReadyLaptoCountLb)
        Me.Panel3.Controls.Add(Me.AllLaptopCountLb)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(1007, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 168)
        Me.Panel3.TabIndex = 35
        '
        'RentedCountLb
        '
        Me.RentedCountLb.AutoSize = True
        Me.RentedCountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentedCountLb.ForeColor = System.Drawing.Color.White
        Me.RentedCountLb.Location = New System.Drawing.Point(269, 76)
        Me.RentedCountLb.Name = "RentedCountLb"
        Me.RentedCountLb.Size = New System.Drawing.Size(36, 37)
        Me.RentedCountLb.TabIndex = 39
        Me.RentedCountLb.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(254, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Rented"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(174, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Ready"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(113, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "All"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'ReadyLaptoCountLb
        '
        Me.ReadyLaptoCountLb.AutoSize = True
        Me.ReadyLaptoCountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadyLaptoCountLb.ForeColor = System.Drawing.Color.White
        Me.ReadyLaptoCountLb.Location = New System.Drawing.Point(186, 76)
        Me.ReadyLaptoCountLb.Name = "ReadyLaptoCountLb"
        Me.ReadyLaptoCountLb.Size = New System.Drawing.Size(36, 37)
        Me.ReadyLaptoCountLb.TabIndex = 35
        Me.ReadyLaptoCountLb.Text = "0"
        '
        'AllLaptopCountLb
        '
        Me.AllLaptopCountLb.AutoSize = True
        Me.AllLaptopCountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllLaptopCountLb.ForeColor = System.Drawing.Color.White
        Me.AllLaptopCountLb.Location = New System.Drawing.Point(110, 76)
        Me.AllLaptopCountLb.Name = "AllLaptopCountLb"
        Me.AllLaptopCountLb.Size = New System.Drawing.Size(36, 37)
        Me.AllLaptopCountLb.TabIndex = 34
        Me.AllLaptopCountLb.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(169, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Laptop"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Controls.Add(Me.CustomersCountLb)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Location = New System.Drawing.Point(735, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(244, 168)
        Me.Panel4.TabIndex = 36
        '
        'CustomersCountLb
        '
        Me.CustomersCountLb.AutoSize = True
        Me.CustomersCountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersCountLb.ForeColor = System.Drawing.Color.White
        Me.CustomersCountLb.Location = New System.Drawing.Point(123, 68)
        Me.CustomersCountLb.Name = "CustomersCountLb"
        Me.CustomersCountLb.Size = New System.Drawing.Size(36, 37)
        Me.CustomersCountLb.TabIndex = 34
        Me.CustomersCountLb.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(94, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Customers"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.TransCountLb)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Location = New System.Drawing.Point(461, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 168)
        Me.Panel5.TabIndex = 37
        '
        'TransCountLb
        '
        Me.TransCountLb.AutoSize = True
        Me.TransCountLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransCountLb.ForeColor = System.Drawing.Color.White
        Me.TransCountLb.Location = New System.Drawing.Point(123, 68)
        Me.TransCountLb.Name = "TransCountLb"
        Me.TransCountLb.Size = New System.Drawing.Size(36, 37)
        Me.TransCountLb.TabIndex = 34
        Me.TransCountLb.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(88, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Transaction"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(19, 63)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Controls.Add(Me.RevenueLb)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.PictureBox5)
        Me.Panel6.Location = New System.Drawing.Point(35, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(402, 168)
        Me.Panel6.TabIndex = 38
        '
        'RevenueLb
        '
        Me.RevenueLb.AutoSize = True
        Me.RevenueLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevenueLb.ForeColor = System.Drawing.Color.White
        Me.RevenueLb.Location = New System.Drawing.Point(90, 68)
        Me.RevenueLb.Name = "RevenueLb"
        Me.RevenueLb.Size = New System.Drawing.Size(36, 37)
        Me.RevenueLb.TabIndex = 34
        Me.RevenueLb.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(163, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Revenue"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(19, 63)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'DgvDasboard
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvDasboard.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDasboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDasboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvDasboard.BackgroundColor = System.Drawing.Color.White
        Me.DgvDasboard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDasboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDasboard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDasboard.ColumnHeadersHeight = 35
        Me.DgvDasboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDasboard.DoubleBuffered = True
        Me.DgvDasboard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDasboard.EnableHeadersVisualStyles = False
        Me.DgvDasboard.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvDasboard.HeaderForeColor = System.Drawing.Color.White
        Me.DgvDasboard.Location = New System.Drawing.Point(35, 370)
        Me.DgvDasboard.Name = "DgvDasboard"
        Me.DgvDasboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDasboard.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDasboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvDasboard.Size = New System.Drawing.Size(1299, 276)
        Me.DgvDasboard.TabIndex = 64
        Me.DgvDasboard.TabStop = False
        '
        'ListCbx
        '
        Me.ListCbx.BackColor = System.Drawing.SystemColors.Control
        Me.ListCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListCbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListCbx.FormattingEnabled = True
        Me.ListCbx.Items.AddRange(New Object() {"Data Transaksi", "Data Customer", "Data Laptop", "Data Return"})
        Me.ListCbx.Location = New System.Drawing.Point(1184, 327)
        Me.ListCbx.Name = "ListCbx"
        Me.ListCbx.Size = New System.Drawing.Size(150, 26)
        Me.ListCbx.TabIndex = 65
        '
        'TitelListLb
        '
        Me.TitelListLb.AutoSize = True
        Me.TitelListLb.BackColor = System.Drawing.Color.Transparent
        Me.TitelListLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitelListLb.ForeColor = System.Drawing.Color.Black
        Me.TitelListLb.Location = New System.Drawing.Point(34, 327)
        Me.TitelListLb.Name = "TitelListLb"
        Me.TitelListLb.Size = New System.Drawing.Size(66, 29)
        Me.TitelListLb.TabIndex = 35
        Me.TitelListLb.Text = "Titel"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 720)
        Me.Controls.Add(Me.TitelListLb)
        Me.Controls.Add(Me.ListCbx)
        Me.Controls.Add(Me.DgvDasboard)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDasboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RentedCountLb As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ReadyLaptoCountLb As Label
    Friend WithEvents AllLaptopCountLb As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CustomersCountLb As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TransCountLb As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RevenueLb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DgvDasboard As ns1.BunifuCustomDataGrid
    Friend WithEvents ListCbx As ComboBox
    Friend WithEvents TitelListLb As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
