Imports System.Data.OleDb
Public Class DaftarObat

    Sub simpanlog()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menghapus Obat " + Label2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from obat where kdobat = '" & Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Obat Berhasil Dihapus")
            Call simpanlog()
            Call Tampilobat()
        Catch ex As Exception
            MessageBox.Show("Obat Gagal Dihapus")
        End Try
    End Sub

    Sub Tampilobat()
        Call koneksi()
        da = New OleDbDataAdapter("select * from obat where kdobat like '%" & Trim(TextBox1.Text) & _
                                      "%' or namaobat like '%" & Trim(TextBox1.Text) & _
                                      "%' or namagen like '%" & Trim(TextBox1.Text) & _
                                      "%' or gol like '%" & Trim(TextBox1.Text) & _
                                      "%' or status like '%" & Trim(TextBox1.Text) & "%' order by tglex desc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "obat")

        DataGridView1.DataSource = ds.Tables("obat")
        DataGridView1.Refresh()
    End Sub

    Private Sub DaftarObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Tampilobat()
        cek()
        cek()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
            Label2.Text = .Item(1, ubah).Value
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lapobat.ShowDialog()
    End Sub
    Sub cek()
        Dim str As String
        str = "select count(*) from obat"
        cmd = New OleDbCommand(str, cnn)

        Dim total As Integer
        total = cmd.ExecuteScalar

        Dim a As Integer
        For a = 0 To total - 1
            Dim kode As String = DataGridView1.Rows(a).Cells(0).Value
            cmd = New OleDbCommand("SELECT *FROM obat WHERE kdobat='" & kode & "'", cnn)
            dr = cmd.ExecuteReader
            Dim tglex As Date

            If dr.Read Then
                tglex = dr.Item(5)
                If tglex < Now Then
                    Dim update As String
                    update = "Update obat set status = '" & "Kadaluarsa" & "' where kdobat = '" & kode & "'"
                    cmd = New OleDbCommand(update, cnn)
                    cmd.ExecuteNonQuery()
                Else
                    Dim update As String
                    update = "Update obat set status = '" & "Aman" & "' where kdobat = '" & kode & "'"
                    cmd = New OleDbCommand(update, cnn)
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next
        Call Tampilobat()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih obat yang akan diupdate/hapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus obat ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call Hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih data obat yang akan diupdate/hapus")
        Else
            Obat.Show()
            Obat.Button1.Text = "PERBAHARUI"
            Obat.lbledit.Text = "1"
            Obat.TextBox1.Text = Label1.Text
            Call Obat.exp()
            Call Obat.aktif()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Obat.Show()
        Call Obat.aktif()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Tarif.ShowDialog()
    End Sub

    
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Tampilobat()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        TextBox1.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class