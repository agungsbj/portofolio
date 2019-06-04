Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Public Class frmPaket

    Private Sub tampildbgrid()
        Call autonumber()
        Dim SqlQuery As String = " SELECT * FROM paket "
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
                .Rows.Add(TABLE.Rows(i)("idpaket"), TABLE.Rows(i)("nmpaket"), TABLE.Rows(i)("kelas"), TABLE.Rows(i)("jam"), TABLE.Rows(i)("biaya"))
            End With
        Next
    End Sub
    Private Sub frmPaket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildbgrid()
    End Sub
    Sub autonumber()
        Call koneksi()
        cmd = New OleDbCommand("Select * from paket where idpaket in (select max(idpaket) from paket) order by idpaket desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "01"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = Microsoft.VisualBasic.Right("00" & hitung, 2)
        End If
        TextBox1.Text = urutan
    End Sub
    Sub Simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO paket VALUES ('" & TextBox5.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input Berhasil")
                Call kosong()
            Catch ex As Exception
                MessageBox.Show("Input Gagal")
            End Try
        End If
    End Sub

    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub Updatedata()
        Try
            Call koneksi()
            Dim str As String

            str = "Update paket set nmpaket = '" & TextBox2.Text & "', kelas = '" & ComboBox1.Text & "', jam = '" & TextBox3.Text & "', biaya = '" & TextBox4.Text & "' where idpaket = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Data Sukses")
            Call kosong()
        Catch ex As Exception
            MessageBox.Show("Update Data Gagal")
        End Try
        Call tampildbgrid()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from paket where idpaket = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button5.Enabled = False
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            TextBox1.Text = .Item(0, ubah).Value
            TextBox5.Text = .Item(0, ubah).Value
            TextBox2.Text = .Item(1, ubah).Value
            ComboBox1.Text = .Item(2, ubah).Value
            TextBox3.Text = .Item(3, ubah).Value
            TextBox4.Text = .Item(4, ubah).Value
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Privat" Then
            Label8.Text = "PP"
        Else
            Label8.Text = "PR"
        End If
        TextBox5.Text = Label8.Text + TextBox1.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call Simpan()
        Label8.Text = "-"
        Call tampildbgrid()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Updatedata()
        Label8.Text = "-"
        Button5.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Untuk Menghapus Data ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call Hapus()
            Call kosong()
            Label8.Text = "-"
            Call tampildbgrid()
            Button5.Enabled = True
        Else
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call kosong()
        Label8.Text = "-"
        Call tampildbgrid()
        Button5.Enabled = True
    End Sub
End Class