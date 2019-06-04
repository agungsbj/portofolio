Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class FormLihattrans
    Private Sub FormLihatBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        TextBox1.Clear()
        TextBox1.Focus()
        listdata()
    End Sub
    Private Sub pilih()
        Try
            FormPelunasan.TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            Me.Close()
            FormPelunasan.TextBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub listdata()
        Call clearlist()

        Dim aksi As String
        Dim x As Integer

        aksi = "select * from penjualan where namapel like '%" & Trim(TextBox1.Text) & "%' or tanggal like '%" & Trim(DateTimePicker1.Text) & "%' or sisa like '%" & Trim(TextBox1.Text) & "%' or status like '%" & Trim(TextBox1.Text) & "%' order by no_transaksi asc"

        Call koneksi()

        Dim cmmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmmd.ExecuteReader

        Try
            While dreader.Read
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1)

                With ListView1
                    ListView1.Items.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dreader.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dreader.GetDateTime(1)
                    ListView1.Items(x).SubItems(2).Text = dreader.GetString(5)
                    ListView1.Items(x).SubItems(3).Text = dreader.GetDecimal(7)
                    ListView1.Items(x).SubItems(4).Text = dreader.GetString(10)
                    ListView1.Items(x).SubItems(5).Text = dreader.GetDecimal(12)
                End With
            End While
        Finally
            dreader.Close()

        End Try
    End Sub

    Public Sub clearlist()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call listdata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        listdata()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call pilih()
    End Sub
End Class