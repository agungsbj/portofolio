Public Class MenuBaru
    Sub awal()
        p1.Visible = False
        p2.Visible = False
        p3.Visible = False
        p4.Visible = False
        p5.Visible = False
        p6.Visible = False
        p7.Visible = False
        p8.Visible = False
        p9.Visible = False
        Label14.Visible = False
    End Sub
    Sub tampil()
        PictureBox13.Image = Nothing
        Label14.Text = ""
        Label14.Visible = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label13.Text = Format(Now, "dddd, dd MMMM yyyy")
        Label15.Text = Format(Now, "HH : mm : ss")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If p1.Visible = False Then
            p1.Visible = True
            p2.Visible = False
            p3.Visible = False
            p4.Visible = False
            p5.Visible = False
            p6.Visible = False
            p7.Visible = False
            p8.Visible = False
            p9.Visible = False
        Else
            p1.Visible = False
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox13.Image = PictureBox1.Image
        Label14.Text = "Account"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1.Click
        Me.Dispose()
        FormLogin.PictureBox2.Visible = False
        FormLogin.Panel2.Visible = False
        FormLogin.TextBox1.Focus()
        FormLogin.Show()
        Call FormLogin.awal()
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p1.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseMove
        PictureBox13.Image = p1.Image
        Label14.Text = "Logout"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If p2.Visible = False And p3.Visible = False Then
            p2.Visible = True
            p3.Visible = True
            p1.Visible = False
            p4.Visible = False
            p5.Visible = False
            p6.Visible = False
            p7.Visible = False
            p8.Visible = False
            p9.Visible = False
        Else
            p2.Visible = False
            p3.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox13.Image = PictureBox2.Image
        Label14.Text = "Master"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p2.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p2.MouseMove
        PictureBox13.Image = p2.Image
        Label14.Text = "Input Data Paket"
        Label14.Visible = True
        p2.Focus()
    End Sub
    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p3.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p3.MouseMove
        PictureBox13.Image = p3.Image
        Label14.Text = "Input Data Instruktur"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox13.Image = PictureBox6.Image
        Label14.Text = "Transaksi"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p5.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p5.MouseMove
        PictureBox13.Image = p5.Image
        Label14.Text = "Pendaftaran Siswa"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p4.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p4.MouseMove
        PictureBox13.Image = p4.Image
        Label14.Text = "Cetak Sertifikat"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseMove
        PictureBox13.Image = PictureBox9.Image
        Label14.Text = "Laporan"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p8.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p8.MouseMove
        PictureBox13.Image = p8.Image
        Label14.Text = "Laporan Siswa"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p7.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p7.MouseMove
        PictureBox13.Image = p7.Image
        Label14.Text = "Laporan Keuangan"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox12.MouseMove
        PictureBox13.Image = PictureBox12.Image
        Label14.Text = "About"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p6.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p6.MouseMove
        PictureBox13.Image = p6.Image
        Label14.Text = "Transaksi Pembayaran"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If p4.Visible = False And p5.Visible = False And p6.Visible = False and p9.Visible = False Then
            p4.Visible = True
            p5.Visible = True
            p6.Visible = True
            p9.Visible = True
            p1.Visible = False
            p2.Visible = False
            p3.Visible = False
            p7.Visible = False
            p8.Visible = False
        Else
            p4.Visible = False
            p5.Visible = False
            p6.Visible = False
            p9.Visible = False
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If p7.Visible = False And p8.Visible = False Then
            p7.Visible = True
            p8.Visible = True
            p1.Visible = False
            p2.Visible = False
            p3.Visible = False
            p4.Visible = False
            p5.Visible = False
            p6.Visible = False
            p9.Visible = False
        Else
            p7.Visible = False
            p8.Visible = False
        End If

    End Sub

    Private Sub p2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2.Click
        frmPaket.ShowDialog()
    End Sub

    Private Sub p3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p3.Click
        frmInstruktur.ShowDialog()
    End Sub

    Private Sub p4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p4.Click
        frmcetaksertifikat.ShowDialog()
    End Sub

    Private Sub p6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p6.Click
        frmPembayaran.ShowDialog()
    End Sub

    Private Sub p5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p5.Click
        frmPendaftaran.ShowDialog()
    End Sub

    Private Sub p7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p7.Click
        frmlaporanuang.ShowDialog()
    End Sub

    Private Sub p8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p8.Click
        frmLaporansiswa.ShowDialog()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        frmTtg.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p9.Click
        FrmDataSiswa.ShowDialog()
    End Sub

    Private Sub p9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles p9.MouseLeave
        Call tampil()
    End Sub

    Private Sub p9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p9.MouseMove
        PictureBox13.Image = p9.Image
        Label14.Text = "Data Siswa"
        Label14.Visible = True
        PictureBox1.Focus()
    End Sub
End Class