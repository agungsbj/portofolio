Imports System.Data.OleDb
Public Class LogAktivitas

    Private Sub tampillog()
        koneksi()
        Dim SqlQuery As String = " SELECT * FROM log "
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
                .Rows.Add(TABLE.Rows(i)("nolog"), TABLE.Rows(i)("tgl"), TABLE.Rows(i)("jam"), TABLE.Rows(i)("pengguna"), TABLE.Rows(i)("aksi"))
            End With
            DataGridView1.Columns(2).DefaultCellStyle.Format = "t"
            DataGridView1.Columns(1).DefaultCellStyle.Format = "d"
        Next
    End Sub
    Private Sub LogAktivitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikanan(Me, True)
        tampillog()
    End Sub
End Class