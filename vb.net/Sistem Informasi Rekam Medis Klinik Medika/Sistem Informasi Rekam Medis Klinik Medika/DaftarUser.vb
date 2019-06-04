Imports System.Data.OleDb
Public Class DaftarUser

    Sub simpanlog()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menghapus User " + Label2.Text
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
            str = "Delete * from pengguna where username = '" & Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User Berhasil Dihapus")
            Call simpanlog()
            Call Tampiluser()
        Catch ex As Exception
            MessageBox.Show("User Gagal Dihapus")
        End Try
    End Sub

    Sub Tampiluser()
        Call koneksi()
        da = New OleDbDataAdapter("select * from pengguna where username like '%" & Trim(TextBox1.Text) & _
                                      "%' or nama like '%" & Trim(TextBox1.Text) & _
                                      "%' or hakakses like '%" & Trim(TextBox1.Text) & _
                                      "%' or alamat like '%" & Trim(TextBox1.Text) & "%' order by username desc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengguna")

        DataGridView1.DataSource = ds.Tables("pengguna")
        DataGridView1.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        User.Show()
    End Sub

    Private Sub DaftarUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        Tampiluser()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
            Label2.Text = .Item(2, ubah).Value
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih user yang akan diupdate/hapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus user ? ", vbQuestion + vbYesNo, "pesan")
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
            User.Button1.Text = "PERBAHARUI"
            User.lbledit.Text = "1"
            User.Show()
            User.TextBox1.Text = Label1.Text
        End If
    End Sub

   

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Tampiluser()
    End Sub
End Class