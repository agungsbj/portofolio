Imports System.Data.OleDb
Public Class Pasien
    Sub kosong()
        DateTimePicker1.Value = Now
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox3.Clear()
        DateTimePicker2.Value = Now
        TextBox4.Clear()
    End Sub
    Sub simpanlogupdate()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Memperbaharui Pasien " + DaftarPasien.Label2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarPasien.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpanlog()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menambahkan Pasien " + TextBox2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarPasien.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO pasien VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value & "','" & TextBox2.Text & _
                    "', '" & ComboBox1.Text & "', '" & TextBox3.Text & "', '" & DateTimePicker2.Value & "', '" & TextBox4.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                Call simpanlog()
                MessageBox.Show("Tambah Pasien Berhasil")
                Call kosong()
                DaftarPasien.Tampilpasien()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Tambah Pasien Gagal")
            End Try
        End If
    End Sub
    
    Sub Updatepasien()
        Try
            Call koneksi()
            Dim str As String

            str = "Update pasien set tgldaftar = '" & DateTimePicker1.Value & "', nama = '" & TextBox2.Text & "', jk = '" & ComboBox1.Text & _
                "', alamat = '" & TextBox3.Text & "', tgllahir = '" & DateTimePicker2.Value & _
                "', umur = '" & TextBox4.Text & "' where idpasien = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            Call simpanlogupdate()
            MessageBox.Show("Data berhasil diperbaharui")
            Call DaftarPasien.Tampilpasien()
            Call kosong()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub
    Sub umur()
        Dim a, b, tahun As String
        a = Year(Now)
        b = Year(DateTimePicker2.Value)
        tahun = a - b
        TextBox4.Text = tahun + " Tahun "
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        umur()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("SELECT *FROM pasien WHERE idpasien='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            DateTimePicker1.Value = dr.Item(1)
            TextBox2.Text = dr.Item(2)
            ComboBox1.Text = dr.Item(3)
            TextBox3.Text = dr.Item(4)
            DateTimePicker2.Text = dr.Item(5)
            TextBox4.Text = dr.Item(6)
        Else
            DateTimePicker1.Value = Now
            TextBox2.Clear()
            ComboBox1.SelectedIndex = -1
            TextBox3.Clear()
            DateTimePicker2.Value = Now
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Pasien_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        animasibawah(Me, True)
    End Sub
    Sub transparan()
        Do Until Me.opacity = 1
            Me.Opacity += 0.02
            Application.DoEvents()
            Threading.Thread.Sleep(2) 'jedah waktu = 2
        Loop
    End Sub
    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        kosong()
        Call autonumber()
    End Sub
    Sub autonumber()
        cmd = New OleDbCommand("Select * from pasien where idpasien in (select max(idpasien) from pasien) order by idpasien desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = Format(Now, "yyddMM") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urutan = Format(Now, "yyddMM") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lbledit.Text = "0" Then
            Call simpan()
        ElseIf lbledit.Text = "1" Then
            Call Updatepasien()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
        Me.Dispose()
    End Sub
End Class