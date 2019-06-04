Imports System.Data.OleDb
Public Class DaftarPasien

    Sub simpanloghapus()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menghapus Pasien " + Label2.Text
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
            str = "Delete * from pasien where idpasien = '" & Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pasien Berhasil Dihapus")
            Call simpanloghapus()
            Call Tampilpasien()
        Catch ex As Exception
            MessageBox.Show("Pasien Gagal Dihapus")
        End Try
    End Sub

    Sub Tampilpasien()
        da = New OleDbDataAdapter("select * from pasien where idpasien like '%" & Trim(TextBox1.Text) & _
                                      "%' or nama like '%" & Trim(TextBox1.Text) & _
                                      "%' or alamat like '%" & Trim(TextBox1.Text) & "%' order by idpasien asc", cnn)

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pasien")

        DataGridView1.DataSource = ds.Tables("pasien")
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(4).Width = 180
        DataGridView1.Refresh()
    End Sub
    
    Private Sub DaftarPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        Call koneksi()
        Tampilpasien()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
            Label2.Text = .Item(2, ubah).Value
        End With
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pasien.Show()
        Pasien.TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih data pasien yang akan diupdate/hapus")
        Else
            Pasien.Button1.Text = "PERBAHARUI"
            Pasien.lbledit.Text = "1"
            Pasien.Show()
            Pasien.TextBox1.Text = Label1.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih pasien yang akan diupdate/hapus")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus pasien ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call Hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CetakKartuBerobat.kartuberobat1.SetParameterValue("idpasien", Label1.Text)
        CetakKartuBerobat.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Tampilpasien()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        TextBox1.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class