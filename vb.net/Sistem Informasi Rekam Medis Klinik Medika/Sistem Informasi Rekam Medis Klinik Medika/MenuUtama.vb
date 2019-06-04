Imports System.Data.OleDb
Public Class MenuUtama

    Sub login()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM pengguna WHERE username='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "' and hakakses='" & Label2.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If (dr.Read()) Then
            MsgBox("Login Sukses", MsgBoxStyle.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""

            If Label2.Text = "Admin" Then
                MenuAdmin.lblnama.Text = dr.Item(2)
                MenuAdmin.ShowDialog()
            ElseIf Label2.Text = "Bag. Pendaftaran" Then
                MenuPendaftaran.lblnama.Text = dr.Item(2)
                MenuPendaftaran.ShowDialog()
            ElseIf Label2.Text = "Bag. Rekam Medis" Then
                MenuRM.lblnama.Text = dr.Item(2)
                MenuRM.ShowDialog()
            ElseIf Label2.Text = "Bag. Apotik dan Kasir" Then
                Menukasir.lblnama.Text = dr.Item(2)
                Menukasir.ShowDialog()
            ElseIf Label2.Text = "Bag. Surat Kesehatan" Then
                SuratKet.TextBox4.Text = dr.Item(2)
                SuratKet.ShowDialog()
            End If
            Panel1.Visible = False
        Else
            MsgBox("Maaf! Username atau password yang anda masukan Salah!", MsgBoxStyle.Critical, vbOK)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Call login()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Call koneksi()
        Label3.Text = Format(Now, "dddd,  dd-MMMM-yyyy")
        Call DaftarObat.Tampilobat()
        Call DaftarObat.cek()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Panel1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button9.BackColor = Color.Firebrick
        Button8.BackColor = Color.Firebrick
        Panel2.BackColor = Color.Firebrick
        Label2.Text = Button3.Text
        Panel1.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button9.BackColor = Color.LimeGreen
        Button8.BackColor = Color.LimeGreen
        Panel2.BackColor = Color.LimeGreen
        Label2.Text = Button6.Text
        Panel1.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button9.BackColor = Color.IndianRed
        Button8.BackColor = Color.IndianRed
        Panel2.BackColor = Color.IndianRed
        Label2.Text = Button4.Text
        Panel1.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button9.BackColor = Color.MidnightBlue
        Button8.BackColor = Color.MidnightBlue
        Panel2.BackColor = Color.MidnightBlue
        Label2.Text = Button5.Text
        Panel1.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button9.BackColor = Color.LightSkyBlue
        Button8.BackColor = Color.LightSkyBlue
        Panel2.BackColor = Color.LightSkyBlue
        Label2.Text = Button7.Text
        Panel1.Visible = True
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel1.Visible = False
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            login()
        End If
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Location = New Point(98, 133)
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Location = New Point(65, 133)
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Location = New Point(98, 298)
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove
        Button5.Location = New Point(65, 298)
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.Location = New Point(98, 463)
    End Sub

    Private Sub Button6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseMove
        Button6.Location = New Point(65, 463)
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Location = New Point(568, 133)
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Button4.Location = New Point(597, 133)
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.Location = New Point(568, 463)
    End Sub

    Private Sub Button7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove
        Button7.Location = New Point(597, 463)
    End Sub

End Class