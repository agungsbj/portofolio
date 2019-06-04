Imports System.Data.OleDb
Public Class Pembayaran
    Sub Hitungtotalobat()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView2.Rows.Count - 1
            total = total + Val(DataGridView2.Rows(t).Cells(2).Value)
        Next
        TextBox11.Text = total
    End Sub
    Sub Hitungtotalbiaya()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + Val(DataGridView1.Rows(t).Cells(1).Value)
        Next
        TextBox10.Text = total
    End Sub
    Sub Tampilrmobat()
        Call koneksi()

        da = New OleDbDataAdapter("select kdobat,jml,biayaobat from rekammedisdetail where noregister like '%" & Trim(TextBox2.Text) & "%' order by noregister asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView2.DataSource = ds.Tables("detail")
        DataGridView2.Refresh()
        Hitungtotalobat()
    End Sub
    Sub Tampilrm()
        Call koneksi()

        da = New OleDbDataAdapter("select diagnosis,biayaperiksa from rekammedis where noregister like '%" & Trim(TextBox2.Text) & "%' order by noregister asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Refresh()
        Hitungtotalbiaya()
    End Sub
    Private Sub Pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikanan(Me, True)
        Call koneksi()
        Call kosong()
    End Sub
    Sub nootomatis()
        TextBox1.Text = "KL-" + Format(Now, "HHmmssddMMyy")
    End Sub
    Sub kosong()
        nootomatis()
        ComboBox1.SelectedIndex = -1
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        TextBox2.Clear()
        TextBox9.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        DateTimePicker1.Value = Now
    End Sub
    Private Sub TextBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.DoubleClick
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        cmd = New OleDbCommand("SELECT *FROM rekammedis WHERE noregister='" & TextBox2.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtidpas.Text = dr.Item(3)
            Call Tampilrm()
            Call Tampilrmobat()
            Dim hasil As Double
            hasil = Val(TextBox10.Text) + Val(TextBox11.Text)
            TextBox12.Text = hasil
            TextBox14.Focus()
        Else
            DataGridView1.DataSource = Nothing
            DataGridView2.DataSource = Nothing
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
        End If

        cmd = New OleDbCommand("SELECT *FROM pasien WHERE idpasien='" & txtidpas.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox3.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
            TextBox5.Text = dr.Item(4)
            TextBox6.Text = dr.Item(5)
            TextBox7.Text = dr.Item(6)
        Else
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            TextBox9.Text = "-"
            TextBox2.Clear()
            TextBox2.Focus()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            TextBox9.Clear()
            TextBox9.Focus()
            Call kosong2()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        cmd = New OleDbCommand("SELECT *FROM skes WHERE no_surat='" & TextBox9.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            TextBox8.Text = dr.Item(3)
        Else
            TextBox8.Clear()
        End If
    End Sub
    Sub kosong2()
        TextBox2.Text = "-"
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
        TextBox10.Text = "25000"
        TextBox11.Text = "0"
        Dim hasil As String
        hasil = Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = hasil
    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(TextBox14.Text) < Val(TextBox12.Text) Then
                MessageBox.Show("Pembayaran Kurang!!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox13.Text = "0"
            Else
                TextBox13.Text = Val(TextBox14.Text) - Val(TextBox12.Text)
            End If
        End If
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub
    Sub Hapusantrian()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from antriankasir where noantrian = '" & Menukasir.Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox14.Text = "" Then
            MsgBox("Transaksi Belum Lengkap, lengkapi data yang diperlukan", MessageBoxIcon.Error)
        Else
                Call koneksi()

                Dim str As String

            str = "INSERT INTO pembayaran VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value & "','" & TextBox15.Text & _
                "', '" & ComboBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox9.Text & "', '" & TextBox12.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                Hapusantrian()
                MessageBox.Show("Pembayaran Berhasil")

                If ComboBox1.SelectedIndex = 0 Then
                    tampilnota()
                ElseIf ComboBox1.SelectedIndex = 1 Then
                    tampilkwitansi()
                    tampilskes()
                End If

                Call kosong()
                Menukasir.Label1.Text = "-"
                Menukasir.Label2.Text = "-"
                Menukasir.Label3.Text = "-"
            Menukasir.Tampilantrian()

            Me.Dispose()
            Menukasir.Show()
            Call Menukasir.Hitungtotal()
            Call Menukasir.cuaca()
            Menukasir.Panel1.Visible = False
            Call Menukasir.notif()
            
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Pembayaran Dibatalkan", MessageBoxIcon.Information)
        kosong()
    End Sub
    Sub tampilnota()
        CetakNota.Nota1.SetParameterValue("notrans", TextBox1.Text)
        CetakNota.Show()
    End Sub
    
    Sub tampilkwitansi()
        CetakKwitansi.kwitansi1.SetParameterValue("notrans", TextBox1.Text)
        CetakKwitansi.Show()
    End Sub
    Sub tampilskes()
        SuratKesehatan.kesehatan1.SetParameterValue("nosurat", TextBox9.Text)
        SuratKesehatan.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class