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
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelkode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labeluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelwaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapPersediaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.labelkode, Me.labeluser, Me.ToolStripStatusLabel1, Me.labelwaktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(90, 21)
        Me.ToolStripStatusLabel3.Text = "Pengguna :"
        '
        'labelkode
        '
        Me.labelkode.Name = "labelkode"
        Me.labelkode.Size = New System.Drawing.Size(16, 21)
        Me.labelkode.Text = "-"
        Me.labelkode.Visible = False
        '
        'labeluser
        '
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(16, 21)
        Me.labeluser.Text = "-"
        Me.labeluser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(90, 21)
        Me.ToolStripStatusLabel1.Text = "    Tanggal :"
        '
        'labelwaktu
        '
        Me.labelwaktu.Name = "labelwaktu"
        Me.labelwaktu.Size = New System.Drawing.Size(16, 21)
        Me.labelwaktu.Text = "-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkunToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(53, 23)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BahanToolStripMenuItem, Me.PeggunaToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'BahanToolStripMenuItem
        '
        Me.BahanToolStripMenuItem.Name = "BahanToolStripMenuItem"
        Me.BahanToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.BahanToolStripMenuItem.Text = "Bahan"
        '
        'PeggunaToolStripMenuItem
        '
        Me.PeggunaToolStripMenuItem.Name = "PeggunaToolStripMenuItem"
        Me.PeggunaToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.PeggunaToolStripMenuItem.Text = "Pengguna"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 23)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapPenjualanToolStripMenuItem, Me.LapPersediaanBarangToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LapPenjualanToolStripMenuItem
        '
        Me.LapPenjualanToolStripMenuItem.Name = "LapPenjualanToolStripMenuItem"
        Me.LapPenjualanToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.LapPenjualanToolStripMenuItem.Text = "Lap. Penjualan"
        '
        'LapPersediaanBarangToolStripMenuItem
        '
        Me.LapPersediaanBarangToolStripMenuItem.Name = "LapPersediaanBarangToolStripMenuItem"
        Me.LapPersediaanBarangToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.LapPersediaanBarangToolStripMenuItem.Text = "Lap. Stok Bahan"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
    Friend WithEvents PeggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents labelkode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LapPersediaanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
