Imports System.Data.OleDb
Public Class FormPembelian

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Pilih Supplier dahulu", MsgBoxStyle.Information)
            Button2.Focus()
        Else
            FormLihatBarang2.Show()
        End If
    End Sub

    Private Sub txtkdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdbrg.TextChanged
        Dim aksi As String = String.Empty
        aksi = "select * from tempisipembelian where idbrg='" & txtkdbrg.Text & "' "

        Dim cmmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            MsgBox("Barang sudah ada dalam daftar belanja, hapus barang dahulu jika ingin menambahkan barang yang sama")
        Else
            Dim aksi2 As String = String.Empty
            aksi2 = "select * from barang where idbrg='" & txtkdbrg.Text & "' "

            Dim cmd As New OleDbCommand(aksi2, cnn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                txtnmbrg.Text = dr.Item(1)
                txtharga.Text = Format(dr.Item(5), "n")
                Label3.Text = dr.Item(3)
                Label3a.Text = dr.Item(4)
                txtjml.Focus()
                muncul()
            End If
        End If
    End Sub

    Private Sub txtjml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        If e.KeyChar = Chr(13) Then

            Try
                Dim harga, jumlah, total As Double
                harga = txtharga.Text
                jumlah = CInt(txtjml.Text)
                total = harga * jumlah
                txttotal.Text = Format(total, "n")
                Button6.Focus()
                Label4.Text = jumlah + Val(Label3.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            
            End If
    End Sub
    Private Sub NoOtomatis()
        cmd = New OleDbCommand("Select * from Pembelian where No_pembelian in (select max(No_pembelian) from Pembelian) order by no_pembelian desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "BL" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(dr.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "BL" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
                urutan = "BL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        txtno.Text = urutan
    End Sub
    Sub refreshDGV()
        Dim dadapter As New OleDbDataAdapter("select idbrg,nama,hargabeli,jumlah,satuan,subtotal from tempIsipembelian", cnn)
        Dim tampung As New DataTable("tempIsipembelian")
        dadapter.Fill(tampung)
        DGV.DataSource = tampung
        txtkdbrg.Focus()
    End Sub
    Sub kosong()
        Label3.Text = "-"
        Label3a.Text = "-"
        txtharga.Text = "0"
        txtkdbrg.Clear()
        txtnmbrg.Clear()
        txttotal.Text = "0"
        txtjml.Text = "0"
        txttotalbiaya.Text = "0"
        TextBox3.Text = "0"
    End Sub
    Sub CLEAR()
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
        ComboBox1.Enabled = False
        DGV.Enabled = False
        Button1.Enabled = True
        Button4.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        txttotalbiaya.Enabled = False
        Button1.Focus()
    End Sub
    Sub aktif()
        Button1.Enabled = False
        ComboBox1.Enabled = True
        GroupBox3.Enabled = True
        DGV.Enabled = True
        GroupBox1.Enabled = True
        Button4.Enabled = True
        txtjml.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button2.Focus()
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

                    Me.ComboBox1.DataSource = dt
                    Me.ComboBox1.DisplayMember = "nama"
                    Me.ComboBox1.ValueMember = "idsup"

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub FormPembelian_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'pilih barang
        If e.Control And e.KeyCode = Keys.F Then
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Pilih Supplier dahulu", MsgBoxStyle.Information)
                Button2.Focus()
            Else
                FormLihatBarang2.Show()
            End If
        End If

        'trans baru
        If e.Control And e.KeyCode = Keys.N Then
            MessageBox.Show("Silahkan Input Transaksi")
            Call aktif()
            Call kosong()
        End If
    End Sub

    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        loadawal()
        tampilsup()
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
        Call Hitungtotal()
    End Sub
    Sub tambah()
        Try
            Dim aksi As String = String.Empty
            aksi = "insert into tempisipembelian values('" & txtno.Text & "','" & txtkdbrg.Text & "','" & _
                txtnmbrg.Text & "','" & CInt(txtharga.Text) & "','" & txtjml.Text & "','" & Label3a.Text & "','" & CInt(txttotal.Text) & "')"
            Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
            perintah.ExecuteNonQuery()
            Call refreshDGV()

            'tambah stok
            Dim str As String
            str = "Update barang set stok = '" & Label4.Text & "' where idbrg = '" & txtkdbrg.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Hitungtotal()
        Dim totalberat As Double
        totalberat = 0
        For t As Integer = 0 To DGV.Rows.Count - 1
            totalberat = totalberat + Val(DGV.Rows(t).Cells(5).Value)
        Next
        txttotalbiaya.Text = totalberat
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
        If txttotal.Text = "" Or txttotal.Text = "0" Or txtjml.Text = "0" Or txtjml.Text = "" Then
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
            str = "Delete from tempisipembelian where idbrg='" & Label17.Text & " '"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()

            'tambah stok
            Dim str2 As String
            str2 = "Update barang set stok = '" & Label15.Text & "' where idbrg = '" & Label17.Text & "'"
            cmd = New OleDbCommand(str2, cnn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Barang Dihapus")
            Call CLEAR()
        Catch ex As Exception
            MessageBox.Show("Gagal Dihapus")
        End Try

        Call refreshDGV()
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Call klik()
    End Sub
    Sub klik()
        Dim ubah As Integer = Nothing
        ubah = DGV.CurrentRow.Index
        With DGV
            Label17.Text = .Item(0, ubah).Value
            Label7.Text = .Item(3, ubah).Value
        End With

        Dim aksi As String = String.Empty
        aksi = "select * from barang where idbrg='" & Label17.Text & "' "

        Dim cmmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            Label10.Text = dreader.Item(3)
        End If

        Label15.Text = Val(Label10.Text) - Val(Label7.Text)
    End Sub
    Sub muncul()
        Dim ubah As Integer = Nothing
        ubah = DGV.CurrentRow.Index
        With DGV
            Label17.Text = .Item(0, ubah).Value
            Label18.Text = .Item(3, ubah).Value
            Label21.Text = .Item(4, ubah).Value
        End With
        Label19.Text = Val(Label3.Text) + Val(Label18.Text)
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
    Public Sub Simpan()
        Try
            If txtno.Text = "" Or txttotalbiaya.Text = "" Then
                MessageBox.Show("Transaksi belum selesai, lengkapi data yang diperlukan")
                Button2.Focus()

            Else
                Dim hasilcari As String = String.Empty
                hasilcari = "select no_pembelian,idbrg,nama,hargabeli,jumlah,satuan,subtotal from tempisipembelian"

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
                        aksisimpan = "insert into isipembelian values('" & tempnotransaksi & "','" & tempidbarang & _
                             "','" & tempjumlahbeli & "','" & tempsatuan & "','" & tempsubtotal & "')"

                        Dim eksekusijadi As OleDbCommand = New OleDbCommand(aksisimpan, cnn)
                        eksekusijadi.ExecuteNonQuery()

                    Loop While hasilcariku.Read
                End If

                Dim simpanpenjualan As String = String.Empty
                simpanpenjualan = "insert into pembelian values('" & txtno.Text & "','" & DateTimePicker1.Text & _
                    "','" & TextBox2.Text & "','" & Label5.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & CInt(txttotalbiaya.Text) & "')"

                Dim perintahsimpan As OleDbCommand = New OleDbCommand(simpanpenjualan, cnn)
                perintahsimpan.ExecuteNonQuery()

                Dim aksi As String = String.Empty
                aksi = "delete from tempisipembelian where no_pembelian = '" & txtno.Text & "'"

                Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
                perintah.ExecuteNonQuery()


                MsgBox("Transaksi Berhasil Dilakukan", MsgBoxStyle.OkOnly)
                Call kosong()
                DGV.DataSource = ""
            End If
            Me.KeyPreview = True
            loadawal()
            tampilsup()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Simpan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (MessageBox.Show("Batalkan Transaksi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Dim aksi As String = String.Empty
            aksi = "delete from tempisipembelian where no_pembelian = '" & txtno.Text & "'"

            Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
            perintah.ExecuteNonQuery()
            Call kosong()
        Else
            txtkdbrg.Focus()

        End If
    End Sub

    Private Sub txtjml_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjml.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim aksi As String = String.Empty
        aksi = "select * from supplier where nama='" & ComboBox1.Text & "' "

        Dim cmmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            Label5.Text = dreader.Item(0)
        Else
        End If
    End Sub
End Class