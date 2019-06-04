Imports System.Data.OleDb
Public Class frmPendaftaran

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label8.Text = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label8.Text = RadioButton2.Text
    End Sub
    Sub tampilpaket()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Using cnn As New OleDbConnection(path)
            Try
                cnn.Open()
                Using cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select idpaket, nmpaket from paket"
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    Me.ComboBox2.DataSource = dt
                    Me.ComboBox2.DisplayMember = "nmpaket"
                    Me.ComboBox2.ValueMember = "idpaket"

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Sub tampilinstruktur()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Using cnn As New OleDbConnection(path)
            Try
                cnn.Open()
                Using cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select idins, nama from instruktur"
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    Me.ComboBox1.DataSource = dt
                    Me.ComboBox1.DisplayMember = "nama"
                    Me.ComboBox1.ValueMember = "idins"

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub frmPendaftaran_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call jk()
    End Sub
    Sub jk()
        If Label8.Text = "LAKI - LAKI" Then
            RadioButton1.Checked = True
        ElseIf Label8.Text = "PEREMPUAN" Then
            RadioButton2.Checked = True
        Else
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If
    End Sub
    Private Sub frmPendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilinstruktur()
        Call tampilpaket()
        Call autonumber()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        Panel1.Visible = False
        DateTimePicker1.Text = Now
    End Sub
    Sub autonumber()
        Call koneksi()
        cmd = New OleDbCommand("Select * from pendaftaran where nis in (select max(nis) from pendaftaran) order by nis desc", cnn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = Format(Now, "yyMM") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            urutan = Format(Now, "yyMM") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        TextBox1.Text = urutan
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        cmd = New OleDbCommand("SELECT *FROM Paket WHERE nmpaket='" & ComboBox2.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If (dr.Read = True) Then
            TextBox5.Text = dr.Item(2)
        End If
    End Sub
    Sub validasi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Lengkapi Data Siswa Dahulu")
            TextBox1.Focus()
        Else
            Panel1.Visible = True
            Button3.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Sub resetjk()
        If Label8.Text = "_" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If
    End Sub

    Sub kosong()
        Call autonumber()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        Label8.Text = "_"
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox1.Focus()
        DateTimePicker1.Text = Now
    End Sub
   
    Sub daftar()
        Dim status As String
        status = "Belum Lulus"
        Dim statusbayar As String
        statusbayar = "Belum Bayar"

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()
                Dim str As String

                str = "INSERT INTO pendaftaran VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Value & _
                    "','" & TextBox3.Text & "', '" & DTPick.Text & "', '" & Label8.Text & "','" & TextBox4.Text & "', '" & _
                    ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & status & "','" & statusbayar & "','" & TextBox6.Text & "')"

                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Pendaftaran Berhasil")
            Catch ex As Exception
                MessageBox.Show("Pendafataran Gagal")
            End Try
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Panel3.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CETAKKARTU.kw1.SetParameterValue("nis", TextBox1.Text)
        CETAKKARTU.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call kosong()
        Panel1.Visible = False
        TextBox1.Focus()
        Call autonumber()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel3.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call daftar()
        Button4.Focus()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call validasi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmPembayaran.Show()
        frmPembayaran.ComboBox2.Text = "PEMBAYARAN"
        frmPembayaran.TextBox1.Text = TextBox1.Text
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call kosong()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Call koneksi()
            Dim str As String

            str = "Update pendaftaran set nama = '" & TextBox2.Text & "', tempat = '" & TextBox3.Text & "', tgllahir = '" & DTPick.Text & "', jk = '" & Label8.Text & "', alamat = '" & TextBox4.Text & "', notelp = '" & TextBox6.Text & "' where nis = '" & FrmDataSiswa.Label5.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Siswa Sukses")
            Me.Dispose()
            Call FrmDataSiswa.awal()
        Catch ex As Exception
            MessageBox.Show("Update Siswa Gagal")
        End Try
    End Sub
End Class