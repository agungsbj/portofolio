Imports System.Data.OleDb
Public Class FormHasil
    Private Sub FormHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
    Sub Tampilkodeprod()
        da = New OleDbDataAdapter("select kode_prod from produksi where tgl like '%" & Trim(DateTimePicker1.Text) & "%' group by kode_prod", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "produksi")

        DataGridView1.DataSource = ds.Tables("produksi")
        DataGridView1.Columns(0).HeaderText = "Kode Produksi"
        DataGridView1.Columns(0).Width = 250
        DataGridView1.Refresh()
    End Sub
    Sub Tampilkodeprodbahan()
        da = New OleDbDataAdapter("select produksi.kode_bahan, bahan.nama_bahan, produksi.jml, bahan.satuan from produksi inner join bahan on produksi.kode_bahan = bahan.kode_bahan where kode_prod like '%" & Trim(Label5.Text) & "%' order by kode_prod asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "produksi")

        DataGridView2.DataSource = ds.Tables("produksi")
        DataGridView2.Columns(1).Width = 200
        DataGridView2.Columns(3).Width = 70
        DataGridView2.Refresh()
    End Sub
    Sub Tampilkodeprodbarang()
        da = New OleDbDataAdapter("select hasilproduksi.kode_barang, barang.nama_barang, hasilproduksi.stok, barang.satuan from hasilproduksi inner join barang on hasilproduksi.kode_barang = barang.kode_barang where kode_prod like '%" & Trim(Label5.Text) & "%' order by kode_prod asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "hasilproduksi")

        DataGridView3.DataSource = ds.Tables("hasilproduksi")
        DataGridView3.Columns(1).Width = 200
        DataGridView2.Columns(3).Width = 70
        DataGridView3.Refresh()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Tampilkodeprod()
        DataGridView2.DataSource = Nothing
        DataGridView3.DataSource = Nothing
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                Label5.Text = .Item(0, ubah).Value
            End With
            Tampilkodeprodbahan()
            Tampilkodeprodbarang()
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
End Class
