Imports System.Data.OleDb
Public Class formuser
    Private Sub cmddaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddaftar.Click
        Call Simpan()
        Call tampildbgrid()
    End Sub

    Sub Simpan()
        If txtid.Text = "" Or txtnm.Text = "" Or txtpswd.Text = "" Or cbjk.Text = "" Or txtalmt.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Dim str As String

                str = "INSERT INTO KARYAWAN VALUES ('" & txtid.Text & "','" & txtnm.Text & "','" & txtpswd.Text & "', '" & cbjk.Text & "', '" & txtalmt.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Pendaftaran Berhasil")
                Call kosong()
                Call autonumber()
                GroupBox1.Enabled = False
                DataGridView1.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Pendaftaran Gagal")
            End Try
        End If
    End Sub
    Sub kosong()
        txtnm.Text = ""
        txtpswd.Text = ""
        cbjk.SelectedIndex = -1
        txtalmt.Text = ""
        txtid.Focus()
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan membatalkan?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call kosong()
            cmddaftar.Enabled = True
            Call tampildbgrid()
            Call autonumber()
            GroupBox1.Enabled = False
            DataGridView1.Enabled = False
        Else
        End If
    End Sub
    Sub autonumber()
        Call koneksi()
        cmd = New OleDbCommand("Select * from karyawan where id_karyawan in (select max(id_karyawan) from karyawan) order by id_karyawan desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtid.Text = urutan
    End Sub
    Private Sub formuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosong()
        Me.tampildbgrid()
        Button3.Focus()
    End Sub
    Private Sub tampildbgrid()
        Dim SqlQuery As String = " SELECT * FROM karyawan "
        Dim SqlCommand As New OleDbCommand
        Dim sqlAdapter As New OleDbDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = cnn
        End With
        With sqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With DataGridView1
                .Rows.Add(TABLE.Rows(i)("id_karyawan"), TABLE.Rows(i)("nama_karyawan"), TABLE.Rows(i)("pass"), TABLE.Rows(i)("jk"), TABLE.Rows(i)("alamat"))
            End With
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call tampildbgrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan menghapus data?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call Hapuskaryawan()
            Call tampildbgrid()
            GroupBox1.Enabled = False
            DataGridView1.Enabled = False
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmddaftar.Enabled = False
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            txtid.Text = .Item(0, ubah).Value
            txtnm.Text = .Item(1, ubah).Value
            txtpswd.Text = .Item(2, ubah).Value
            cbjk.Text = .Item(3, ubah).Value
            txtalmt.Text = .Item(4, ubah).Value
        End With
    End Sub
    Sub Hapuskaryawan()
        Try
            Dim str As String
            str = "Delete * from karyawan where id_karyawan = '" & txtid.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
            Call autonumber()
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Simpan()
        Call tampildbgrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Sub Updateuser()
        Try
            Call koneksi()
            Dim str As String

            str = "Update karyawan set nama_karyawan = '" & txtnm.Text & "', pass = '" & txtpswd.Text & "', jk = '" & cbjk.Text & "', alamat = '" & txtalmt.Text & "' where id_karyawan = '" & txtid.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbaharui")
            Call kosong()
            cmddaftar.Enabled = True
            Call autonumber()
            GroupBox1.Enabled = False
            DataGridView1.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Updateuser()
        Call tampildbgrid()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtpswd.PasswordChar = "*"
        Else
            txtpswd.PasswordChar = ""
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Enabled = True
        DataGridView1.Enabled = True
        Call kosong()
        cmddaftar.Enabled = True
        Call tampildbgrid()
        Call autonumber()
    End Sub
End Class