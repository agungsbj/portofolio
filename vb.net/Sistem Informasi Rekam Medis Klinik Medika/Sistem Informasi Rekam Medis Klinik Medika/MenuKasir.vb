Imports System.Data.OleDb
Public Class Menukasir
    Sub Tampilantrian()
        Call koneksi()
        da = New OleDbDataAdapter("Select * From antriankasir", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "antriankasir")

        DataGridView1.DataSource = ds.Tables("antriankasir")
        DataGridView1.Refresh()
    End Sub
    Sub notif()
        Panel1.Visible = False
        If Label7.Text = 0 Then
            Button7.Visible = True
            Button8.Visible = False
        Else
            Button8.Visible = True
            Button7.Visible = False
        End If
    End Sub
    Private Sub MenuRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
        Call koneksi()
        Call Tampilantrian()
        GroupBox1.Visible = False
        Hitungtotal()
        cuaca()
        Panel1.Visible = False
        notif()
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
    Sub Hitungtotal()
        Dim total As Integer
        total = DataGridView1.Rows.Count
        Label7.Text = total
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label1.Text = .Item(0, ubah).Value
            Label2.Text = .Item(1, ubah).Value
            Label3.Text = .Item(2, ubah).Value
            Label5.Text = .Item(3, ubah).Value

        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label3.Text = "-" Then
            Pembayaran.Show()
            Pembayaran.TextBox15.Text = lblnama.Text
            Pembayaran.ComboBox1.SelectedIndex = 0
            Pembayaran.TextBox2.Text = Label2.Text
            Pembayaran.TextBox14.Focus()
        ElseIf Label2.Text = "-" Then
            Pembayaran.Show()
            Pembayaran.TextBox15.Text = lblnama.Text
            Pembayaran.ComboBox1.SelectedIndex = 1
            Pembayaran.TextBox9.Text = Label3.Text
            Pembayaran.TextBox14.Focus()
        End If
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from antriankasir where noantrian = '" & Label1.Text & "'"
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
        DaftarObat.lblnama.Text = lblnama.Text
        DaftarObat.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox1.Visible = True
        Me.Height = 599
        Me.CenterToScreen()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lapuang.ShowDialog()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        GroupBox1.Visible = False
        Me.Height = 356
        Me.CenterToScreen()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Panel1.Visible = True
        Button8.Visible = False
        Button7.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DaftarPembayaran.ShowDialog()
    End Sub
End Class