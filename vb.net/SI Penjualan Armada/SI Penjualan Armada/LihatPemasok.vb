Imports System.Data.OleDb
Public Class LihatPemasok
    Sub pilih()
        Try
            FormPembelian.Label5.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            FormOrder.Label5.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub listdata()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from pemasok where id_pemasok like '%" & Trim(TextBox1.Text) & "%' or nama_pemasok like '%" & Trim(TextBox1.Text) & "%' order by id_pemasok asc"
        Call koneksi()

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
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(2)
                    ListView1.Items(x).SubItems(3).Text = dr.GetString(3)
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
        Call koneksi()
        listdata()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        listdata()
    End Sub

End Class