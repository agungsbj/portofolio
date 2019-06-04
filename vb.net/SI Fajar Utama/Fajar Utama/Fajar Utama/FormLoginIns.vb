Imports System.Data.OleDb
Public Class FormLoginIns
    Sub login()
        Call koneksi()

        cmd = New OleDbCommand("SELECT *FROM instruktur WHERE idins='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If (dr.Read()) Then
            MsgBox("Selamat Datang " + dr.Item("Nama"))
            Me.Dispose()
            FormNilai.ShowDialog()
        Else
            MsgBox("ID Instruktur Salah/Belum Terdaftar")
        End If
    End Sub
    Private Sub FormLoginIns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim koneksi As New OleDbConnection(path)
        koneksi.Open()
        Dim sql_string As String = "select * from instruktur where idins='" & TextBox1.Text & "'"
        Dim sql_command As New OleDbCommand(sql_string, koneksi)
        Dim reader As OleDbDataReader
        reader = sql_command.ExecuteReader
        If reader.Read Then
            Label2.Text = reader.Item("Nama")
            Dim gambar() As Byte
            gambar = reader.Item("photo")
            picPhoto.Image = Image.FromStream(New IO.MemoryStream(gambar))
            PictureBox2.Image = picPhoto.Image
        Else
            PictureBox2.Image = Nothing
            Label2.Text = ""
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
        FormLoginUtama.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call login()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class