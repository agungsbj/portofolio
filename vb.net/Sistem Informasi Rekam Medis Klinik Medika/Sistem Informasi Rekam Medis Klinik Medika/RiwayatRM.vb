Imports System.Data.OleDb
Public Class RiwayatRM
    Sub Tampilriwayatrm()
        Call koneksi()
        da = New OleDbDataAdapter("select tglperiksa,keluhan,diagnosis,tindakan from rekammedis where idpasien like '%" & Trim(RekamMedis.TextBoxIDPas.Text) & "%' order by idpasien asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView3.DataSource = ds.Tables("detail")
        DataGridView3.Refresh()
        DataGridView3.Columns(0).Width = "100"
        DataGridView3.Columns(1).Width = "200"
        DataGridView3.Columns(2).Width = "200"
        DataGridView3.Columns(3).Width = "200"
    End Sub
    Private Sub RiwayatRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Tampilriwayatrm()
    End Sub
End Class