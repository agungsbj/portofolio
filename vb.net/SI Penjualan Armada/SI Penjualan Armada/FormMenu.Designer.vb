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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelwaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelkode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labeluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapPersediaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OrderBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.labelwaktu, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.labelkode, Me.labeluser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 42)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(126, 37)
        Me.ToolStripStatusLabel1.Text = "Tanggal :"
        '
        'labelwaktu
        '
        Me.labelwaktu.Name = "labelwaktu"
        Me.labelwaktu.Size = New System.Drawing.Size(28, 37)
        Me.labelwaktu.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(122, 37)
        Me.ToolStripStatusLabel2.Text = "               "
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(83, 37)
        Me.ToolStripStatusLabel3.Text = "User :"
        '
        'labelkode
        '
        Me.labelkode.Name = "labelkode"
        Me.labelkode.Size = New System.Drawing.Size(28, 37)
        Me.labelkode.Text = "-"
        '
        'labeluser
        '
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(28, 37)
        Me.labeluser.Text = "-"
        Me.labeluser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkunToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 45)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(93, 41)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(181, 42)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(181, 42)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.PemasokToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(178, 41)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(214, 42)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(214, 42)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(214, 42)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderBarangToolStripMenuItem, Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(141, 41)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(257, 42)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(257, 42)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapPembelianToolStripMenuItem, Me.LapPenjualanToolStripMenuItem, Me.LapPersediaanBarangToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(128, 41)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LapPembelianToolStripMenuItem
        '
        Me.LapPembelianToolStripMenuItem.Name = "LapPembelianToolStripMenuItem"
        Me.LapPembelianToolStripMenuItem.Size = New System.Drawing.Size(376, 42)
        Me.LapPembelianToolStripMenuItem.Text = "Lap. Pembelian"
        '
        'LapPenjualanToolStripMenuItem
        '
        Me.LapPenjualanToolStripMenuItem.Name = "LapPenjualanToolStripMenuItem"
        Me.LapPenjualanToolStripMenuItem.Size = New System.Drawing.Size(376, 42)
        Me.LapPenjualanToolStripMenuItem.Text = "Lap. Penjualan"
        '
        'LapPersediaanBarangToolStripMenuItem
        '
        Me.LapPersediaanBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem})
        Me.LapPersediaanBarangToolStripMenuItem.Name = "LapPersediaanBarangToolStripMenuItem"
        Me.LapPersediaanBarangToolStripMenuItem.Size = New System.Drawing.Size(376, 42)
        Me.LapPersediaanBarangToolStripMenuItem.Text = "Lap. Persediaan Barang"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(268, 42)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(268, 42)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'OrderBarangToolStripMenuItem
        '
        Me.OrderBarangToolStripMenuItem.Name = "OrderBarangToolStripMenuItem"
        Me.OrderBarangToolStripMenuItem.Size = New System.Drawing.Size(257, 42)
        Me.OrderBarangToolStripMenuItem.Text = "Order Barang"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 535)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelwaktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labeluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents labelkode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapPersediaanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
