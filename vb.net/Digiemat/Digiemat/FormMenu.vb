Public Class FormMenu

    Sub awal()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterDataToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        Me.ControlBox = True
        labeluser.Text = "-"
        labelkode.Text = "-"
    End Sub
    Sub akhir()
        LoginToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = True
    End Sub
    Sub kasir()
        MasterDataToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
        LapPenjualanToolStripMenuItem.Enabled = True
        LapPersediaanBarangToolStripMenuItem.Enabled = True
    End Sub
    Sub admin()
        MasterDataToolStripMenuItem.Enabled = True
        TransaksiToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
    End Sub
    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labelwaktu.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pesan As String
        pesan = MsgBox("Apakah anda yakin akan logout ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            awal()
        Else
        End If
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub BahanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BahanToolStripMenuItem.Click
        FormBahan.ShowDialog()
    End Sub

    Private Sub PeggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeggunaToolStripMenuItem.Click
        FormPengguna.ShowDialog()
    End Sub

    Private Sub LapPersediaanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapPersediaanBarangToolStripMenuItem.Click
        FormLapBahan.CrystalReportViewer1.RefreshReport()
        FormLapBahan.ShowDialog()
    End Sub

    Private Sub LapPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapPenjualanToolStripMenuItem.Click
        FormLapJual.CrystalReportViewer1.RefreshReport()
        FormLapJual.ShowDialog()
    End Sub
End Class