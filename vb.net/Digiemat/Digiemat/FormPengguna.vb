Imports System.Data.OleDb
Public Class FormPengguna
    Private Sub FormPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        GroupBox1.Enabled = False
        Tampilgrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
        TextBox2.Focus()
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button1.Focus()
    End Sub
    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from pengguna", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengguna")

        DataGridView1.DataSource = ds.Tables("pengguna")
        DataGridView1.Refresh()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim str As String
            str = "INSERT INTO pengguna VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & _
                "', '" & TextBox3.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Simpan Data Berhasil")
            Call kosong()
        Catch ex As Exception
            MsgBox("Gagal Menyimpan Data Karena " + ex.Message)
        End Try
        Tampilgrid()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If GroupBox1.Enabled = False Then
            MsgBox("Klik Tombol Tambah Dulu")
            Button1.Focus()
        Else
            Try
                Dim ubah As Integer = Nothing
                ubah = DataGridView1.CurrentRow.Index
                With DataGridView1
                    TextBox1.Text = .Item(0, ubah).Value
                    TextBox2.Text = .Item(1, ubah).Value
                    ComboBox1.Text = .Item(2, ubah).Value
                    TextBox3.Text = .Item(3, ubah).Value
                End With
                Button2.Enabled = False
                Button3.Enabled = True
                Button4.Enabled = True
                Button5.Enabled = True
            Catch ex As Exception
                MsgBox("Error " + ex.Message)
            End Try
        End If
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call kosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim str As String
            str = "Delete * from pengguna where kode_pengguna = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
            Tampilgrid()
        Catch ex As Exception
            MsgBox("Gagal Menghapus Data Karena " + ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim str As String
            str = "Update pengguna set nama = '" & TextBox2.Text & _
                "', jabatan  = '" & ComboBox1.Text & "', pass = '" & TextBox3.Text & _
                "' where kode_pengguna = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call kosong()
            Tampilgrid()
        Catch ex As Exception
            MsgBox("Gagal Mengedit Data Karena " + ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Call koneksi()
                cmd = New OleDbCommand("SELECT *FROM pengguna WHERE kode_pengguna='" & TextBox1.Text & "'", cnn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    MsgBox("Kode Pengguna Sudah Digunakan")
                    Button2.Enabled = False
                Else
                    TextBox2.Focus()
                    Button2.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("Error " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            cmd = New OleDbCommand("SELECT *FROM pengguna WHERE kode_pengguna='" & TextBox1.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                MsgBox("Kode Pengguna Sudah Digunakan")
                Button2.Enabled = False
            Else
                TextBox2.Focus()
                Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
        
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
