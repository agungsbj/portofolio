Imports System.Data.OleDb
Public Class InputGuru

    Sub Tampilguru()
        da = New OleDbDataAdapter("select * from guru where nip like '%" & Trim(TextBox6.Text) & _
                                      "%' or nama like '%" & Trim(TextBox6.Text) & "%' order by nip asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "guru")

        DataGridView1.DataSource = ds.Tables("guru")
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 120
        DataGridView1.Columns(0).HeaderText = "NIP"
        DataGridView1.Columns(1).HeaderText = "NAMA GURU"
        DataGridView1.Columns(2).HeaderText = "JABATAN"
        DataGridView1.Columns(3).HeaderText = "ALAMAT"
        DataGridView1.Columns(4).HeaderText = "KOMPETENSI"
        DataGridView1.Refresh()
    End Sub
    Sub kosong()
        Call koneksi()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        labelkode.Text = "-"
    End Sub
    Sub edit()
        GroupBox1.Enabled = True
        Me.Size = New Point(828, 582)
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox2.Focus()
    End Sub
    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox1.Enabled = True
        Me.Size = New Point(828, 582)
        Button1.Enabled = True
        Button2.Enabled = False
        TextBox1.Clear()
        TextBox1.Focus()
        Tampilguru()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If labelkode.Text = "-" Then
            MsgBox("Pilih guru yang akan di edit / hapus")
        Else
            edit()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If labelkode.Text = "-" Then
            MsgBox("Pilih guru yang akan di edit / hapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus guru ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call hapus()
            Else
                Button1.Focus()
            End If
        End If
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim str As String
            str = "INSERT INTO guru VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & _
                "', '" & TextBox4.Text & "', '" & TextBox5.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Simpan Data Berhasil")
            Call kosong()
            Button3.PerformClick()
        Catch ex As Exception
            MsgBox("Gagal Menyimpan Data Karena " + ex.Message)
        End Try


        Me.Size = New Point(828, 460)
        Tampilguru()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim str As String
            str = "Update guru set nama = '" & TextBox2.Text & _
                 "', jabatan  = '" & ComboBox1.Text & "', alamat = '" & TextBox4.Text & _
                 "', kompetensi = '" & TextBox5.Text & "' where nip = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Guru Berhasil")
            Call kosong()
        Catch ex As Exception
            MsgBox("Gagal Mengedit Guru Karena " + ex.Message)
        End Try

        Me.Size = New Point(828, 460)
        Tampilguru()
    End Sub
    Sub hapus()
        Try
            Dim str As String
            str = "Delete * from guru where nip = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Guru Berhasil Dihapus")
            Call kosong()
        Catch ex As Exception
            MsgBox("Gagal Menghapus Guru Karena " + ex.Message)
        End Try
        Tampilguru()
    End Sub

  
    Private Sub InputGuru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Me.Size = New Point(828, 460)
        Tampilguru()
        Call kosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Size = New Point(828, 460)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        TextBox6.Clear()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Tampilguru()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("SELECT *FROM guru WHERE nip='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox2.Text = dr.Item(1)
            ComboBox1.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
            TextBox5.Text = dr.Item(4)
        Else
            TextBox2.Clear()
            ComboBox1.SelectedIndex = -1
            TextBox4.Clear()
            TextBox5.Clear()
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                FormPenilaian.Label1.Text = .Item(1, ubah).Value
                FormPenilaian.Label3.Text = .Item(2, ubah).Value
            End With
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try

        cmd = New OleDbCommand("SELECT *FROM loghasil WHERE nip='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MessageBox.Show("Guru dengan NIP " + TextBox1.Text + " Sudah Dinilai, silahkan pilih guru lain")
            FormPenilaian.Size = New Point(752, 186)
        Else
            Me.Close()
            FormPenilaian.Size = New Point(752, 374)
        End If

        
    End Sub
End Class