<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerbandinganHargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanPribadiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelunasanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrendPenjualanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrendPembelianBrangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrendSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stt_namalogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.FileMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.TambahUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'FileMasterToolStripMenuItem
        '
        Me.FileMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem1, Me.SupplierToolStripMenuItem1, Me.PelangganToolStripMenuItem, Me.PerbandinganHargaToolStripMenuItem})
        Me.FileMasterToolStripMenuItem.Name = "FileMasterToolStripMenuItem"
        Me.FileMasterToolStripMenuItem.Size = New System.Drawing.Size(98, 25)
        Me.FileMasterToolStripMenuItem.Text = "File Master"
        '
        'BarangToolStripMenuItem1
        '
        Me.BarangToolStripMenuItem1.Name = "BarangToolStripMenuItem1"
        Me.BarangToolStripMenuItem1.Size = New System.Drawing.Size(223, 26)
        Me.BarangToolStripMenuItem1.Text = "Barang"
        '
        'SupplierToolStripMenuItem1
        '
        Me.SupplierToolStripMenuItem1.Name = "SupplierToolStripMenuItem1"
        Me.SupplierToolStripMenuItem1.Size = New System.Drawing.Size(223, 26)
        Me.SupplierToolStripMenuItem1.Text = "Supplier"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PerbandinganHargaToolStripMenuItem
        '
        Me.PerbandinganHargaToolStripMenuItem.Name = "PerbandinganHargaToolStripMenuItem"
        Me.PerbandinganHargaToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.PerbandinganHargaToolStripMenuItem.Text = "Perbandingan Harga"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem, Me.PenjualanPribadiToolStripMenuItem, Me.PelunasanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanPribadiToolStripMenuItem
        '
        Me.PenjualanPribadiToolStripMenuItem.Name = "PenjualanPribadiToolStripMenuItem"
        Me.PenjualanPribadiToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PenjualanPribadiToolStripMenuItem.Text = "Penjualan Pribadi"
        '
        'PelunasanToolStripMenuItem
        '
        Me.PelunasanToolStripMenuItem.Name = "PelunasanToolStripMenuItem"
        Me.PelunasanToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PelunasanToolStripMenuItem.Text = "Pelunasan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanBarangToolStripMenuItem, Me.TrendPenjualanBarangToolStripMenuItem, Me.TrendPembelianBrangToolStripMenuItem, Me.TrendSupplierToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(316, 26)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan dan Pembelian"
        '
        'LaporanBarangToolStripMenuItem
        '
        Me.LaporanBarangToolStripMenuItem.Name = "LaporanBarangToolStripMenuItem"
        Me.LaporanBarangToolStripMenuItem.Size = New System.Drawing.Size(316, 26)
        Me.LaporanBarangToolStripMenuItem.Text = "Laporan Barang"
        '
        'TrendPenjualanBarangToolStripMenuItem
        '
        Me.TrendPenjualanBarangToolStripMenuItem.Name = "TrendPenjualanBarangToolStripMenuItem"
        Me.TrendPenjualanBarangToolStripMenuItem.Size = New System.Drawing.Size(316, 26)
        Me.TrendPenjualanBarangToolStripMenuItem.Text = "Trend Penjualan Barang"
        '
        'TrendPembelianBrangToolStripMenuItem
        '
        Me.TrendPembelianBrangToolStripMenuItem.Name = "TrendPembelianBrangToolStripMenuItem"
        Me.TrendPembelianBrangToolStripMenuItem.Size = New System.Drawing.Size(316, 26)
        Me.TrendPembelianBrangToolStripMenuItem.Text = "Trend Pelanggan"
        '
        'TrendSupplierToolStripMenuItem
        '
        Me.TrendSupplierToolStripMenuItem.Name = "TrendSupplierToolStripMenuItem"
        Me.TrendSupplierToolStripMenuItem.Size = New System.Drawing.Size(316, 26)
        Me.TrendSupplierToolStripMenuItem.Text = "Trend Supplier"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stt_namalogin})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 396)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(639, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 21)
        Me.ToolStripStatusLabel1.Text = "ADMIN :"
        '
        'stt_namalogin
        '
        Me.stt_namalogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.stt_namalogin.Name = "stt_namalogin"
        Me.stt_namalogin.Size = New System.Drawing.Size(49, 21)
        Me.stt_namalogin.Text = "nama"
        Me.stt_namalogin.Visible = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(639, 422)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenu"
        Me.Text = "Sistem Informasi Penjualan Agro Mulia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stt_namalogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanPribadiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelunasanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrendPenjualanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrendPembelianBrangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrendSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerbandinganHargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
