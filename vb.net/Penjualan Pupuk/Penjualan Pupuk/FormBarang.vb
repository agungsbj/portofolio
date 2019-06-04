Imports System.Data.OleDb
Public Class FormBarang
    Sub autonumber()
        cmd = New OleDbCommand("Select * from barang where idbrg in (select max(idbrg) from barang) order by idbrg desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "BRG" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = "BRG" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        TextBox1.Text = urutan
    End Sub
    Sub Simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO barang VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & ComboBox3.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input Berhasil")
                Call kosong()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub kosong()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Text = "0"
        TextBox4.Clear()
        TextBox5.Clear()
        Label11.Text = "idbrg"
    End Sub

    Sub tampildbgrid()
        Call autonumber()
        Dim SqlQuery As String = " SELECT * FROM Barang "
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
                .Rows.Add(TABLE.Rows(i)("idbrg"), TABLE.Rows(i)("nama"), TABLE.Rows(i)("jenis"), TABLE.Rows(i)("stok"), TABLE.Rows(i)("satuan"), TABLE.Rows(i)("hargabeli"), TABLE.Rows(i)("hargajual"), TABLE.Rows(i)("supplier"))
            End With
        Next
    End Sub
    Sub tampilsup()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Using cnn As New OleDbConnection(path)
            Try
                cnn.Open()
                Using cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select idsup, nama from supplier"
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    Me.ComboBox3.DataSource = dt
                    Me.ComboBox3.DisplayMember = "nama"
                    Me.ComboBox3.ValueMember = "nama"

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
        ComboBox3.SelectedIndex = -1
    End Sub
    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call autonumber()
        Call tampildbgrid()
        Call tampilsup()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Simpan()
        Call tampildbgrid()
        Call autonumber()

    End Sub
    Sub Updatebarang()
        Try
            Call koneksi()
            Dim str As String

            str = "Update barang set idbrg = '" & TextBox1.Text & "', nama = '" & TextBox2.Text & "', jenis = '" & ComboBox2.Text & _
                "', satuan = '" & ComboBox1.Text & "', hargabeli = '" & TextBox4.Text & "', hargajual = '" & TextBox5.Text & _
                "', supplier = '" & ComboBox3.Text & "' where idbrg = '" & Label11.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbaharui")
            Call kosong()
            Button1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Updatebarang()
        Call tampildbgrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pesan As String
        pesan = MsgBox("Batalkan Input Barang ?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call kosong()
            Button1.Enabled = True
            Call autonumber()
        Else
            Button2.Focus()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button1.Enabled = False
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            TextBox2.Text = .Item(1, ubah).Value
            ComboBox2.Text = .Item(2, ubah).Value
            TextBox3.Text = .Item(3, ubah).Value
            ComboBox1.Text = .Item(4, ubah).Value
            TextBox4.Text = .Item(5, ubah).Value
            TextBox5.Text = .Item(6, ubah).Value
            ComboBox3.Text = .Item(7, ubah).Value
            TextBox1.Text = .Item(0, ubah).Value
            Label11.Text = .Item(0, ubah).Value
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub Hapusbarang()
        Try
            Dim str As String
            str = "Delete * from barang where idbrg = '" & Label11.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Call kosong()
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pesan As String
        pesan = MsgBox("Hapus Supplier ?", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            Call Hapusbarang()
            Call tampildbgrid()
        Else
            Button2.Focus()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        End
    End Sub
    Sub cari2()
        da = New OleDbDataAdapter("select * from barang where nama like'%" & TextBox6.Text & "' ", cnn)
        ds = New DataSet
        da.Fill(ds, "Detail")
        DataGridView1.DataSource = ds.Tables("Detail")
        DataGridView1.ReadOnly = True
    End Sub
    Sub caribarang()
        Call koneksi()

        Dim str As String
        str = "select * from barang where nama like '%" & TextBox6.Text & "%'"
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim table As New DataTable
        With cmd
            .CommandText = str
            .Connection = cnn
        End With
        With da
            .SelectCommand = cmd
            .Fill(table)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To table.Rows.Count - 1
            With DataGridView1
                .Rows.Add(table.Rows(i)("idbrg"), table.Rows(i)("nama"), table.Rows(i)("jenis"), table.Rows(i)("stok"), table.Rows(i)("satuan"), table.Rows(i)("hargabeli"), table.Rows(i)("hargajual"), table.Rows(i)("supplier"))
            End With
        Next
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call caribarang()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call kosong()
        Button1.Enabled = True
        tampildbgrid()
        autonumber()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call kosong()
        Button1.Enabled = True
        Call autonumber()
    End Sub
End Class
