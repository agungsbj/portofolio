Public Class FormMenu

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub PemasokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemasokToolStripMenuItem.Click
        FormPemasok.ShowDialog()
    End Sub
    Sub awal()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterDataToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        Me.ControlBox = True
        labeluser.Text = "-"
        labelkode.Text = "-"
    End Sub
    Sub akhir()
        LoginToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = True
    End Sub
    Sub kasir()
        MasterDataToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = True
        PembelianToolStripMenuItem.Visible = False
        PenjualanToolStripMenuItem.Visible = True
        OrderBarangToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = True
        LapPembelianToolStripMenuItem.Visible = False
        LapPenjualanToolStripMenuItem.Visible = True
        LapPersediaanBarangToolStripMenuItem.Visible = True
    End Sub
    Sub gudang()
        MasterDataToolStripMenuItem.Visible = True
        KaryawanToolStripMenuItem.Visible = False
        PemasokToolStripMenuItem.Visible = True
        BarangToolStripMenuItem.Visible = True
        TransaksiToolStripMenuItem.Visible = True
        PembelianToolStripMenuItem.Visible = True
        PenjualanToolStripMenuItem.Visible = False
        OrderBarangToolStripMenuItem.Visible = True
        LaporanToolStripMenuItem.Visible = True
        LapPembelianToolStripMenuItem.Visible = True
        LapPenjualanToolStripMenuItem.Visible = False
        LapPersediaanBarangToolStripMenuItem.Visible = True
    End Sub
    Sub admin()
        MasterDataToolStripMenuItem.Visible = True
        KaryawanToolStripMenuItem.Visible = True
        PemasokToolStripMenuItem.Visible = True
        BarangToolStripMenuItem.Visible = True
        TransaksiToolStripMenuItem.Visible = True
        PembelianToolStripMenuItem.Visible = True
        PenjualanToolStripMenuItem.Visible = True
        OrderBarangToolStripMenuItem.Visible = True
        LaporanToolStripMenuItem.Visible = True
        LapPembelianToolStripMenuItem.Visible = True
        LapPenjualanToolStripMenuItem.Visible = True
        LapPersediaanBarangToolStripMenuItem.Visible = True
    End Sub
    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labelwaktu.Text = Format(Now, "dddd, dd - MMMM - yyyy | HH:mm:ss")
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pesan As String
        pesan = MsgBox("Anda akan logout ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
            awal()
            Else
        End If
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FormPembelian.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.ShowDialog()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        FormKaryawan.ShowDialog()
    End Sub

    Private Sub LapPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapPembelianToolStripMenuItem.Click
        FormLapBeli.CrystalReportViewer1.RefreshReport()
        FormLapBeli.ShowDialog()
    End Sub

    Private Sub LapPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapPenjualanToolStripMenuItem.Click
        FormLapJual.CrystalReportViewer1.RefreshReport()
        FormLapJual.ShowDialog()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        FormLapBrgKeluar.CrystalReportViewer1.RefreshReport()
        FormLapBrgKeluar.ShowDialog()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangMasukToolStripMenuItem.Click
        FormLapBrgMasuk.CrystalReportViewer1.RefreshReport()
        FormLapBrgMasuk.ShowDialog()
    End Sub

    Private Sub OrderBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderBarangToolStripMenuItem.Click
        FormOrder.ShowDialog()
    End Sub
End Class