Public Class FormMenu

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BahanToolStripMenuItem.Click
        FormBahan.ShowDialog()
    End Sub
    Sub awal()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterDataToolStripMenuItem.Visible = False
        ProduksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        Me.ControlBox = True
        labeluser.Text = "-"
        labelkode.Text = "-"
    End Sub
    Sub akhir()
        LoginToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = True
    End Sub
    Sub pimpinan()
        MasterDataToolStripMenuItem.Visible = False
        KaryawanToolStripMenuItem.Visible = False
        BarangToolStripMenuItem.Visible = False
        BahanToolStripMenuItem.Visible = False
        ProduksiToolStripMenuItem.Visible = False
        ProsesProduksiToolStripMenuItem.Visible = False
        HasilProduksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = True
        LapBahanToolStripMenuItem.Visible = True
        LapBarangToolStripMenuItem.Visible = True
        LapProduksiBarangToolStripMenuItem.Visible = True
    End Sub
    Sub gudang()
        MasterDataToolStripMenuItem.Visible = True
        KaryawanToolStripMenuItem.Visible = False
        BarangToolStripMenuItem.Visible = True
        BahanToolStripMenuItem.Visible = True
        ProduksiToolStripMenuItem.Visible = True
        ProsesProduksiToolStripMenuItem.Visible = True
        HasilProduksiToolStripMenuItem.Visible = True
        LaporanToolStripMenuItem.Visible = True
        LapBahanToolStripMenuItem.Visible = True
        LapBarangToolStripMenuItem.Visible = True
        LapProduksiBarangToolStripMenuItem.Visible = True
    End Sub
    Sub admin()
        MasterDataToolStripMenuItem.Visible = True
        KaryawanToolStripMenuItem.Visible = True
        BarangToolStripMenuItem.Visible = True
        BahanToolStripMenuItem.Visible = True
        ProduksiToolStripMenuItem.Visible = True
        ProsesProduksiToolStripMenuItem.Visible = True
        HasilProduksiToolStripMenuItem.Visible = True
        LaporanToolStripMenuItem.Visible = True
        LapBahanToolStripMenuItem.Visible = True
        LapBarangToolStripMenuItem.Visible = True
        LapProduksiBarangToolStripMenuItem.Visible = True
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
    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        FormKaryawan.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub ProsesProduksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesProduksiToolStripMenuItem.Click
        FormProduksi.ShowDialog()
    End Sub

    Private Sub HasilProduksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HasilProduksiToolStripMenuItem.Click
        FormHasil.ShowDialog()
    End Sub

    Private Sub LapBahanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapBahanToolStripMenuItem.Click
        FormLapBahan.ShowDialog()
    End Sub

    Private Sub LapBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapBarangToolStripMenuItem.Click
        FormLapBarang.ShowDialog()
    End Sub

    Private Sub LapProduksiBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapProduksiBarangToolStripMenuItem.Click
        FormLapProduksi.ShowDialog()
    End Sub
End Class