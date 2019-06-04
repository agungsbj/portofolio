Imports System.Data.OleDb
Public Class Frmlogin

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        cmd = New OleDbCommand("SELECT *FROM Karyawan WHERE nama_karyawan='" & txtid.Text & _
                            "' and pass='" & txtpassword.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If (dr.Read()) Then
            MsgBox("Selamat datang")
            FormMenu.stt_namalogin.Text = dr.Item(1)
            FormMenu.stt_namalogin.Visible = True
            FormPenjualan.TextBox1.Text = dr.Item(0)
            FormPenjualan.TextBox2.Text = dr.Item(1)
            FormPembelian.TextBox2.Text = dr.Item(1)
            FormMenu.Show()
            Call FormMenu.akhir()
            Me.Hide()
            txtid.Text = ""
            txtpassword.Text = ""
            txtid.Focus()
        Else
            MsgBox("Id karyawan atau password salah", MsgBoxStyle.OkOnly, "Login Gagal")
            txtid.Text = ""
            txtpassword.Text = ""
            txtid.Focus()
        End If
    End Sub
    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        txtid.Focus()
    End Sub

End Class