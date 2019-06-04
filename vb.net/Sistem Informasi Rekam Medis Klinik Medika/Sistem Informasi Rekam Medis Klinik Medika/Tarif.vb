Imports System.Data.OleDb
Public Class Tarif
    
    Sub autonumber()
        cmd = New OleDbCommand("Select * from tarif where idtarif in (select max(idtarif) from tarif) order by idtarif desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "JP" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = "JP" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
        TextBox2.Focus()
    End Sub
    Sub Tampiltarif()
        Call koneksi()
        da = New OleDbDataAdapter("Select * From tarif", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tarif")

        DataGridView1.DataSource = ds.Tables("tarif")
        DataGridView1.Refresh()
    End Sub
    Private Sub Tarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        Call koneksi()
        Call Tampiltarif()
        kosong()
        Button4.Enabled = False
        Button1.Enabled = True
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO tarif VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Tambah Tarif Berhasil")
                Call kosong()
            Catch ex As Exception
                MessageBox.Show("Tambah Tarif Gagal")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
        Tampiltarif()
    End Sub
    Sub kosong()
        TextBox2.Clear()
        TextBox3.Clear()
        autonumber()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
        Tampiltarif()
    End Sub
    Sub Updatetarif()
        Try
            Call koneksi()
            Dim str As String

            str = "Update tarif set namatarif = '" & TextBox2.Text & "', harga = '" & TextBox3.Text & "' where idtarif = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbaharui")
            Call kosong()
            Button4.Enabled = False
            Button1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Updatetarif()
        Tampiltarif()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from tarif where idtarif = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
            Button4.Enabled = False
            Button1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan menghapus data ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Hapus()
        Else
            Button3.Focus()
        End If
        Tampiltarif()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button4.Enabled = True
        Button1.Enabled = False

        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                TextBox1.Text = .Item(0, ubah).Value
                TextBox2.Text = .Item(1, ubah).Value
                TextBox3.Text = .Item(2, ubah).Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class