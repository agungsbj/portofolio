Imports System.Data.OleDb
Public Class FormOrder
    Sub kosong()
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        TextBox1.Clear()
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
        labelno.Text = "OR" + Format(Now, "ddMMyyHHmmss")
    End Sub
    Sub tampilgrid()
        da = New OleDbDataAdapter("select orderbarang.kode_barang, barang.nama_barang, barang.harga_beli, orderbarang.qty from orderbarang inner join barang on orderbarang.kode_barang = barang.kode_barang where no_order like '%" & labelno.Text & "%' order by no_order asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "orderbarang")

        DataGridView1.DataSource = ds.Tables("orderbarang")
        DataGridView1.Refresh()
    End Sub

    Private Sub Formorderbarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosong()
        autonumber()
        tampilgrid()
    End Sub
    Sub caripemasok()
        Try
            Call koneksi()
            cmd = New OleDbCommand("SELECT *FROM pemasok WHERE id_pemasok='" & Label5.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Label6.Text = dr.Item(1)
            Else
                Label6.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
    Sub caribarang()
        Try
            Call koneksi()
            cmd = New OleDbCommand("SELECT *FROM barang WHERE kode_barang='" & Label7.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Label18.Text = dr.Item(0)
                Label8.Text = dr.Item(1)
                TextBox1.Focus()
            Else
                Label8.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
    Private Sub Label5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.TextChanged
        caripemasok()
    End Sub
    Sub validasi()
        Call koneksi()
        cmd = New OleDbCommand("SELECT *FROM orderbarang WHERE kode_barang ='" & Label7.Text & "' and no_order ='" & labelno.Text & "' ", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MsgBox("Barang sudah ditambahkan sebelumnya. Hapus data barang dulu")
        Else
            caribarang()
        End If
    End Sub

    Private Sub Label7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.TextChanged
        validasi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LihatPemasok.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label5.Text = "" Then
            MsgBox("Isi Pemasok Dulu")
        Else
            LihatBarang.Label3.Text = "Order"
            LihatBarang.ShowDialog()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
              e.KeyChar = vbBack) Then e.Handled = True
        If Asc(e.KeyChar) = Keys.Tab Then
            Button6.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim str As String
            str = "INSERT INTO orderbarang VALUES ('" & labelno.Text & "','" & DateTimePicker1.Value & _
                "','" & FormMenu.labelkode.Text & "', '" & Label5.Text & "', '" & Label7.Text & _
                "', '" & TextBox1.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Tambah Barang Berhasil")
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
            str = "Delete from orderbarang where kode_barang = '" & Label18.Text & "' and no_order = '" & labelno.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Barang Berhasil Dihapus")
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
            End With
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Sub cetak()
        Dim pesan As String
        pesan = MsgBox("Cetak Faktur ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            FormFaktur.pesanan1.SetParameterValue("no", labelno.Text)
            FormFaktur.ShowDialog()
        Else
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Data Berhasil Disimpan")
        cetak()
        Call kosong()
        autonumber()
        tampilgrid()
    End Sub

End Class