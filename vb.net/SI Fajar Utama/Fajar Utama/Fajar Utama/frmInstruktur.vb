Imports System.Data.OleDb
Imports System.IO
Public Class frmInstruktur
    Private Sub tampildbgrid()
        Call autonumber()
        Dim SqlQuery As String = " SELECT * FROM instruktur "
        Dim SqlCommand As New OleDbCommand
        Dim sqlAdapter As New OleDbDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = cnn
        End With
        With sqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With DataGridView1
                .Rows.Add(TABLE.Rows(i)("idins"), TABLE.Rows(i)("nama"), TABLE.Rows(i)("jk"), TABLE.Rows(i)("tgllahir"), TABLE.Rows(i)("alamat"), TABLE.Rows(i)("notelp"), TABLE.Rows(i)("photo"))
            End With
        Next
    End Sub
    Private Sub frmInstruktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildbgrid()
    End Sub
    Sub autonumber()
        Call koneksi()
        cmd = New OleDbCommand("Select * from Instruktur where idins in (select max(idins) from instruktur) order by idins desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "INS" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = "INS" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        lbljk.Text = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        lbljk.Text = RadioButton2.Text
    End Sub

    Sub Simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or picPhoto.ImageLocation = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Dim Simpan As String = "INSERT INTO instruktur(idins,nama,jk,tgllahir,alamat,notelp,photo)" & _
                               "VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "'," & _
                               "'" & lbljk.Text & "','" & DateTimePicker1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "',@photo)"
            Try
                Dim Cnn As New OleDbConnection(path)
                Cnn.Open()
                Dim imgByte() As Byte
                Dim ms As New MemoryStream
                Dim gambar As New Bitmap(picPhoto.Image)
                gambar.Save(ms, Imaging.ImageFormat.Jpeg)
                imgByte = ms.ToArray

                Dim cmd As New OleDbCommand(Simpan, Cnn)
                cmd.Parameters.AddWithValue("@photo", imgByte)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Information, "Perhatian")
                Call kosong()
            Catch ex As Exception
                MsgBox("Data Gagal Disimpan!", MsgBoxStyle.Information, "Perhatian")
            End Try
        End If
    End Sub

    Sub kosong()
        DateTimePicker1.Value = Now
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        lbljk.Text = "_"
        TextBox1.Focus()
        Button8.Enabled = True
        picPhoto.Image = Nothing

        If lbljk.Text = "_" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button8.Enabled = False
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            TextBox1.Text = .Item(0, ubah).Value
            TextBox2.Text = .Item(1, ubah).Value
            lbljk.Text = .Item(2, ubah).Value
            DateTimePicker1.Text = .Item(3, ubah).Value
            TextBox3.Text = .Item(4, ubah).Value
            TextBox4.Text = .Item(5, ubah).Value
        End With

        Dim koneksi As New OleDbConnection(path)
        koneksi.Open()
        Dim sql_string As String = "select * from instruktur where idins='" & DataGridView1.SelectedCells(0).Value & "'"
        Dim sql_command As New OleDbCommand(sql_string, koneksi)
        Dim reader As OleDbDataReader
        reader = sql_command.ExecuteReader
        If reader.Read Then
            Dim gambar() As Byte
            gambar = reader.Item("photo")
            picPhoto.Image = Image.FromStream(New IO.MemoryStream(gambar))
        Else
            MsgBox("Data tidak lengkap")
        End If

        If lbljk.Text = "Laki-laki" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf lbljk.Text = "Perempuan" Then
            RadioButton2.Checked = True
            RadioButton1.Checked = False
        End If
    End Sub
    Sub Updatedata()
        Dim str As String

        str = "Update instruktur set nama = '" & TextBox2.Text & "', jk = '" & lbljk.Text & _
            "', tgllahir = '" & DateTimePicker1.Text & "', alamat = '" & TextBox3.Text & _
            "', notelp = '" & TextBox4.Text & "', photo =@photo where idins = '" & TextBox1.Text & "'"
        Try
            Dim imgByte() As Byte
            Dim ms As New MemoryStream
            Dim gambar As New Bitmap(picPhoto.Image)
            gambar.Save(ms, Imaging.ImageFormat.Jpeg)
            imgByte = ms.ToArray
            Dim cmd1 As New OleDbCommand(str, cnn)
            cmd1.Parameters.AddWithValue("@photo", imgByte)
            cmd1.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Perhatian")
            Call kosong()
            Button8.Enabled = True
        Catch ex As Exception
            MsgBox("Data Gagal Diupdate", MsgBoxStyle.Information, "Perhatian")
        End Try
        
        Call tampildbgrid()
    End Sub

    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from instruktur where idins = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call Simpan()
        Call tampildbgrid()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call Updatedata()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Untuk Menghapus Data ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call Hapus()
            Button8.Enabled = True
            Call tampildbgrid()
        Else
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call kosong()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ofdphoto.Filter = "JPG|*.JPG|BMP|*.BMP|GIF|*.GIF|PNG|*.PNG"
        ofdphoto.RestoreDirectory = True
        ofdphoto.ShowDialog()
        If ofdphoto.FileName = "" Then Exit Sub
        picPhoto.ImageLocation = ofdphoto.FileName

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class