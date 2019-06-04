Imports System.Data.OleDb
Public Class FormHasilProduksi
    Sub kosong()
        Label7.Text = ""
        Label8.Text = ""
        TextBox1.Clear()
        Button4.Enabled = False
        Button6.Enabled = False
    End Sub
    Sub autonumber()
        labelno.Text = "NO-" + Format(Now, "ddMMyyHHmmss")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView1.RowCount = 0 Then
            kosong()
            Me.Dispose()
        Else
            MsgBox("Hapus data barang dahulu")
        End If
    End Sub
    Sub Tampilgrid()
        Call koneksi()
        da = New OleDbDataAdapter("select hasilproduksi.kode_barang, barang.nama_barang, hasilproduksi.stok, barang.satuan from hasilproduksi inner join barang on hasilproduksi.kode_barang = barang.kode_barang where kode_prod like '%" & labelno.Text & "%' order by kode_prod asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Refresh()
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(3).Width = 80

        If DataGridView1.RowCount = 0 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Formhasilproduksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosong()
        Tampilgrid()
    End Sub
    Sub caribarang()
        Try
            Call koneksi()
            cmd = New OleDbCommand("SELECT *FROM barang WHERE kode_barang='" & Label7.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Label18.Text = dr.Item(0)
                Label8.Text = dr.Item(1)
                labelstok.Text = dr.Item(2)
                TextBox1.Focus()
            Else
                Label8.Text = ""
                labelstok.Text = ""
                labelstokbaru.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Private Sub Label7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.TextChanged
        validasi()
    End Sub
    Sub validasi()
        Call koneksi()
        cmd = New OleDbCommand("SELECT *FROM hasilproduksi WHERE kode_barang ='" & Label7.Text & "' and kode_prod ='" & labelno.Text & "' ", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MsgBox("barang sudah ditambahkan sebelumnya. Hapus data barang dulu")
        Else
            caribarang()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LihatBarang.ShowDialog()
        TextBox1.Focus()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
             e.KeyChar = vbBack) Then e.Handled = True
        If Asc(e.KeyChar) = Keys.Tab Then
            Button6.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
            labelstokbaru.Text = Val(labelstok.Text) + Val(TextBox1.Text)
        End If

    End Sub
    Sub updatestok()
        Dim str As String
        str = "Update barang set stok = '" & labelstokbaru.Text & "' where kode_barang = '" & Label18.Text & "'"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim str As String
            str = "INSERT INTO hasilproduksi VALUES ('" & labelno.Text & "','" & DateTimePicker1.Value & _
                  "', '" & Label7.Text & "', '" & TextBox1.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            updatestok()
            MsgBox("Tambah barang Berhasil")
            Label7.Text = ""
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox("Gagal menambah barang karena " + ex.Message)
        End Try
        Tampilgrid()
    End Sub
    Sub hapus()
        Try
            Dim str As String
            str = "Delete from hasilproduksi where kode_barang = '" & Label18.Text & "' and kode_prod = '" & labelno.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            updatestok()
            MessageBox.Show("barang Berhasil Dihapus")
            Label7.Text = ""
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox("Gagal Menghapus barang Karena " + ex.Message)
        End Try
        Tampilgrid()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pesan As String
        pesan = MsgBox("Hapus barang ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            hapus()
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                Label18.Text = .Item(0, ubah).Value
                Label19.Text = .Item(2, ubah).Value
            End With
            cmd = New OleDbCommand("SELECT *FROM barang WHERE kode_barang='" & Label18.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                labelstok.Text = dr.Item(2)
            End If
            labelstokbaru.Text = Val(labelstok.Text) - Val(Label19.Text)
        Catch ex As Exception
            MsgBox("Tidak ada yang dipilih")
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Belum ada barang yang diinput!")
        Else
            Dim pesan As String
            pesan = MsgBox("Simpan Hasil ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                MessageBox.Show("Data Hasil Produksi telah disimpan")
                autonumber()
                Call kosong()
                Tampilgrid()
            Else
            End If
        End If
    End Sub
End Class