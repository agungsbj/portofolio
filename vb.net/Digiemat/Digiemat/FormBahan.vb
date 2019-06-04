Imports System.Data.OleDb
Public Class FormBahan
    Public strsql As String
    Sub SimpanBahan()
        If txtkdbrg.Text = "" Or txtnmbrg.Text = "" Or txtharga.Text = "" Or txtstok.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Dim str As String

                str = "Insert into Bahan values ('" & txtkdbrg.Text & "','" & txtnmbrg.Text & "','" & TextBox1.Text & "','" & txtharga.Text & "', '" & txtstok.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Data Sukses")
                Call kosong()
            Catch ex As Exception
                MessageBox.Show("Simpan Data Gagal")
            End Try
        End If
        Call tampilgrid()
    End Sub
    Sub kosong()
        txtkdbrg.Text = ""
        txtnmbrg.Text = ""
        txtharga.Text = ""
        TextBox1.Clear()
        txtstok.Text = ""
        cmdsimpan.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        cmdbatal.Enabled = True
        txtnmbrg.Focus()
    End Sub

    Private Sub FrmInputBahan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Me.tampilgrid()
        GroupBox1.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cmdsimpan.Enabled = False
            Button3.Enabled = True
            Button2.Enabled = True
            cmdbatal.Enabled = True
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                txtkdbrg.Text = .Item(0, ubah).Value
                txtnmbrg.Text = .Item(1, ubah).Value
                TextBox1.Text = .Item(2, ubah).Value
                txtharga.Text = .Item(3, ubah).Value
                txtstok.Text = .Item(4, ubah).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub tampilgrid()
        da = New OleDbDataAdapter("select * from bahan where kode_bahan like '%" & Trim(TextBox2.Text) & _
                                      "%' or nama_bahan like '%" & Trim(TextBox2.Text) & "%' order by kode_bahan asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "bahan")

        DataGridView1.DataSource = ds.Tables("bahan")
        DataGridView1.Refresh()
    End Sub
    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        Call SimpanBahan()
        Call tampilgrid()
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Call kosong()
        Call tampilgrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Updatedata()
        Call tampilgrid()
    End Sub
    Sub Updatedata()
        Try
            Dim str As String

            str = "Update Bahan set nama_Bahan = '" & txtnmbrg.Text & "', harga = '" & txtharga.Text & "', merk_bahan = '" & TextBox1.Text & "', stok = '" & txtstok.Text & "' where kode_Bahan = '" & txtkdbrg.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Data Sukses")
            Call kosong()
        Catch ex As Exception
            MessageBox.Show("Update Data Gagal")
        End Try
        Call tampilgrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call HapusBahan()
        Call tampilgrid()
    End Sub
    Sub HapusBahan()
        Try
            Dim str As String
            str = "Delete * from Bahan where kode_Bahan = '" & txtkdbrg.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
        txtkdbrg.Focus()
        cmdsimpan.Enabled = True
        Button3.Enabled = False
        Button2.Enabled = False
        cmdbatal.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        tampilgrid()
    End Sub

    Private Sub txtkdbrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkdbrg.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Call koneksi()
                cmd = New OleDbCommand("SELECT *FROM bahan WHERE kode_bahan='" & txtkdbrg.Text & "'", cnn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    MsgBox("Kode Bahan Sudah Digunakan")
                    cmdsimpan.Enabled = False
                Else
                    txtnmbrg.Focus()
                    cmdsimpan.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("Error " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtkdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdbrg.TextChanged

    End Sub

    Private Sub txtnmbrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnmbrg.KeyPress
        Try
            Call koneksi()
            cmd = New OleDbCommand("SELECT *FROM bahan WHERE kode_bahan='" & txtkdbrg.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                MsgBox("Kode Bahan Sudah Digunakan")
                cmdsimpan.Enabled = False
            Else
                txtnmbrg.Focus()
                cmdsimpan.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try

    End Sub

    Private Sub txtnmbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnmbrg.TextChanged

    End Sub
End Class