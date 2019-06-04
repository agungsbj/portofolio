Imports System.Data.OleDb
Public Class LihatBarang
    Sub pilih()
        FormTransaksi.Label7.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
    End Sub
    Sub listdata()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from bahan where kode_bahan like '%" & Trim(TextBox1.Text) & "%' or nama_bahan like '%" & Trim(TextBox1.Text) & "%' order by kode_bahan asc"

        Dim cmd As New OleDbCommand(aksi, cnn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader

        Try
            While dr.Read
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1)

                With ListView1
                    ListView1.Items.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dr.GetString(1)
                    ListView1.Items(x).SubItems(2).Text = dr.GetValue(4)
                    ListView1.Items(x).SubItems(3).Text = dr.GetValue(3)
                End With
            End While
        Finally
            dr.Close()
        End Try
    End Sub
    Public Sub clearlist()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        pilih()
        Me.Dispose()
    End Sub
    Private Sub LihatPemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listdata()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        listdata()
    End Sub
End Class