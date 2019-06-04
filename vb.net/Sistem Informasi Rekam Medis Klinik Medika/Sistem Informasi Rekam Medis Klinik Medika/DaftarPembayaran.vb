Imports System.Data.OleDb
Public Class DaftarPembayaran
    Sub tampilnota()
        CetakNota.Nota1.SetParameterValue("notrans", Label2.Text)
        CetakNota.Show()
    End Sub

    Sub tampilkwitansi()
        CetakKwitansi.kwitansi1.SetParameterValue("notrans", Label2.Text)
        CetakKwitansi.Show()
    End Sub
    Sub tampilskes()
        SuratKesehatan.kesehatan1.SetParameterValue("nosurat", label4.Text)
        SuratKesehatan.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label3.Text = "Rekam Medis" Then
            tampilnota()
        ElseIf Label3.Text = "Pembuatan Surat" Then
            tampilkwitansi()
            tampilskes()
        End If
    End Sub
    Sub pilih()
        Try
            Label2.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            Label3.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
            Label4.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub listdata()
        Call clearlist()
        Dim isi As String
        isi = ""
        Dim aksi As String
        Dim x As Integer

        aksi = "select * from pembayaran where notrans like '%" & Trim(TextBox1.Text) & _
            "%' or jp like '%" & Trim(TextBox1.Text) & "%' or noregister like '%" & Trim(TextBox1.Text) & _
            "%'  or no_surat like '%" & Trim(TextBox1.Text) & "%'order by notrans asc"
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
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dr.GetDateTime(1)
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(3)
                    ListView1.Items(x).SubItems(3).Text = dr.GetString(4)
                    ListView1.Items(x).SubItems(4).Text = dr.GetString(5)
                    ListView1.Items(x).SubItems(5).Text = dr.GetDecimal(6)
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
        animasibawah(Me, True)
        koneksi()
        listdata()
        Label2.Text = "-"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        listdata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from pembayaran where notrans = '" & Label2.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
        listdata()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label2.Text = "-" Then
            MsgBox("Pilih data yang akan dihapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus data ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call Hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

End Class