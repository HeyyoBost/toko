<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PejualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HARIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BULANAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.namauser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalpejualanharian = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalh = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalb0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1350, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(1272, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporaToolStripMenuItem, Me.AccoutToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 100)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataSupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.PejualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Pembelian"
        '
        'PejualanToolStripMenuItem
        '
        Me.PejualanToolStripMenuItem.Name = "PejualanToolStripMenuItem"
        Me.PejualanToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PejualanToolStripMenuItem.Text = "Pejualan"
        '
        'LaporaToolStripMenuItem
        '
        Me.LaporaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HARIANToolStripMenuItem, Me.BULANAToolStripMenuItem})
        Me.LaporaToolStripMenuItem.Name = "LaporaToolStripMenuItem"
        Me.LaporaToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.LaporaToolStripMenuItem.Text = "Laporan"
        '
        'HARIANToolStripMenuItem
        '
        Me.HARIANToolStripMenuItem.Name = "HARIANToolStripMenuItem"
        Me.HARIANToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.HARIANToolStripMenuItem.Text = "HARIAN"
        '
        'BULANAToolStripMenuItem
        '
        Me.BULANAToolStripMenuItem.Name = "BULANAToolStripMenuItem"
        Me.BULANAToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BULANAToolStripMenuItem.Text = "BULANA"
        '
        'AccoutToolStripMenuItem
        '
        Me.AccoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagementUserToolStripMenuItem})
        Me.AccoutToolStripMenuItem.Name = "AccoutToolStripMenuItem"
        Me.AccoutToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.AccoutToolStripMenuItem.Text = "Account"
        '
        'ManagementUserToolStripMenuItem
        '
        Me.ManagementUserToolStripMenuItem.Name = "ManagementUserToolStripMenuItem"
        Me.ManagementUserToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ManagementUserToolStripMenuItem.Text = "Management User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ExitToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.namauser, Me.ToolStripStatusLabel3, Me.totalpejualanharian, Me.totalh, Me.ToolStripStatusLabel4, Me.totalb, Me.totalb0, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel1.Text = "Selamat Datang :"
        '
        'namauser
        '
        Me.namauser.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namauser.Name = "namauser"
        Me.namauser.Size = New System.Drawing.Size(11, 17)
        Me.namauser.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'totalpejualanharian
        '
        Me.totalpejualanharian.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpejualanharian.Name = "totalpejualanharian"
        Me.totalpejualanharian.Size = New System.Drawing.Size(122, 17)
        Me.totalpejualanharian.Text = "Total Penjualan Harian :"
        '
        'totalh
        '
        Me.totalh.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalh.Name = "totalh"
        Me.totalh.Size = New System.Drawing.Size(13, 17)
        Me.totalh.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'totalb
        '
        Me.totalb.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalb.Name = "totalb"
        Me.totalb.Size = New System.Drawing.Size(129, 17)
        Me.totalb.Text = "Total Penjualan Bulanan :"
        '
        'totalb0
        '
        Me.totalb0.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalb0.Name = "totalb0"
        Me.totalb0.Size = New System.Drawing.Size(13, 17)
        Me.totalb0.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'frmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.IsMdiContainer = True
        Me.Name = "frmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PejualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagementUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents namauser As ToolStripStatusLabel
    Friend WithEvents totalpejualanharian As ToolStripStatusLabel
    Friend WithEvents totalh As ToolStripStatusLabel
    Friend WithEvents totalb As ToolStripStatusLabel
    Friend WithEvents totalb0 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents HARIANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BULANAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
