Imports System.Data.OleDb
Public Class FormPenjualan
    Sub kosong()
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView1.RowCount = 0 Then
            kosong()
            autonumber()
        Else
            MsgBox("Hapus data barang dahulu")
        End If
    End Sub
    Sub autonumber()
        labelno.Text = "NO" + Format(Now, "ddMMyyHHmmss")
    End Sub
    Sub Tampilgrid()
        Call koneksi()
        da = New OleDbDataAdapter("select penjualan.kode_barang, barang.nama_barang, barang.harga_jual, penjualan.qty, penjualan.jumlah from penjualan inner join barang on penjualan.kode_barang = barang.kode_barang where no_transaksi like '%" & labelno.Text & "%' order by no_transaksi asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Columns(3).Width = "60"
        DataGridView1.Refresh()

        If DataGridView1.RowCount = 0 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Formpenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosong()
        autonumber()
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
                Label9.Text = dr.Item(5)
                labelstok.Text = dr.Item(2)
                TextBox1.Focus()
            Else
                Label8.Text = ""
                Label9.Text = ""
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LihatPemasok.ShowDialog()
    End Sub
    Sub validasi()
        Call koneksi()
        cmd = New OleDbCommand("SELECT *FROM penjualan WHERE kode_barang ='" & Label7.Text & "' and no_transaksi ='" & labelno.Text & "' ", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MsgBox("Barang sudah ditambahkan sebelumnya. Hapus data barang dulu")
        Else
            caribarang()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LihatBarang.Label3.Text = "Jual"
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
        If Val(TextBox1.Text) > Val(labelstok.Text) Then
            MsgBox("Stok kurang / habis")
            Button6.Enabled = False
        Else
            labelstokbaru.Text = Val(labelstok.Text) - Val(TextBox1.Text)
            Label15.Text = Val(TextBox1.Text) * Val(Label9.Text)
            Button6.Enabled = True
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
            str = "INSERT INTO penjualan VALUES ('" & labelno.Text & "','" & DateTimePicker1.Value & _
                "','" & FormMenu.labelkode.Text & "', '" & Label7.Text & _
                "', '" & TextBox1.Text & "', '" & Label15.Text & "', '" & "0" & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            updatestok()
            MsgBox("Tambah Barang Berhasil")
            Label7.Text = ""
            TextBox1.Clear()
            Label15.Text = ""
        Catch ex As Exception
            MsgBox("Gagal menambah barang karena " + ex.Message)
        End Try
        Tampilgrid()
        Hitungtotal()
    End Sub
    Sub Hitungtotal()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + Val(DataGridView1.Rows(t).Cells(4).Value)
        Next
        Label16.Text = Format(total, "#,#0")
    End Sub

    Sub hapus()
        Try
            Dim str As String
            str = "Delete from penjualan where kode_barang = '" & Label18.Text & "' and no_transaksi = '" & labelno.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            updatestok()
            MessageBox.Show("Barang Berhasil Dihapus")
            Label7.Text = ""
            TextBox1.Clear()
            Label15.Text = ""
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
                Label19.Text = .Item(3, ubah).Value
            End With
            cmd = New OleDbCommand("SELECT *FROM barang WHERE kode_barang='" & Label18.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                labelstok.Text = dr.Item(2)
            End If
            labelstokbaru.Text = Val(labelstok.Text) + Val(Label19.Text)
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Hitungtotal()
    End Sub
    Sub simpan()
        Try
            Dim total As Integer
            total = DataGridView1.RowCount

            Dim a As Integer
            For a = 0 To total - 1
                Dim kode As String = DataGridView1.Rows(a).Cells(0).Value
                Dim str As String
                str = "Update penjualan set total = '" & Label16.Text & "' where kode_barang = '" & kode & "' and no_transaksi = '" & labelno.Text & "'"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Transaksi Berhasil Dilakukan")
            cetak()
            kosong()
            autonumber()
        Catch ex As Exception
            MsgBox("Gagal karena " + ex.Message)
        End Try
    End Sub
    Sub cetak()
        Dim pesan As String
        pesan = MsgBox("Cetak Nota ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            FormNota.nota1.SetParameterValue("no", labelno.Text)
            FormNota.ShowDialog()
        Else
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Simpan transaksi ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            simpan()
            Tampilgrid()
            Label16.Text = ""
        Else
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim total As Integer = Label16.Text
        If e.KeyChar = Chr(13) Then
            If Val(TextBox2.Text) < Val(total) Then
                MsgBox("Pembayaran Kurang")
                Button3.Enabled = False
                TextBox2.Clear()
            Else
                TextBox3.Text = Val(TextBox2.Text) - Val(total)
                Button3.Enabled = True
            End If
        End If
    End Sub
End Class