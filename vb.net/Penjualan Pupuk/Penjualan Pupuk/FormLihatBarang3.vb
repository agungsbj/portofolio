Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class FormLihatBarang3
    Private Sub FormLihatBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        TextBox1.Clear()
        TextBox1.Focus()
        listdata()
    End Sub


    Public Sub listdata()
        Call clearlist()

        Dim aksi As String
        Dim x As Integer

        aksi = "select * from barang where nama like '%" & Trim(TextBox1.Text) & "%' order by idbrg asc"

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
                    ListView1.Items(x).SubItems(1).Text = dreader.GetString(1)
                    ListView1.Items(x).SubItems(2).Text = dreader.GetString(2)
                    ListView1.Items(x).SubItems(3).Text = dreader.GetString(3)
                    ListView1.Items(x).SubItems(4).Text = dreader.GetString(4)
                    ListView1.Items(x).SubItems(5).Text = dreader.GetDecimal(5)
                End With
            End While
        Finally
            dreader.Close()

        End Try
    End Sub
    Private Sub pilih()
        Try
            FormPenjualanpribadi.txtkdbrg.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        Catch ex As Exception
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call pilih()
        Me.Close()
    End Sub

End Class