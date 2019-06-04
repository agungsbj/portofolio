Imports System.Data.OleDb
Imports System.Math
Public Class FormPenilaian
    Sub kosong()
        Me.Size = New Point(752, 186)
        Button2.Enabled = False
        Label1.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        jawaban.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InputGuru.ShowDialog()
        InputGuru.Button4.Visible = False
        InputGuru.Button5.Visible = False
        InputGuru.Button6.Visible = False
    End Sub
    Sub lamajabatan()
        Dim a, b, c, d, bulan, tahun As String
        a = Month(Now)
        b = Month(DateTimePicker1.Value)
        c = Year(Now)
        d = Year(DateTimePicker1.Value)
        tahun = c - d
        bulan = a - b
        If tahun = 0 Then
            Label4.Text = bulan + "  Bulan"
        Else
            Label4.Text = tahun + "  Tahun " + bulan + "  Bulan"
        End If

    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        lamajabatan()
    End Sub

    Private Sub jawaban_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jawaban.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                         e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(jawaban.Text) > 10 Then
                jawaban.Clear()
            Else
                Me.TabControl1.SelectedIndex = 1
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub jawaban_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jawaban.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                        e.KeyChar = vbBack) Then e.Handled = True
       
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) > 10 Then
                TextBox1.Clear()
            Else
                Me.TabControl1.SelectedIndex = 2
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                 e.KeyChar = vbBack) Then e.Handled = True
       
        If e.KeyChar = Chr(13) Then
            If Val(TextBox2.Text) > 10 Then
                TextBox2.Clear()
            Else
                Me.TabControl1.SelectedIndex = 3
                TextBox3.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                 e.KeyChar = vbBack) Then e.Handled = True
         If e.KeyChar = Chr(13) Then
            If Val(TextBox3.Text) > 10 Then
                TextBox3.Clear()
            Else
                Me.TabControl1.SelectedIndex = 4
                TextBox4.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                 e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If Val(TextBox4.Text) > 10 Then
                TextBox4.Clear()
            Else
                Me.TabControl1.SelectedIndex = 5
                TextBox5.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                 e.KeyChar = vbBack) Then e.Handled = True
         If e.KeyChar = Chr(13) Then
            If Val(TextBox5.Text) > 10 Then
                TextBox5.Clear()
            Else
                Me.TabControl1.SelectedIndex = 6
                TextBox6.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                 e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(TextBox6.Text) > 10 Then
                TextBox6.Clear()
            Else
                Dim pesan As String
                pesan = MsgBox("Anda telah selesai mengisi jawaban, apakah anda ingin memproses jawaban ?", vbQuestion + vbYesNo, "pesan")
                If pesan = vbYes Then
                    Button2.Enabled = True
                    Button2.Focus()
                Else
                    Button2.Enabled = False
                    TextBox6.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nilai, hasil As Double
        nilai = Val(jawaban.Text) + Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) _
            + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        hasil = Val(nilai) / 7
        Try
            Dim id As String
            id = Format(Now, "ddMMyyHHmmss")
            Dim str As String
            str = "INSERT INTO loghasil VALUES ('" & id & "','" & Now & "','" & InputGuru.TextBox1.Text & _
                "', '" & Label4.Text & "', '" & jawaban.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & _
                 "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & _
                  "', '" & Round(Val(hasil), 2) & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Simpan Data Berhasil")
            Dim pesan As String
            pesan = MsgBox("Guru telah dinilai. Untuk melihat hasil, silahkan lihat di Form Hasil. Buka Form Hasil ?", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                kosong()
                Me.Close()
                FormHasil.ShowDialog()
            Else
                kosong()
                Button1.Focus()
            End If
        Catch ex As Exception
            MsgBox("Gagal Menyimpan Data Karena " + ex.Message)
        End Try
    End Sub

    Private Sub FormPenilaian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosong()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class