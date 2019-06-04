Imports System.Data.OleDb
Public Class LihatBarang
    Sub pilih()
        If Label3.Text = "Beli" Then
            FormPembelian.Label7.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        ElseIf Label3.Text = "Jual" Then
            FormPenjualan.Label7.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        ElseIf Label3.Text = "Order" Then
            FormOrder.Label7.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        End If
    End Sub
    Sub listdatabeli()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from barang where kode_barang like '%" & Trim(TextBox1.Text) & "%' or nama_barang like '%" & Trim(TextBox1.Text) & "%' order by kode_barang asc"

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
                    ListView1.Items(x).SubItems(2).Text = dr.GetValue(2)
                    ListView1.Items(x).SubItems(3).Text = dr.GetValue(4)
                End With
            End While
        Finally
            dr.Close()
        End Try
    End Sub
    Sub listdatajual()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from barang where kode_barang like '%" & Trim(TextBox1.Text) & "%' or nama_barang like '%" & Trim(TextBox1.Text) & "%' order by kode_barang asc"

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
                    ListView1.Items(x).SubItems(2).Text = dr.GetValue(2)
                    ListView1.Items(x).SubItems(3).Text = dr.GetValue(5)
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
        If Label3.Text = "Beli" Then
            listdatabeli()
        ElseIf Label3.Text = "Jual" Then
            listdatajual()
        ElseIf Label3.Text = "Order" Then
            listdatabeli()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Label3.Text = "Beli" Then
            listdatabeli()
        ElseIf Label3.Text = "Jual" Then
            listdatajual()
        ElseIf Label3.Text = "Order" Then
            listdatabeli()
        End If
    End Sub
End Class