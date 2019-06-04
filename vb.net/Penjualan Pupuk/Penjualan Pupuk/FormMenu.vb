Public Class FormMenu
    
    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem1.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem1.Click
        FormSupplier.ShowDialog()
    End Sub

    Private Sub TambahAkunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        formuser.ShowDialog()
    End Sub
    Sub awal()
        FileMasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
    End Sub
    Sub akhir()
        FileMasterToolStripMenuItem.Enabled = True
        TransaksiToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = False
    End Sub
    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FrmLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan keluar dari program?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call awal()
            stt_namalogin.Visible = False
            LoginToolStripMenuItem.Enabled = True
        Else
        End If
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        formpelanggan.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FormPembelian.ShowDialog()
    End Sub

    Private Sub PenjualanPribadiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanPribadiToolStripMenuItem.Click
        FormPenjualanpribadi.ShowDialog()
    End Sub

    Private Sub PelunasanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelunasanToolStripMenuItem.Click
        FormPelunasan.ShowDialog()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormCtkLapJualBeli.ShowDialog()
    End Sub
    Private Sub LaporanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanBarangToolStripMenuItem.Click
        FormLapBarang.ShowDialog()
    End Sub

    Private Sub TrendPenjualanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrendPenjualanBarangToolStripMenuItem.Click
        FormTBrg.ShowDialog()
    End Sub

    Private Sub TrendPembelianBrangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrendPembelianBrangToolStripMenuItem.Click
        FormTPel.ShowDialog()
    End Sub

    Private Sub TrendSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrendSupplierToolStripMenuItem.Click
        FormTSupp.ShowDialog()
    End Sub

    Private Sub PerbandinganHargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerbandinganHargaToolStripMenuItem.Click
        FormBandingHarga.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class