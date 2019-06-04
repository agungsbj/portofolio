Imports System.Data.OleDb
Public Class LihatRM
    Sub kosong()
        TextBox1.Clear()
        TextBox9.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox1.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
    End Sub
    Sub pasien()
        cmd = New OleDbCommand("SELECT *FROM pasien WHERE idpasien='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            TextBox9.Text = dr.Item(2)
            TextBox2.Text = dr.Item(3)
            TextBox3.Text = dr.Item(4)
            TextBox4.Text = dr.Item(5)
            TextBox5.Text = dr.Item(6)
        Else
            TextBox9.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If
    End Sub
    Sub bacarm()
        Call koneksi()
        cmd = New OleDbCommand("SELECT *FROM rekammedis WHERE idpasien='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox6.Text = dr.Item(6)
            TextBox7.Text = dr.Item(5)
            TextBox8.Text = dr.Item(4)
            TextBox10.Text = dr.Item(7)
            tampilnoreg()
            Tampilriwayatrm()
            Tampilriwayatrmobat()
        Else
            MsgBox("Pasien Belum Punya Riwayat Pemeriksaan", MsgBoxStyle.Information)
            kosong()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox10.Clear()
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Datapasien.ShowDialog()
    End Sub
    Sub Tampilriwayatrm()
        Call koneksi()
        da = New OleDbDataAdapter("select tglperiksa,diagnosis from rekammedis where idpasien like '%" & Trim(TextBox1.Text) & "%' and noregister like '%" & Trim(ComboBox1.Text) & "%' order by noregister asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Refresh()
        DataGridView1.Columns(0).Width = "110"
        DataGridView1.Columns(1).Width = "200"
    End Sub
    Sub Tampilriwayatrmobat()
        Call koneksi()
        da = New OleDbDataAdapter("select rekammedisdetail.kdobat, obat.namaobat, rekammedisdetail.pemakaian from rekammedisdetail inner join obat on rekammedisdetail.kdobat = obat.kdobat where noregister like '%" & Trim(ComboBox1.Text) & "%' order by noregister asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView2.DataSource = ds.Tables("detail")
        DataGridView2.Refresh()
        DataGridView2.Columns(0).Width = "110"
        DataGridView2.Columns(1).Width = "80"
        DataGridView2.Columns(2).Width = "80"
    End Sub

    Private Sub LihatRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Call koneksi()
    End Sub
    Sub tampilnoreg()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Using cnn As New OleDbConnection(path)
            Try
                cnn.Open()
                Using cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select noregister from rekammedis where idpasien= '" & TextBox1.Text & "'"
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    Me.ComboBox1.DataSource = dt
                    Me.ComboBox1.DisplayMember = "noregister"
                    Me.ComboBox1.ValueMember = "noregister"
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Tampilriwayatrm()
        Tampilriwayatrmobat()
        cmd = New OleDbCommand("SELECT *FROM rekammedis WHERE noregister='" & ComboBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox6.Text = dr.Item(6)
            TextBox7.Text = dr.Item(5)
            TextBox8.Text = dr.Item(4)
            TextBox10.Text = dr.Item(7)
        End If
    End Sub

End Class