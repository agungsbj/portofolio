Imports System.Data.OleDb
Public Class Antrian
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Sub autonumber()
        cmd = New OleDbCommand("Select * from antrian where noantrian in (select max(noantrian) from antrian) order by noantrian desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        Label4.Text = urutan
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from antrian where noantrian = '" & Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sukses")
            Call Tampilantrian()
            Call autonumber()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub
    Sub Tampilantrian()
        Call koneksi()
        da = New OleDbDataAdapter("Select * From antrian", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "antrian")

        DataGridView1.DataSource = ds.Tables("antrian")
        DataGridView1.Refresh()
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO antrian VALUES ('" & Label4.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')"
                Label1.Text = Label4.Text
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Menambahkan ke Antrian Berhasil")
                Call kosong()
                Call Tampilantrian()
                Call autonumber()
                Dim pesan As String
                pesan = MsgBox("Cetak Kartu Antrian ? ", vbQuestion + vbYesNo, "pesan")
                If pesan = vbYes Then
                    cetak()
                Else
                    Button5.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Menambahkan ke Antrian Gagal")
            End Try
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("SELECT *FROM pasien WHERE idpasien='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox2.Text = dr.Item(2)
        Else
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Antrian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
        Call koneksi()
        Call Tampilantrian()
        Call autonumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih Antrian Dahulu")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus antrian ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call Hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
        End With
    End Sub
 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call kosong()
    End Sub
    Sub cetak()
        CetakKartuAntrian.kartuantrian1.SetParameterValue("noantri", Label1.Text)
        CetakKartuAntrian.ShowDialog()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cetak()
    End Sub
End Class