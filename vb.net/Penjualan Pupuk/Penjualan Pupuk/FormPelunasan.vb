Imports System.Data.OleDb
Public Class FormPelunasan
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim aksi As String = String.Empty
            aksi = "select * from penjualan where no_transaksi='" & TextBox1.Text & "'"

            Dim cmmd As New OleDbCommand(aksi, cnn)
            Dim dreader As OleDbDataReader
            dreader = cmmd.ExecuteReader
            Dim sts As String

            If dreader.Read Then
                sts = dreader.Item(10)
                If sts = "Lunas" Then
                    MsgBox("Transaksi ini sudah dilunasi")
                    TextBox1.Focus()
                Else
                    DateTimePicker1.Value = dreader.Item(1)
                    TextBox2.Text = dreader.Item(5)
                    TextBox3.Text = dreader.Item(7)
                    TextBox4.Text = dreader.Item(11)
                    TextBox5.Text = dreader.Item(12)
                    Call hari()
                End If
            Else
            End If
        End If
        If Val(Label3.Text) > 7 Then
            Dim denda As Integer
            denda = Val(TextBox3.Text) * 0.02
            TextBox8.Text = denda
            TextBox9.Text = denda + Val(TextBox3.Text)
            TextBox5.Text = Val(TextBox9.Text) - Val(TextBox4.Text)
        Else
            TextBox8.Text = "0"
            TextBox9.Text = Val(TextBox8.Text) + Val(TextBox3.Text)
            TextBox5.Text = Val(TextBox9.Text) - Val(TextBox4.Text)
        End If
    End Sub

    Private Sub FormPelunasan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
    Sub hari()
        Label3.Text = DateDiff(DateInterval.Day, CDate(DateTimePicker1.Text), CDate(Now))
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call lunasi()
    End Sub
    Sub lunasi()
        If TextBox1.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Lengkapi data-data terlebih dahulu")
        Else
            Try
                Dim denda As String
                If TextBox8.Text = "0" Then
                    denda = "Lunas Tanpa Biaya Denda"
                Else
                    denda = "Terkena denda 3%"
                End If

                Dim str As String
                str = "Update penjualan set dp = '" & "0" & "', sisa = '" & "0" & "', status = '" & "Lunas" & "', ket = '" & denda & "' where no_transaksi = '" & TextBox1.Text & "'"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil")
                cetaknota()
                Call kosong()
            Catch ex As Exception
                MsgBox("Gagal karena : ", ex.Message)
            End Try
        End If
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox6.Text) < Val(TextBox5.Text) Then
                MsgBox("Pembayaran Kurang")
            Else
                TextBox7.Text = Val(TextBox6.Text) - Val(TextBox5.Text)
            End If
        End If
    End Sub
    Sub cetaknota()
        cetaknotaangsur.notaangsur1.SetParameterValue("notrans", TextBox1.Text)
        cetaknotaangsur.notaangsur1.SetParameterValue("notrans1", TextBox1.Text)

        cetaknotaangsur.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormLihattrans.ShowDialog()
    End Sub
End Class