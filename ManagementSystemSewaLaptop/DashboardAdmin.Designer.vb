<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdmin))
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLaptopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsernameLb = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DashboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLaptopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 53)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 53)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 53)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'DataLaptopToolStripMenuItem
        '
        Me.DataLaptopToolStripMenuItem.Name = "DataLaptopToolStripMenuItem"
        Me.DataLaptopToolStripMenuItem.Size = New System.Drawing.Size(83, 53)
        Me.DataLaptopToolStripMenuItem.Text = "Data Laptop"
        '
        'TransactionRentToolStripMenuItem
        '
        Me.TransactionRentToolStripMenuItem.Name = "TransactionRentToolStripMenuItem"
        Me.TransactionRentToolStripMenuItem.Size = New System.Drawing.Size(114, 53)
        Me.TransactionRentToolStripMenuItem.Text = "Transaction / Rent"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(54, 53)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.StaffToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DataLaptopToolStripMenuItem, Me.TransactionRentToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1386, 57)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1295, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'UsernameLb
        '
        Me.UsernameLb.AutoSize = True
        Me.UsernameLb.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLb.ForeColor = System.Drawing.Color.Black
        Me.UsernameLb.Location = New System.Drawing.Point(1191, 24)
        Me.UsernameLb.Name = "UsernameLb"
        Me.UsernameLb.Size = New System.Drawing.Size(80, 20)
        Me.UsernameLb.TabIndex = 9
        Me.UsernameLb.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1148, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem1, Me.StaffToolStripMenuItem1, Me.DataLaptopToolStripMenuItem1, Me.RentToolStripMenuItem, Me.ReturnToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 114)
        '
        'DashboardToolStripMenuItem1
        '
        Me.DashboardToolStripMenuItem1.Name = "DashboardToolStripMenuItem1"
        Me.DashboardToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DashboardToolStripMenuItem1.Text = "Dashboard"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'DataLaptopToolStripMenuItem1
        '
        Me.DataLaptopToolStripMenuItem1.Name = "DataLaptopToolStripMenuItem1"
        Me.DataLaptopToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataLaptopToolStripMenuItem1.Text = "Data Laptop"
        '
        'RentToolStripMenuItem
        '
        Me.RentToolStripMenuItem.Name = "RentToolStripMenuItem"
        Me.RentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RentToolStripMenuItem.Text = "Rent"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'DashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.UsernameLb)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataLaptopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionRentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameLb As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DashboardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataLaptopToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem1 As ToolStripMenuItem
End Class
