Imports System.Data.OleDb
Public Class FormLogin

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Label4.Text = ""
    End Sub
    Sub cek()
        cmd = New OleDbCommand("SELECT * FROM karyawan WHERE username='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            Label4.Text = dr.Item(6)
            Button1.Enabled = True
        Else
            Label4.Text = "Username tidak ada"
            Button1.Enabled = False
        End If
    End Sub
    Sub login()
        cmd = New OleDbCommand("SELECT * FROM karyawan WHERE username='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MsgBox("Selamat Datang")
            FormMenu.labelkode.Text = dr.Item(6)
            FormMenu.labeluser.Text = dr.Item(3)
            FormMenu.ControlBox = False
            FormMenu.akhir()
            If Label4.Text = "Pimpinan" Then
                FormMenu.pimpinan()
                Me.Dispose()
            ElseIf Label4.Text = "Admin" Then
                FormMenu.admin()
                Me.Dispose()
            ElseIf Label4.Text = "Gudang" Then
                FormMenu.gudang()
                Me.Dispose()
            End If
        Else
            MsgBox("Username atau password anda salah!")
            TextBox1.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        cek()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label4.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        Me.Dispose()
    End Sub
End Class