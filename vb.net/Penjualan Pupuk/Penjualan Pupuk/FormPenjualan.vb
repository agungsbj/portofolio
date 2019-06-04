Imports System.Data.OleDb
Public Class FormPenjualan

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormLihatBarang.Show()
    End Sub

    Private Sub txtkdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdbrg.TextChanged
        Dim aksi2 As String = String.Empty
        aksi2 = "select * from tempisipenjualan where idbrg='" & txtkdbrg.Text & "' "

        Dim cmmd As New OleDbCommand(aksi2, cnn)
        Dim dr As OleDbDataReader
        dr = cmmd.ExecuteReader

        If dr.Read Then
            MsgBox("Barang sudah ada dalam daftar belanja, hapus barang dahulu jika ingin menambahkan barang yang sama")
        Else
            Dim aksi As String = String.Empty
            aksi = "select * from barang where idbrg='" & txtkdbrg.Text & "' "

            Dim cmd As New OleDbCommand(aksi, cnn)
            Dim dreader As OleDbDataReader
            dreader = cmd.ExecuteReader

            If dreader.Read Then
                txtnmbrg.Text = dreader.Item(1)
                txtharga.Text = Format(dreader.Item(6), "n")
                Label3.Text = dreader.Item(3)
                Label3a.Text = dreader.Item(4)
                txtjml.Focus()
            End If

            If Label3.Text = "0" Then
                MessageBox.Show("Maaf stok habis", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Label3.Text = "-"
                txtkdbrg.Clear()
                txtnmbrg.Clear()
                txtharga.Clear()
                txtkdbrg.Focus()
            End If

        End If
    End Sub

    Private Sub txtjml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtjml.Text = "0" Or txtjml.Text = "" Then
                MsgBox("Masukan jumlah barang")
            Else
                If Val(txtjml.Text) > Val(Label3.Text) Then
                    MessageBox.Show("Stok Kurang", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtjml.Focus()
                Else
                    Label16.Text = Val(Label3.Text) - Val(txtjml.Text)
                    Dim harga, jumlah, total As Double
                    harga = txtharga.Text
                    jumlah = CInt(txtjml.Text)
                    total = harga * jumlah
                    txttotal.Text = Format(total, "n")
                    Button6.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub NoOtomatis()
        cmd = New OleDbCommand("Select * from Penjualan where No_transaksi in (select max(No_transaksi) from Penjualan) order by no_transaksi desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "NO" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(dr.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "NO" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
                urutan = "NO" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        txtno.Text = urutan
    End Sub
    Sub refreshDGV()
        Dim dadapter As New OleDbDataAdapter("select idbrg,nama,hargajual,jumlah,satuan,subtotal from tempIsipenjualan", cnn)
        Dim tampung As New DataTable("tempIsipenjualan")
        dadapter.Fill(tampung)
        DGV.DataSource = tampung
        txtkdbrg.Focus()
    End Sub
    Sub kosong()
        Label16.Text = "0"
        Label3.Text = "-"
        Label3a.Text = "-"
        txtharga.Text = "0"
        txtkdbrg.Clear()
        txtnmbrg.Clear()
        txttotal.Text = "0"
        txtjml.Text = "0"
        txtdbyr.Text = "0"
        txtkembali.Text = "0"
        txttotalbiaya.Text = "0"
        Label5.Text = "0"
        TextBox3.Text = "0"
        ComboBox1.SelectedIndex = -1
        TextBox4.Text = "-"
        TextBox5.Text = "-"
        TextBox6.Text = "-"
    End Sub
    Sub CLEAR()
        Label16.Text = "0"
        Label3.Text = "-"
        Label3a.Text = "-"
        txtharga.Text = "0"
        txtkdbrg.Clear()
        txtnmbrg.Clear()
        txttotal.Text = "0"
        txtjml.Text = "0"
        Call NoOtomatis()
    End Sub

    Sub TidakAktif()
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
        DGV.Enabled = False
        Button1.Enabled = True
        Button4.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        txttotalbiaya.Enabled = False
        txtdbyr.Enabled = False
        txtkembali.Enabled = False
        Button7.Enabled = False
        ComboBox1.Enabled = False
        Panel2.Enabled = False
        CheckBox1.Enabled = False
        Button1.Focus()
    End Sub
    Sub aktif()
        Button1.Enabled = False
        GroupBox3.Enabled = True
        DGV.Enabled = True
        GroupBox1.Enabled = True
        Button4.Enabled = True
        txtdbyr.Enabled = True
        txtjml.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        txtdbyr.Enabled = True
        Button7.Enabled = True
        ComboBox1.Enabled = True
        CheckBox1.Enabled = True
        Button2.Focus()
    End Sub

    Private Sub FormPenjualan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'pilih barang
        If e.Control And e.KeyCode = Keys.F Then
            FormLihatBarang.Show()
        End If
    End Sub

    Private Sub FormPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadawal()
        Me.KeyPreview = True
    End Sub
    Sub loadawal()
        Call koneksi()
        Call NoOtomatis()
        Call refreshDGV()
        Call TidakAktif()
        Button1.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Silahkan Input Transaksi")
        Call aktif()
        Call kosong()
    End Sub
    Sub edit()
        Try
            Dim aksi1 As String = String.Empty
            aksi1 = "update tempisipenjualan set idbrg = '" & txtkdbrg.Text & "', nama = '" & txtnmbrg.Text & "', hargajual = '" & CInt(txtharga.Text) & "', jumlah = '" & txtjml.Text & "', subtotal = '" & CInt(txttotal.Text) & "' where idbrg = '" & txtkdbrg.Text & "'"
            Dim perintah1 As OleDbCommand = New OleDbCommand(aksi1, cnn)
            perintah1.ExecuteNonQuery()

            'kurangi stok
            Dim str As String
            str = "Update barang set stok = '" & Label16.Text & "' where idbrg = '" & txtkdbrg.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Data telah dirubah")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tambah()
        Dim aksi As String = String.Empty
        aksi = "insert into tempisipenjualan values('" & txtno.Text & "','" & txtkdbrg.Text & "','" & _
            txtnmbrg.Text & "','" & CInt(txtharga.Text) & "','" & txtjml.Text & "','" & Label3a.Text & "','" & CInt(txttotal.Text) & "')"
        Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
        perintah.ExecuteNonQuery()

        'kurangi stok
        Dim str As String
        str = "Update barang set stok = '" & Label16.Text & "' where idbrg = '" & txtkdbrg.Text & "'"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
        Call refreshDGV()
    End Sub
    Sub Hitungtotal()
        Dim totalberat As Double
        totalberat = 0
        For t As Integer = 0 To DGV.Rows.Count - 1
            totalberat = totalberat + Val(DGV.Rows(t).Cells(5).Value)
        Next
        txttotalbiaya.Text = totalberat
        Label5.Text = txttotalbiaya.Text
    End Sub
    Sub Hitungitem()
        Dim item As Integer
        item = 0
        For i As Integer = 0 To DGV.Rows.Count - 1
            item = item + Val(DGV.Rows(i).Cells(3).Value)
        Next
        TextBox3.Text = item
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If txttotal.Text = "" Or txttotal.Text = "0" Or txtjml.Text = "0" Then
            MsgBox("Tekan enter di kolom jumlah dahulu untuk melanjutkan transaksi", MsgBoxStyle.Information, "Peringatan")
            txtjml.Focus()
        Else
            Call koneksi()
            Call tambah()
            Call Hitungtotal()
            Call Hitungitem()
            Call CLEAR()
            Button2.Focus()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Call koneksi()
            Dim str As String
            str = "Delete from tempisipenjualan where idbrg='" & LabelID.Text & " '"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()

            'atur stok
            Dim str1 As String
            str1 = "Update barang set stok = '" & LabelStok.Text & "' where idbrg = '" & LabelID.Text & "'"
            cmd = New OleDbCommand(str1, cnn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Barang Dihapus")
            txtkdbrg.Clear()
            Call refreshDGV()
            Call Hitungitem()
            Call Hitungtotal()
        Catch ex As Exception
            MessageBox.Show("Gagal Dihapus")
        End Try
        Call refreshDGV()
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Call klik()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub klik()
        Dim ubah As Integer = Nothing
        ubah = DGV.CurrentRow.Index
        With DGV
            LabelID.Text = .Item(0, ubah).Value
            LabelJml.Text = .Item(3, ubah).Value
        End With

        'tampilkan stok skrg
        Dim aksi As String = String.Empty
        aksi = "select * from barang where idbrg='" & LabelID.Text & "' "

        Dim cmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmd.ExecuteReader

        If dreader.Read Then
            LabelStokSkrg.Text = dreader.Item(3)
        End If
        LabelStok.Text = Val(LabelStokSkrg.Text) + Val(LabelJml.Text)

    End Sub
    Public Sub Simpan()
        Try
            If txtdbyr.Text = "" Or txtkembali.Text = "" Then
                MessageBox.Show("Transaksi belum selesai, lengkapi data yang diperlukan")
                Button2.Focus()
            Else
                Dim hasilcari As String = String.Empty
                hasilcari = "select no_transaksi,idbrg,nama,hargajual,jumlah,satuan,subtotal from tempisipenjualan "

                Dim eksekusi As New OleDbCommand
                eksekusi = New OleDbCommand(hasilcari, cnn)
                Dim hasilcariku As OleDbDataReader
                hasilcariku = eksekusi.ExecuteReader
                If hasilcariku.Read Then
                    Do
                        Dim tempnotransaksi, tempidbarang, tempnamabarang, tempharga, tempjumlahbeli, tempsatuan, tempsubtotal As String
                        tempnotransaksi = hasilcariku.Item(0).ToString
                        tempidbarang = hasilcariku.Item(1).ToString
                        tempnamabarang = hasilcariku.Item(2).ToString
                        tempharga = hasilcariku.Item(3).ToString
                        tempjumlahbeli = hasilcariku.Item(4).ToString
                        tempsatuan = hasilcariku.Item(5).ToString
                        tempsubtotal = hasilcariku.Item(6).ToString

                        Dim aksisimpan As String
                        aksisimpan = "insert into isipenjualan values('" & tempnotransaksi & "','" & tempidbarang & _
                             "','" & tempjumlahbeli & "','" & tempsatuan & "','" & tempsubtotal & "')"

                        Dim eksekusijadi As OleDbCommand = New OleDbCommand(aksisimpan, cnn)
                        eksekusijadi.ExecuteNonQuery()

                    Loop While hasilcariku.Read
                End If

                If ComboBox1.SelectedIndex = 0 Then
                    Dim simpanpenjualan As String = String.Empty
                    simpanpenjualan = "insert into penjualan values('" & txtno.Text & "','" & DateTimePicker1.Value & _
                        "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & _
                        "','" & TextBox3.Text & "','" & CInt(txttotalbiaya.Text) & "','" & CInt(txtdbyr.Text) & "','" & CInt(txtkembali.Text) & _
                    "','" & ComboBox1.Text & "','" & "0" & "','" & "0" & "','" & TextBox4.Text & "')"

                    Dim perintahsimpan As OleDbCommand = New OleDbCommand(simpanpenjualan, cnn)
                    perintahsimpan.ExecuteNonQuery()

                ElseIf ComboBox1.SelectedIndex = 1 Then
                    Dim simpanpenjualan As String = String.Empty
                    simpanpenjualan = "insert into penjualan values('" & txtno.Text & "','" & DateTimePicker1.Value & _
                        "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & _
                        "','" & TextBox3.Text & "','" & CInt(txttotalbiaya.Text) & "','" & "0" & "','" & "0" & _
                        "','" & ComboBox1.Text & "','" & CInt(txtdbyr.Text) & "','" & CInt(txtkembali.Text) & "','" & TextBox4.Text & "')"

                    Dim perintahsimpan As OleDbCommand = New OleDbCommand(simpanpenjualan, cnn)
                    perintahsimpan.ExecuteNonQuery()
                End If


                Dim aksi As String = String.Empty
                aksi = "delete from tempisipenjualan where no_transaksi = '" & txtno.Text & "'"

                Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
                perintah.ExecuteNonQuery()


                MsgBox("Transaksi Berhasil Dilakukan", MsgBoxStyle.OkOnly)
                Call cetaknota()
                Call kosong()
                DGV.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Simpan()
    End Sub

    Private Sub txtdbyr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdbyr.KeyPress
        If e.KeyChar = Chr(13) Then
            If ComboBox1.SelectedIndex = 0 Then
                If Val(txtdbyr.Text) < Val(txttotalbiaya.Text) Then
                    MsgBox("Pembayaran Kurang", MsgBoxStyle.Critical)
                Else
                    txtkembali.Text = Val(txtdbyr.Text) - Val(txttotalbiaya.Text)
                End If
            ElseIf ComboBox1.SelectedIndex = 1 Then
                txtkembali.Text = Val(txttotalbiaya.Text) - Val(txtdbyr.Text)
            End If


        End If
    End Sub
    Private Sub txtdbyr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbyr.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (MessageBox.Show("Batalkan Transaksi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Dim aksi As String = String.Empty
            aksi = "delete from tempisipenjualan where no_transaksi = '" & txtno.Text & "'"

            Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
            perintah.ExecuteNonQuery()
            Call kosong()
        Else
            txtkdbrg.Focus()

        End If
    End Sub
    Sub cetaknota()
        cetaknotaangsur.notaangsur1.SetParameterValue("notrans", txtno.Text)
        cetaknotaangsur.notaangsur1.SetParameterValue("notrans1", txtno.Text)

        cetaknotaangsur.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label10.Text = "Dibayar"
            Label4.Text = "Kembali"
            txtdbyr.Focus()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label10.Text = "DP"
            Label4.Text = "Kurang"
            txtdbyr.Focus()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel1.Visible = True
        TextBox4.Focus()
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        Panel1.Visible = False
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim aksi As String = String.Empty
            aksi = "select * from pelanggan where idpel='" & TextBox6.Text & "'"

            Dim cmmd As New OleDbCommand(aksi, cnn)
            Dim dreader As OleDbDataReader
            dreader = cmmd.ExecuteReader

            If dreader.Read Then
                TextBox5.Text = dreader.Item(1)
            Else
                TextBox5.Text = "-"
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel2.Enabled = True
            TextBox6.Focus()
        ElseIf CheckBox1.Checked = False Then
            Panel2.Enabled = False
            TextBox6.Text = "-"
            TextBox5.Text = "-"
        End If

    End Sub

    Private Sub txtjml_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjml.TextChanged

    End Sub
End Class