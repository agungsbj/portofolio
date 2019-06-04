Imports System.IO
Imports System.Data.OleDb
Public Class User
    Sub simpanlog()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menambahkan User " + TextBox1.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarUser.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpanlogupdate()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Memperbaharui User " + DaftarUser.Label2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarUser.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    
    Sub awal()
        Label11.Visible = False
        kosong()
    End Sub
    Sub kosong()
        Lbledit.Text = "0"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        DateTimePicker1.Value = Now
        picPhoto.Image = Nothing
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = TextBox2.Text Then
            Label11.Visible = True
            Label11.Text = "CORRECT"
            Label11.ForeColor = Color.Green
        Else
            Label11.Visible = True
            Label11.Text = "WRONG"
            Label11.ForeColor = Color.Red
        End If
    End Sub

    Private Sub DaftarUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        Call koneksi()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ofdphoto.Filter = "JPG|*.JPG|BMP|*.BMP|GIF|*.GIF|PNG|*.PNG"
        ofdphoto.RestoreDirectory = True
        ofdphoto.ShowDialog()
        If ofdphoto.FileName = "" Then Exit Sub
        picPhoto.ImageLocation = ofdphoto.FileName

    End Sub
    Sub Simpan()
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or picPhoto.ImageLocation = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Dim Simpan As String = "INSERT INTO pengguna VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & _
                                   "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox2.Text & "',@photo)"
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

                Call simpanlog()

                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Information, "Perhatian")
                Call kosong()
                Call DaftarUser.Tampiluser()
                Me.Close()
            Catch ex As Exception
                MsgBox("Data Gagal Disimpan!", MsgBoxStyle.Information, "Perhatian")
            End Try
        End If
    End Sub
    Sub Updateuser()
        If TextBox3.Text = "" Then
            MsgBox("Isi Password Anda!")
            TextBox3.Focus()
            TextBox3.BackColor = Color.Red
            TextBox3.ForeColor = Color.White
        ElseIf Label11.Text = "WRONG" Then
            MsgBox("Password tidak cocok!")
        Else
            Try
                Call koneksi()
                Dim str As String

                str = "Update pengguna set username = '" & TextBox1.Text & "', pass = '" & TextBox2.Text & "', nama = '" & TextBox4.Text & "', jk = '" & ComboBox1.Text & _
                    "', tmptlahir = '" & TextBox5.Text & "', tgllahir = '" & DateTimePicker1.Value & "', alamat = '" & TextBox6.Text & "', telp = '" & TextBox7.Text & _
                    "', hakakses = '" & ComboBox2.Text & "' where username = '" & DaftarUser.Label1.Text & "'"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                Call simpanlogupdate()
                MessageBox.Show("Data berhasil diperbaharui")
                TextBox3.BackColor = Color.White
                TextBox3.ForeColor = Color.Black
                Call DaftarUser.Tampiluser()
                Call kosong()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Data gagal diperbaharui")
            End Try
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lbledit.Text = "0" Then
            Call Simpan()
        ElseIf lbledit.Text = "1" Then
            Call Updateuser()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kosong()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Label11.Text = "WRONG" Then
            MsgBox("Maaf password tidak cocok!", vbCritical)
            Button1.Enabled = False
        ElseIf Label11.Text = "CORRECT" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim koneksi As New OleDbConnection(path)
        koneksi.Open()
        Dim sql_string As String = "select * from pengguna where username='" & TextBox1.Text & "'"
        Dim sql_command As New OleDbCommand(sql_string, koneksi)
        Dim dr As OleDbDataReader
        dr = sql_command.ExecuteReader
        If lbledit.Text = "0" Then
            If dr.Read Then
                MsgBox("Maaf. Username yang anda masukan telah terdaftar. Silahkan coba dengan username lain", vbCritical)
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        ElseIf lbledit.Text = "1" Then
            If dr.Read Then
                TextBox2.Text = dr.Item(1)
                TextBox4.Text = dr.Item(2)
                ComboBox1.Text = dr.Item(3)
                TextBox5.Text = dr.Item(4)
                DateTimePicker1.Value = dr.Item(5)
                TextBox6.Text = dr.Item(6)
                TextBox7.Text = dr.Item(7)
                ComboBox2.Text = dr.Item(8)
                Dim gambar() As Byte
                gambar = dr.Item("photo")
                picPhoto.Image = Image.FromStream(New IO.MemoryStream(gambar))
            Else
                TextBox2.Clear()
                TextBox4.Clear()
                ComboBox1.SelectedIndex = -1
                TextBox5.Clear()
                DateTimePicker1.Value = Now
                TextBox6.Clear()
                TextBox7.Clear()
                ComboBox2.SelectedIndex = -1
                picPhoto.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Label12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.DoubleClick
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class