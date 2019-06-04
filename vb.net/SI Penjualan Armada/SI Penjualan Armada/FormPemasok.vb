Imports System.Data.OleDb
Public Class FormPemasok
    Sub autonumber()
        cmd = New OleDbCommand("Select * from pemasok where id_pemasok in (select max(id_pemasok) from pemasok) order by id_pemasok desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "PMSK-" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urutan = "PMSK-" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
    End Sub
    Sub Tampilpemasok()
        da = New OleDbDataAdapter("select * from pemasok where id_pemasok like '%" & Trim(TextBox6.Text) & _
                                      "%' or nama_pemasok like '%" & Trim(TextBox6.Text) & "%' order by id_pemasok asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pemasok")

        DataGridView1.DataSource = ds.Tables("pemasok")
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Refresh()
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        labelkode.Text = "-"
    End Sub
    Private Sub Formpemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Me.Size = New Point(828, 460)
        Tampilpemasok()
        Call kosong()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox1.Enabled = True
        Me.Size = New Point(828, 582)
        Call autonumber()
        Button1.Enabled = True
        Button2.Enabled = False
        TextBox2.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Size = New Point(828, 460)
    End Sub
    Sub edit()
        GroupBox1.Enabled = True
        Me.Size = New Point(828, 582)
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox2.Focus()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If labelkode.Text = "-" Then
            MsgBox("Pilih pemasok yang akan di edit / hapus")
        Else
            cari()
            edit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim str As String
            str = "INSERT INTO pemasok VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & _
                "', '" & TextBox4.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Simpan Data Berhasil")
            Call kosong()
            Button3.PerformClick()
        Catch ex As Exception
            MsgBox("Gagal Menyimpan Data Karena " + ex.Message)
        End Try
        Tampilpemasok()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim str As String
            str = "Update pemasok set nama_pemasok = '" & TextBox2.Text & "', alamat = '" & TextBox3.Text & _
                "', telepon  = '" & TextBox4.Text & "' where id_pemasok = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Edit pemasok Berhasil")
            Call kosong()
            Button3.PerformClick()
        Catch ex As Exception
            MsgBox("Gagal Mengedit pemasok Karena " + ex.Message)
        End Try
        Tampilpemasok()
    End Sub
    Sub hapus()
        Try
            Dim str As String
            str = "Delete * from pemasok where id_pemasok = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("pemasok Berhasil Dihapus")
            Call kosong()
        Catch ex As Exception
            MsgBox("Gagal Menghapus pemasok Karena " + ex.Message)
        End Try
        Tampilpemasok()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If labelkode.Text = "-" Then
            MsgBox("Pilih pemasok yang akan di edit / hapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus pemasok ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Tampilpemasok()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        TextBox6.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                labelkode.Text = .Item(0, ubah).Value
                TextBox1.Text = .Item(0, ubah).Value
            End With
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
    Sub cari()
        Try
            cmd = New OleDbCommand("SELECT *FROM pemasok WHERE id_pemasok='" & TextBox1.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
            Else
                kosong()
                autonumber()
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
