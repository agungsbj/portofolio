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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
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
        Me.BahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesProduksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilProduksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapBahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapProduksiBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.labelwaktu, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.labelkode, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.labeluser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 505)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 30)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 25)
        '
        'labelwaktu
        '
        Me.labelwaktu.Name = "labelwaktu"
        Me.labelwaktu.Size = New System.Drawing.Size(19, 25)
        Me.labelwaktu.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(102, 25)
        Me.ToolStripStatusLabel2.Text = "               "
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(126, 25)
        Me.ToolStripStatusLabel3.Text = "Jenis User :"
        '
        'labelkode
        '
        Me.labelkode.Name = "labelkode"
        Me.labelkode.Size = New System.Drawing.Size(19, 25)
        Me.labelkode.Text = "-"
        '
        'labeluser
        '
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(19, 25)
        Me.labeluser.Text = "-"
        Me.labeluser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkunToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.ProduksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(150, 30)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(150, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BahanToolStripMenuItem, Me.BarangToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(141, 29)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'BahanToolStripMenuItem
        '
        Me.BahanToolStripMenuItem.Name = "BahanToolStripMenuItem"
        Me.BahanToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.BahanToolStripMenuItem.Text = "Bahan"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'ProduksiToolStripMenuItem
        '
        Me.ProduksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesProduksiToolStripMenuItem, Me.HasilProduksiToolStripMenuItem})
        Me.ProduksiToolStripMenuItem.Name = "ProduksiToolStripMenuItem"
        Me.ProduksiToolStripMenuItem.Size = New System.Drawing.Size(108, 29)
        Me.ProduksiToolStripMenuItem.Text = "Produksi"
        '
        'ProsesProduksiToolStripMenuItem
        '
        Me.ProsesProduksiToolStripMenuItem.Name = "ProsesProduksiToolStripMenuItem"
        Me.ProsesProduksiToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.ProsesProduksiToolStripMenuItem.Text = "Proses Produksi"
        '
        'HasilProduksiToolStripMenuItem
        '
        Me.HasilProduksiToolStripMenuItem.Name = "HasilProduksiToolStripMenuItem"
        Me.HasilProduksiToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.HasilProduksiToolStripMenuItem.Text = "Hasil Produksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapBahanToolStripMenuItem, Me.LapBarangToolStripMenuItem, Me.LapProduksiBarangToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LapBahanToolStripMenuItem
        '
        Me.LapBahanToolStripMenuItem.Name = "LapBahanToolStripMenuItem"
        Me.LapBahanToolStripMenuItem.Size = New System.Drawing.Size(316, 30)
        Me.LapBahanToolStripMenuItem.Text = "Lap. Persediaan Bahan"
        '
        'LapBarangToolStripMenuItem
        '
        Me.LapBarangToolStripMenuItem.Name = "LapBarangToolStripMenuItem"
        Me.LapBarangToolStripMenuItem.Size = New System.Drawing.Size(316, 30)
        Me.LapBarangToolStripMenuItem.Text = "Lap. Persediaan Barang"
        '
        'LapProduksiBarangToolStripMenuItem
        '
        Me.LapProduksiBarangToolStripMenuItem.Name = "LapProduksiBarangToolStripMenuItem"
        Me.LapProduksiBarangToolStripMenuItem.Size = New System.Drawing.Size(316, 30)
        Me.LapProduksiBarangToolStripMenuItem.Text = "Lap. Produksi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(80, 25)
        Me.ToolStripStatusLabel4.Text = "Nama :"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(162, 25)
        Me.ToolStripStatusLabel5.Text = "                         "
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
    Friend WithEvents BahanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProduksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapBahanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents labelkode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapProduksiBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesProduksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HasilProduksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
End Class
