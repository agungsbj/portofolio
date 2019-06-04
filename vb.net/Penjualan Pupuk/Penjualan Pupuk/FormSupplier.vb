Imports System.Data.OleDb
Public Class FormSupplier
    Sub tampildbgrid()
        Call autonumber()
        Dim SqlQuery As String = " SELECT * FROM supplier "
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
                .Rows.Add(TABLE.Rows(i)("idsup"), TABLE.Rows(i)("nama"), TABLE.Rows(i)("alamat"), TABLE.Rows(i)("telp"))
            End With
        Next
    End Sub
    Sub autonumber()
        cmd = New OleDbCommand("Select * from supplier where idsup in (select max(idsup) from supplier) order by idsup desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "SUP" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = "SUP" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtid.Text = urutan
    End Sub
    Sub kosong()
        txtid.Clear()
        txtnm.Clear()
        txtalmt.Clear()
        txtno.Clear()
        txtnm.Focus()
    End Sub
    Private Sub FormSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildbgrid()
        Call kosong()
        Call autonumber()
    End Sub
    Sub Simpan()
        If txtid.Text = "" Or txtnm.Text = "" Or txtalmt.Text = "" Or txtno.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO supplier VALUES ('" & txtid.Text & "','" & txtnm.Text & "','" & txtalmt.Text & "', '" & txtno.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input Berhasil")
                Call kosong()
                Call autonumber()
            Catch ex As Exception
                MessageBox.Show("Input Gagal")
            End Try
        End If
    End Sub
    Private Sub cmddaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddaftar.Click
        Call Simpan()
        Call tampildbgrid()
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Dim pesan As String
        pesan = MsgBox("Batalkan Input Supplier ?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call kosong()
            cmddaftar.Enabled = True
            Call autonumber()
        Else
            Button2.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Updatesup()
        Call tampildbgrid()
    End Sub
    Sub Updatesup()
        Try
            Call koneksi()
            Dim str As String

            str = "Update supplier set nama = '" & txtnm.Text & "', alamat = '" & txtalmt.Text & "', telp = '" & txtno.Text & "' where idsup = '" & txtid.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbaharui")
            Call kosong()
            cmddaftar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmddaftar.Enabled = False
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            txtid.Text = .Item(0, ubah).Value
            txtnm.Text = .Item(1, ubah).Value
            txtalmt.Text = .Item(2, ubah).Value
            txtno.Text = .Item(3, ubah).Value
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pesan As String
        pesan = MsgBox("Hapus Supplier ?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call Hapus()
            Call tampildbgrid()
        Else
            Button2.Focus()
        End If
    End Sub
    Sub Hapus()
        Try
            Dim str As String
            str = "Delete * from supplier where idsup = '" & txtid.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
            cmddaftar.Enabled = True
            Call autonumber()
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub
End Class