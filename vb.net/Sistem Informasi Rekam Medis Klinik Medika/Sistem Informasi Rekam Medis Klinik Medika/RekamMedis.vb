Imports System.Data.OleDb
Public Class RekamMedis
    Sub Tampilrmobat()
        Call koneksi()
        da = New OleDbDataAdapter("select kdobat,jml,pemakaian,biayaobat from rekammedisdetail where noregister like '%" & TextBox16.Text & "%' order by noregister asc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")

        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Columns(0).Width = 160
        DataGridView1.Refresh()
    End Sub
    Sub kurangstokobat()
        Dim str As String
        str = "Update obat set stok = '" & Lblstokbaru.Text & "' where kdobat = '" & Lblkd.Text & "'"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpanobat()
        If Lblkd.Text = "" Or lblharga.Text = "" Or lblnama.Text = "" Or lblstok.Text = "" Or lblsub.Text = "" Or TextBox12.Text = "" Or TextBox14.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO rekammedisdetail VALUES ('" & TextBox16.Text & "','" & Lblkd.Text & _
                    "', '" & TextBox12.Text & "', '" & TextBox14.Text & "', '" & lblsub.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                Call kurangstokobat()
                MessageBox.Show("Berhasil")
                TextBox12.Clear()
                TextBox14.Clear()
                Label28.Text = ""
                Call Tampilrmobat()
                Call listdata()
                Call kosong2()
            Catch ex As Exception
                MessageBox.Show("Gagal")
            End Try
        End If
    End Sub

    Sub listdata()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer
        aksi = "select * from obat where status like '%" & Trim(lblstatus.Text) & "%' order by status asc"
        Call koneksi()

        Dim cmd As New OleDbCommand(aksi, cnn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader

        Try
            While dr.Read
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1)

                With ListView1
                    ListView1.Items.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dr.GetString(1)
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(3)
                    ListView1.Items(x).SubItems(3).Text = dr.GetDecimal(7)
                    ListView1.Items(x).SubItems(4).Text = dr.GetValue(8)
                    ListView1.Items(x).SubItems(5).Text = dr.GetString(9)
                    ListView1.Items(x).SubItems(6).Text = dr.GetString(10)
                End With
            End While
        Finally
            dr.Close()

        End Try
    End Sub
    Sub listdata2()
        Call clearlist()
        Dim aksi As String
        Dim x As Integer
        aksi = "select * from obat where status like '%" & Trim(lblstatus.Text) & "%' and namaobat like '%" & Trim(TextBox13.Text) & "%' order by status asc"
        Call koneksi()

        Dim cmd As New OleDbCommand(aksi, cnn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader

        Try
            While dr.Read
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1)

                With ListView1
                    ListView1.Items.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dr.GetString(1)
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(3)
                    ListView1.Items(x).SubItems(3).Text = dr.GetDecimal(7)
                    ListView1.Items(x).SubItems(4).Text = dr.GetValue(8)
                    ListView1.Items(x).SubItems(5).Text = dr.GetString(9)
                    ListView1.Items(x).SubItems(6).Text = dr.GetString(10)
                End With
            End While
        Finally
            dr.Close()

        End Try
    End Sub
    Public Sub clearlist()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub

    Sub caripasien()
        cmd = New OleDbCommand("SELECT *FROM pasien WHERE idpasien='" & TextBoxIDPas.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox1.Text = dr.Item(2)
            TextBox2.Text = dr.Item(3)
            TextBox3.Text = dr.Item(4)
            TextBox4.Text = dr.Item(5)
            TextBox5.Text = dr.Item(6)
            TextBox6.Focus()
        Else
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBoxIDPas.Focus()
        End If
    End Sub
    Sub pilih()
        Try
            Lblkd.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            lblnama.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
            lblharga.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
            lblstok.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
            Label28.Text = ListView1.SelectedItems(0).SubItems(5).Text.ToString
            TextBox12.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Sub kosong2()
        lblkode2.Text = ""
        lblnama.Text = ""
        lblharga.Text = ""
        lblstok.Text = ""
        lblsub.Text = ""
        Lblstokbaru.Text = ""
        lblselisih.Text = ""
        Label24.Text = ""
        lblkode2.Text = ""
        lblstok2.Text = ""
        Lblstokbaru.Text = ""
        lbltotalobat.Text = ""
        lbltotal.Text = ""
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        ComboBox2.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        GroupBox1.Enabled = True
        DateTimePicker1.Value = Now
    End Sub

    Private Sub RekamMedis_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampiltarif()
    End Sub
    Sub noreg()
        TextBox16.Text = "REG" + Format(Now, "ddMyyHHmmss")
    End Sub
    Private Sub FormRekamMedis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Call koneksi()
        Call listdata()
        Call Tampilrmobat()
        Call kosong()
        Call autonumberantrian()
        Call noreg()
        ComboBox1.SelectedIndex = -1
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Call pilih()
    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
               e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(TextBox12.Text) > Val(lblstok.Text) Then
                MessageBox.Show("Stok Kurang", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox12.Focus()
            Else
                Dim total As Integer
                total = Val(TextBox12.Text) * Val(lblharga.Text)
                lblsub.Text = Format(total, "#,#0")
                Lblstokbaru.Text = Val(lblstok.Text) - Val(TextBox12.Text)
                TextBox14.Focus()
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cmd = New OleDbCommand("SELECT *FROM rekammedisdetail WHERE kdobat='" & Lblkd.Text & "' and noregister='" & TextBox16.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            MessageBox.Show("Obat telah ditambahkan sebelumnya. Klik tombol Perbaharui Untuk menambahkan jumlah obat", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call simpanobat()
        End If
    End Sub
    Sub hapusobat()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete from rekammedisdetail where kdobat='" & lblkode2.Text & "' and noregister='" & TextBox16.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            Call updstokobathapus()
            MessageBox.Show("Obat Dihapus")
            TextBox12.Clear()
            TextBox14.Clear()
            Label28.Text = ""
            Call kosong2()
        Catch ex As Exception
            MessageBox.Show("Gagal Dihapus")
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                lblkode2.Text = .Item(0, ubah).Value
                lblstok2.Text = .Item(1, ubah).Value
            End With

            cmd = New OleDbCommand("SELECT *FROM obat WHERE kdobat='" & lblkode2.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Lblkd.Text = dr.Item(0)
                lblnama.Text = dr.Item(1)
                lblharga.Text = dr.Item(7)
                lblstok.Text = dr.Item(8)
                Lblstokbaru.Text = dr.Item(8)
            Else
                Lblkd.Text = ""
                lblnama.Text = ""
                lblharga.Text = ""
                lblstok.Text = ""
                Lblstokbaru.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub updstokobathapus()
        Dim str As String
        str = "Update obat set stok = '" & lblstokbaru2.Text & "' where kdobat = '" & Lblkd.Text & "'"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan menghapus obat ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            lblstokbaru2.Text = Val(lblstok2.Text) + Val(Lblstokbaru.Text)
            Call hapusobat()
            Call Tampilrmobat()
            Call listdata()
        Else
            Button5.Focus()
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                lblkode2.Text = .Item(0, ubah).Value
                lblstok2.Text = .Item(1, ubah).Value
                TextBox12.Text = .Item(1, ubah).Value
                lblselisih.Text = .Item(1, ubah).Value
                TextBox14.Text = .Item(2, ubah).Value
                lblsub.Text = .Item(3, ubah).Value
            End With

            cmd = New OleDbCommand("SELECT *FROM obat WHERE kdobat='" & lblkode2.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Label28.Text = dr.Item(9)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub updstokobat()
        Dim str As String
        str = "Update obat set stok = '" & Label24.Text & "' where kdobat = '" & Lblkd.Text & "'"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub updateobat()
            Call koneksi()
        Try
            lblselisih.Text = Val(lblstok2.Text) - Val(TextBox12.Text)
            Label24.Text = Val(lblselisih.Text) + Val(lblstok.Text)
            Dim str As String
            str = "Update rekammedisdetail set jml = '" & TextBox12.Text & "', pemakaian = '" & TextBox14.Text & "', biayaobat = '" & lblsub.Text & "' where kdobat = '" & lblkode2.Text & "' and noregister='" & TextBox16.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            Call updstokobat()
            MessageBox.Show("data obat berhasil di perbaharui")
            TextBox12.Clear()
            TextBox14.Clear()
            Call Tampilrmobat()
            Call listdata()
            Label28.Text = ""
        Catch ex As Exception
            MsgBox("Gagal karena " + ex.Message)
        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        updateobat()
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
               e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "/" Or
               e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "x" Or
               e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            Button4.PerformClick()
        End If
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        listdata2()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox10.Clear()
        TextBox15.Clear()
        TextBox11.Clear()
    End Sub

    Sub Simpan()
        If TextBoxIDPas.Text = "" Or lbltotal.Text = "" Then
            MessageBox.Show("Transaksi belum selesai, lengkapi data yang diperlukan")

        Else
            Try
                Dim simpanhasilrm As String = String.Empty
                simpanhasilrm = "insert into rekammedis values('" & TextBox16.Text & "','" & DateTimePicker1.Value & _
                        "','" & TextBox9.Text & "','" & TextBoxIDPas.Text & "','" & TextBox8.Text & _
                        "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & ComboBox2.Text & "','" & TextBox10.Text & _
                        "','" & TextBox15.Text & "','" & TextBox11.Text & "','" & txtharga.Text & "')"

                Dim perintahsimpan3 As OleDbCommand = New OleDbCommand(simpanhasilrm, cnn)
                perintahsimpan3.ExecuteNonQuery()

                Call Hapusantrian()
                Call simpanantrian()

                MsgBox("Simpan Hasil Rekam Medis Berhasil", MsgBoxStyle.OkOnly, MessageBoxIcon.Information)
                Call kosong()
                Call kosong2()
                TextBoxIDPas.Clear()
                Call Tampilrmobat()
                Call listdata()
                Call MenuRM.Tampilantrian()
                MenuRM.Label1.Text = "-"
                MenuRM.Label2.Text = "-"
                MenuRM.Label3.Text = "-"
                Me.Dispose()
                MenuRM.Show()
                MenuRM.Hitungtotal()
                MenuRM.Panel1.Visible = False
                MenuRM.notif()
            Catch ex As Exception
                MsgBox("Gagal karena " + ex.Message)
            End Try
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call Hitungtotalobat()
        lbltotal.Text = Val(txtharga.Text) + Val(lbltotalobat.Text)
        Simpan()
    End Sub
    Sub Hitungtotalobat()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + Val(DataGridView1.Rows(t).Cells(3).Value)
        Next
        lbltotalobat.Text = total
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim total As Integer
        total = DataGridView1.Rows.Count

        Dim pesan As String
        pesan = MsgBox("Yakin akan membatalkan pemeriksaan ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            If total = "0" Then
                Call kosong()
                TextBoxIDPas.Clear()
                Me.Dispose()
            Else
                MsgBox("Hapus data pemeriksaan dan obat lebih dulu!!!", MsgBoxStyle.Critical)
            End If
        Else
            Button9.Focus()
        End If
    End Sub

    Private Sub TextBoxIDPas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxIDPas.TextChanged
        caripasien()
        bacarm()
    End Sub
    Sub bacarm()
        Call koneksi()
        cmd = New OleDbCommand("SELECT *FROM rekammedis WHERE idpasien='" & TextBoxIDPas.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox8.Text = dr.Item(4)
            TextBox7.Text = dr.Item(5)
            TextBox6.Text = dr.Item(6)
            ComboBox2.Text = dr.Item(7)
        Else
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox6.Clear()
            ComboBox2.Text = ""
        End If
    End Sub
    Sub autonumberantrian()
        cmd = New OleDbCommand("Select * from antriankasir where noantrian in (select max(noantrian) from antriankasir) order by noantrian desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        lblantrian.Text = urutan
    End Sub
    Sub simpanantrian()
        Try
            Call koneksi()
            Dim nosurat As String
            nosurat = "-"
            Dim str As String

            str = "INSERT INTO antriankasir VALUES ('" & lblantrian.Text & "','" & TextBox16.Text & "','" & nosurat & "','" & TextBox1.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Pasien telah ditambahkan pada antrian kasir", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Menambahkan ke Antrian Gagal")
        End Try
    End Sub
    Sub Hapusantrian()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from antrian where noantrian = '" & MenuRM.Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub

    Private Sub TextBoxIDRM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        GroupBox4.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Call RiwayatRM.Tampilriwayatrm()
        RiwayatRM.ShowDialog()
    End Sub
    Sub hitungkunjungan()
        cmd = New OleDbCommand("select count(*) from rekammedis where idpasien ='" & TextBoxIDPas.Text & "'", cnn)
        Dim rsu As Integer
        rsu = cmd.ExecuteScalar
        Lblkunj.Text = rsu + 1
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Tampilrmobat()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim total As Integer
        total = DataGridView1.Rows.Count

        Dim pesan As String
        pesan = MsgBox("Kembali ke Menu Rekam Medis ? ", vbQuestion + vbYesNo, "pesan")
        If pesan = vbYes Then
            If total = "0" Then
                Call kosong()
                TextBoxIDPas.Clear()
                Me.Dispose()
            Else
                MsgBox("Hapus data pemeriksaan dan obat lebih dulu!!!", MsgBoxStyle.Critical)
            End If
        Else
            Button9.Focus()
        End If
    End Sub
    Sub tampiltarif()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Using cnn As New OleDbConnection(path)
            Try
                cnn.Open()
                Using cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select idtarif, namatarif from tarif"
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    Me.ComboBox1.DataSource = dt
                    Me.ComboBox1.DisplayMember = "namatarif"
                    Me.ComboBox1.ValueMember = "idtarif"
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OleDbCommand("SELECT *FROM tarif WHERE namatarif='" & ComboBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox17.Text = dr.Item(0)
            txtharga.Text = dr.Item(2)
        Else
            TextBox17.Clear()
            txtharga.Clear()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class