Imports System.Data.OleDb
Public Class SuratKet
    Sub jk()
        If lbljk.Text = "_" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = ""
        ElseIf lbljk.Text = "Laki - laki" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf lbljk.Text = "Perempuan" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub SuratKet_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call jk()
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!!!")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO skes VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value & "','" & ComboBox1.Text & _
                      "','" & TextBox2.Text & "','" & lbljk.Text & "','" & DTPick.Text & "', '" & TextBox3.Text & _
                      "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & _
                      "','" & ComboBox3.Text & "','" & TextBox9.Text & "','" & TextBox9.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                simpanantrian()
                MessageBox.Show("Pendaftaran Berhasil")
                Call kosong()
                Call autonumberantrian()
                Call autonumber()
            Catch ex As Exception
                MessageBox.Show("Pendaftaran Gagal")
                TextBox1.Focus()
            End Try
        End If
    End Sub
    Sub kosong()
        TextBox2.Clear()
        lbljk.Text = "_"
        TextBox3.Clear()
        ComboBox2.SelectedIndex = -1
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox3.SelectedIndex = -1
        TextBox9.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox1.Focus()
        Call jk()
        DTPick.Value = Now
        DateTimePicker1.Value = Now
    End Sub
    Sub autonumber()
        cmd = New OleDbCommand("Select * from skes where no_surat in (select max(no_surat) from skes) order by no_surat desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "001" + Format(Now, "/MM") + "/SKES-KM/" + Format(Now, "yyyy")
        Else
            hitung = Microsoft.VisualBasic.Left(dr.GetString(0), 3) + 1
            urutan = Microsoft.VisualBasic.Right("000" & hitung, 3) + Format(Now, "/MM") + "/SKES-KM/" + Format(Now, "yyyy")
        End If
        TextBox1.Text = urutan
    End Sub
    Sub simpanantrian()
        Try
            Call koneksi()
            Dim idrm As String
            idrm = "-"
            Dim str As String

            str = "INSERT INTO antriankasir VALUES ('" & Label18.Text & "','" & idrm & "','" & TextBox1.Text & "','" & TextBox2.Text & "')"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Telah ditambahkan pada antrian kasir", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call autonumber()
        Catch ex As Exception
            MessageBox.Show("Menambahkan ke Antrian Gagal")
        End Try
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
        Label18.Text = urutan
    End Sub
    Private Sub SuratKet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
        Call koneksi()
        Call kosong()
        Call autonumber()
        Call autonumberantrian()
    End Sub
    Sub umur()
        Dim a, b, tahun As String
        a = Year(Now)
        b = Year(DTPick.Value)
        tahun = a - b
        TextBox3.Text = tahun + " Tahun"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call simpan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        lbljk.Text = "Laki - laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        lbljk.Text = "Perempuan"
    End Sub

    Private Sub DTPick_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPick.ValueChanged
        Call umur()
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "/" Or
              e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
              e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
              e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DaftarSkes.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub
End Class