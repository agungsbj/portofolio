Imports System.Data.OleDb
Public Class FormPenjualanpribadi

    Private Sub FormPenjualanpribadi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        NoOtomatis()
        refreshDGV()
        Hitungtotal()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormLihatBarang3.ShowDialog()
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
            Label17.Text = .Item(0, ubah).Value
        End With
        Label19.Text = Val(Label3.Text) + Val(Label18.Text)
    End Sub
    Sub refreshDGV()
        Dim dadapter As New OleDbDataAdapter("select * from penjualanpribadi", cnn)
        Dim tampung As New DataTable("penjualanpribadi")
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
    Private Sub txtkdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdbrg.TextChanged
        Dim aksi As String = String.Empty
        aksi = "select * from barang where idbrg='" & txtkdbrg.Text & "' "

        Dim cmmd As New OleDbCommand(aksi, cnn)
        Dim dreader As OleDbDataReader
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            txtnmbrg.Text = dreader.Item(1)
            txtharga.Text = Format(dreader.Item(5), "n")
            Label3.Text = dreader.Item(3)
            Label3a.Text = dreader.Item(4)
            muncul()
            txtjml.Focus()
        End If

        If Label3.Text = "0" Then
            MessageBox.Show("Maaf stok habis", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label3.Text = "-"
            Label3.Text = "-"
            txtkdbrg.Clear()
            txtnmbrg.Clear()
            txtharga.Clear()
            txtkdbrg.Focus()
        Else
            txtjml.Focus()
        End If
        txtjml.Focus()
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

    Private Sub txtjml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        If e.KeyChar = Chr(13) Then
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
                Label20.Text = Val(txtjml.Text) + Val(Label18.Text)
                Label22.Text = CInt(txttotal.Text) + CInt(Label21.Text)
            End If
        End If
    End Sub
    Private Sub NoOtomatis()
        cmd = New OleDbCommand("Select * from Penjualanpribadi where No_transaksi in (select max(No_transaksi) from Penjualanpribadi) order by no_transaksi desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "PP" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(dr.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "PP" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
                urutan = "PP" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        txtno.Text = urutan
    End Sub
    Private Sub txtjml_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjml.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If (MessageBox.Show("Hapus Transaksi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Try
                Call koneksi()
                Dim str As String
                str = "Delete from penjualanpribadi where no_transaksi='" & Label17.Text & " '"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Transaksi Dihapus")
                Call CLEAR()
                refreshDGV()
            Catch ex As Exception
                MessageBox.Show("Gagal Hapus ", ex.Message)
            End Try
        Else
            txtkdbrg.Focus()
        End If
    End Sub
    Sub tambah()
        Try
            Call koneksi()
            Dim aksi As String = String.Empty
            aksi = "insert into penjualanpribadi values('" & txtno.Text & "','" & DateTimePicker1.Value & "','" & txtkdbrg.Text & "','" & _
                txtnmbrg.Text & "','" & CInt(txtharga.Text) & "','" & txtjml.Text & "','" & Label3a.Text & "','" & CInt(txttotal.Text) & "')"
                Dim perintah As OleDbCommand = New OleDbCommand(aksi, cnn)
                perintah.ExecuteNonQuery()
                MsgBox("Berhasil")
            Call refreshDGV()

            'kurangi stok
            Dim str As String
            str = "Update barang set stok = '" & Label16.Text & "' where idbrg = '" & txtkdbrg.Text & "'"
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
            totalberat = totalberat + Val(DGV.Rows(t).Cells(7).Value)
        Next
        TextBox1.Text = totalberat
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If txttotal.Text = "" Or txttotal.Text = "0" Then
            MsgBox("Tekan enter di kolom jumlah dahulu untuk melanjutkan transaksi", MsgBoxStyle.Information, "Peringatan")
            txtjml.Focus()
        Else
            Call koneksi()
            Call tambah()
            Call Hitungtotal()
            Call CLEAR()
            Button2.Focus()
        End If
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class