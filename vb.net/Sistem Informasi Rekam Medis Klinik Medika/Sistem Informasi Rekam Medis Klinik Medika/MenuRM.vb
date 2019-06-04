Imports System.Data.OleDb
Public Class MenuRM
    Sub Tampilantrian()
        Call koneksi()
        da = New OleDbDataAdapter("Select * From antrian", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "antrian")

        DataGridView1.DataSource = ds.Tables("antrian")
        DataGridView1.Refresh()
    End Sub
    Sub cuaca()
        Dim jam As String
        jam = Format(Now, "HH")

        If jam <= 4 Then
            Label9.Text = "Dini Hari"
        ElseIf jam <= 10 Then
            Label9.Text = "Pagi"
        ElseIf jam <= 14 Then
            Label9.Text = "Siang"
        ElseIf jam <= 17 Then
            Label9.Text = "Sore"
        ElseIf jam = 18 Then
            Label9.Text = "Petang"
        ElseIf jam <= 23 Then
            Label9.Text = "Malam"
        End If
    End Sub
    Sub notif()
        Panel1.Visible = False
        If Label6.Text = 0 Then
            Button7.Visible = True
            Button6.Visible = False
        Else
            Button6.Visible = True
            Button7.Visible = False
        End If
    End Sub
    Private Sub MenuRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Call koneksi()
        Call Tampilantrian()
        GroupBox1.Visible = False
        Me.Height = 347
        Hitungtotal()
        cuaca()
        Panel1.Visible = False
        notif()
    End Sub
    Sub Hitungtotal()
        Dim total As Integer
        total = DataGridView1.Rows.Count
        Label6.Text = total
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
            label2.text = .Item(1, ubah).Value
        End With

        cmd = New OleDbCommand("SELECT *FROM rekammedis WHERE idpasien='" & Label2.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            Label3.Text = dr.Item(3)
        Else
            Label3.Text = "Belum Terdaftar Rekam Medis"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label3.Text = "_" Then
            MsgBox("Pilih antrian pasien dahulu")
        ElseIf Label3.Text = "Belum Terdaftar Rekam Medis" Then
            RekamMedis.Show()
            RekamMedis.TextBoxIDPas.Text = Label2.Text
            RekamMedis.TextBox6.Focus()
        Else
            RekamMedis.Show()
            RekamMedis.TextBoxIDPas.Text = Label3.Text
            RekamMedis.TextBox10.Focus()
        End If
        RekamMedis.TextBox9.Text = lblnama.Text
        Call RekamMedis.hitungkunjungan()
        Call RekamMedis.noreg()
        Call RekamMedis.autonumberantrian()
        RekamMedis.ComboBox1.SelectedIndex = -1
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from antrian where noantrian = '" & Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sukses")
            Tampilantrian()
            Hitungtotal()
            cuaca()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Text = "_" Then
            MsgBox("Pilih Antrian Dahulu")
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin akan menghapus antrian ? ", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                Call Hapus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = True
        Me.Height = 610
        Me.CenterToScreen()
    End Sub


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        GroupBox1.Visible = False
        Me.Height = 321
        Me.CenterToScreen()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LapRM.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            cuaca()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel1.Visible = True
        Button6.Visible = False
        Button7.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        LihatRM.ShowDialog()
    End Sub
End Class