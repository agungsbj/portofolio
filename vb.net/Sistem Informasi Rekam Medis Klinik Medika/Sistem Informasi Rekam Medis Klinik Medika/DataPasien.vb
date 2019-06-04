Imports System.Data.OleDb
Public Class Datapasien
    Sub pilih()
        Try
            Label2.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub listdata()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from pasien where idpasien like '%" & Trim(TextBox1.Text) & "%' or nama like '%" & Trim(TextBox1.Text) & "%' order by idpasien asc"
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
                    ListView1.Items(x).SubItems(1).Text = dr.GetString(2)
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(3)
                    ListView1.Items(x).SubItems(3).Text = dr.GetString(4)
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

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        pilih()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub DaftarSkes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikanan(Me, True)
        koneksi()
        listdata()
        Label2.Text = "-"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        listdata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LihatRM.TextBox1.Text = Label2.Text
        LihatRM.pasien()
        LihatRM.bacarm()
        Me.Dispose()
    End Sub
End Class