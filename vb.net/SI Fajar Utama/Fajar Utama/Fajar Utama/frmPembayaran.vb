Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class frmPembayaran

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim statusbayar As String
        Dim status As String
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT *FROM Pendaftaran WHERE nis='" & TextBox1.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                statusbayar = dr.Item(11)
                status = dr.Item(10)
                If statusbayar = "Sudah Bayar" And status = "Berhenti/Resign" Then
                    MsgBox("Siswa ini sudah membayar biaya kursus dan sudah berhenti", MsgBoxStyle.Information)
                    ComboBox2.Focus()
                ElseIf statusbayar = "Belum Bayar" And status = "Berhenti/Resign" Then
                    MsgBox("Siswa ini sudah berhenti", MsgBoxStyle.Information)
                    ComboBox2.Focus()
                ElseIf statusbayar = "Sudah Bayar" And status = "Belum Lulus" Then
                    MsgBox("Siswa ini sudah membayar biaya kursus", MsgBoxStyle.Information)
                    MsgBox("Mungkin anda bermaksud untuk melunasinya. Pilih pilihan bayar 'Pelunasan' lalu masukan No Pembayaran siswa")
                    ComboBox2.Focus()
                ElseIf statusbayar = "Sudah Bayar" And status = "Lulus" Then
                    MsgBox("Siswa ini sudah membayar biaya kursus", MsgBoxStyle.Information)
                    MsgBox("Mungkin anda bermaksud untuk melunasinya. Pilih pilihan bayar 'Pelunasan' lalu masukan No Pembayaran siswa")
                    ComboBox2.Focus()
                Else
                    TextBox2.Text = dr.Item(1)
                    TextBox3.Text = Format(dr.Item(2), "dd MMMM yyyy")
                    TextBox4.Text = dr.Item(5)
                    TextBox5.Text = dr.Item(6)
                    TextBox7.Text = dr.Item(8)
                    TextBox12.Text = dr.Item(9)
                End If
            Else
                MsgBox("Data siswa tidak ditemukan!", MsgBoxStyle.Information, "Perhatian")
            End If
            cmd = New OleDbCommand("SELECT *FROM paket WHERE nmpaket='" & TextBox7.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                TextBox11.Text = dr.Item(4)
                TextBox9.Text = "25000"
                Call total()
            Else
                TextBox9.Text = ""
            End If
        End If
    End Sub
    Sub total()
        TextBox8.Text = Val(TextBox11.Text) + Val(TextBox9.Text)
    End Sub

    Private Sub frmPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call AWAL()
    End Sub
    Sub AWAL()
        DateTimePicker1.Text = Now
        Button1.Visible = False
        Button2.Visible = False
        Panel3.Visible = False
        TextBox6.ReadOnly = True
        TextBox1.ReadOnly = True
        ComboBox2.Text = "PILIHAN"
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox18.Clear()
        TextBox10.Clear()
        TextBox17.Clear()
        TextBox14.Clear()
        LabelKet.Visible = False
        LabelKet1.Visible = False
        GroupBox3.Visible = False
        GroupBox2.Visible = True
        Panel1.Visible = True
        ComboBox2.Focus()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim no As String
        If ComboBox1.Text = "Lunas" Then
            no = "LUN-"
            Call lunas()
        ElseIf ComboBox1.Text = "Angsur" Then
            no = "ANG-"
            MsgBox("Pembayaran minimal 50% dari biaya paket + biaya pendaftaran")
            Call angsur()
            Call minbayar()
        End If
        Dim nobayar As String
        nobayar = no + TextBox1.Text + Format(Now, "HHMMss")
        TextBox6.Text = nobayar
    End Sub
    Sub lunas()
        Label16.Text = "Bayar"
        Label15.Text = "Kembali"
        TextBox16.Focus()
    End Sub
    Sub angsur()
        Label16.Text = "DP"
        Label15.Text = "Sisa Bayar"
        TextBox16.Focus()
    End Sub
    Sub hitunglunas()
        If Val(TextBox16.Text) < Val(TextBox8.Text) Then
            MsgBox("Pembayaran Kurang")
        Else
            TextBox15.Text = Val(TextBox16.Text) - Val(TextBox8.Text)
            Panel3.Visible = True
        End If
    End Sub
    Sub hitungangsur()
        If Val(TextBox16.Text) >= Val(TextBox8.Text) Then
            MsgBox("Pembayaran anda melebihi batas angsuran. Silahkan pilih metode pembayaran 'Lunas' untuk membayar dengan lunas")
            TextBox16.Focus()
            TextBox15.Clear()
            Panel3.Visible = False
        ElseIf Val(TextBox16.Text) < Val(LabelKet.Text) Then
            MsgBox("Pembayaran Kurang")
            TextBox15.Clear()
            Panel3.Visible = False
        Else
            TextBox15.Text = Val(TextBox8.Text) - Val(TextBox16.Text)
            Panel3.Visible = True
        End If
    End Sub
    Private Sub TextBox16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        If e.KeyChar = Chr(13) Then
            If ComboBox1.SelectedIndex = 0 Then
                Call hitunglunas()
            Else
                Call hitungangsur()
            End If
        End If
    End Sub
    Sub minbayar()
        Dim disk As Double
        disk = 0.5
        Dim ttl As Double
        ttl = Val(TextBox11.Text)
        Dim min As Double
        min = ttl * disk + Val(TextBox9.Text)
        LabelKet.Text = min
        LabelKet.Visible = True
        LabelKet1.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call AWAL()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "PEMBAYARAN" Then
            Call AWAL()
            TextBox1.ReadOnly = False
            TextBox1.Focus()
        ElseIf ComboBox2.Text = "PELUNASAN" Then
            Call AWAL()
            TextBox6.ReadOnly = False
            TextBox1.ReadOnly = True
            GroupBox2.Visible = False
            Panel1.Visible = False
            GroupBox3.Visible = True
            TextBox6.Focus()
        End If
    End Sub
    Sub bayar()
        Dim dp, sisa As String

        If ComboBox1.Text = "Angsur" Then
            dp = Val(TextBox16.Text)
            sisa = Val(TextBox15.Text)
        ElseIf ComboBox1.Text = "Lunas" Then
            dp = Val(TextBox8.Text)
            sisa = "0"
        End If
        Dim status As String = "Sudah Bayar"

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()
                Dim str As String

                str = "INSERT INTO pembayaran VALUES ('" & TextBox6.Text & "','" & DateTimePicker1.Value & _
                    "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & _
                     "','" & TextBox5.Text & "', '" & TextBox7.Text & "', '" & TextBox12.Text & "','" & TextBox11.Text & "', '" & _
                    TextBox9.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "','" & dp & "','" & sisa & _
                    "','" & DateTimePicker1.Value & "')"

                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()

                Dim updstatus As String = String.Empty

                updstatus = "Update pendaftaran set statusbayar = '" & status & "' where nis = '" & TextBox1.Text & "'"

                Dim aksiupdate As OleDbCommand = New OleDbCommand(updstatus, cnn)
                aksiupdate.ExecuteNonQuery()
                MessageBox.Show("Pembayaran Berhasil")
            Catch ex As Exception
                MsgBox("Pembayaran Gagal Karena ")
            End Try
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call bayar()
    End Sub

    Public totalbayar As String

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim status As String

        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT *FROM Pembayaran WHERE nobayar='" & TextBox6.Text & "'", cnn)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                status = dr.Item(12)
                If status = "Lunas" Then
                    MsgBox("Siswa ini sudah melunasi pembayarannya")
                    TextBox6.Focus()
                ElseIf status = "Refund" Then
                    MsgBox("Siswa ini sudah berhenti")
                    TextBox6.Focus()
                Else
                    TextBox1.Text = dr.Item(2)
                    TextBox2.Text = dr.Item(3)
                    TextBox3.Text = Format(dr.Item(4), "dd MMMM yyyy")
                    TextBox4.Text = dr.Item(5)
                    TextBox5.Text = dr.Item(6)
                    TextBox10.Text = dr.Item(13)
                    TextBox18.Text = dr.Item(14)
                    totalbayar = dr.Item(11)
                    TextBox17.Focus()
                End If
            Else
                MsgBox("Data bayar tidak ditemukan!", MsgBoxStyle.Information, "Perhatian")
                TextBox6.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox17_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox17.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox17.Text) < Val(TextBox18.Text) Then
                MsgBox("Pembayaran Kurang. Pembayaran tidak bisa dilakukan 3X Angsuran")
            Else
                TextBox14.Text = Val(TextBox17.Text) - Val(TextBox18.Text)
                Button1.Visible = True
                Button2.Visible = True
            End If
        End If
        
    End Sub
    Sub lunasi()
        Dim dp, sisa, status As String
        dp = "0"
        sisa = "0"
        status = "Lunas"

        Dim no As String
        no = "LUN-"
        Dim nolunas As String
        nolunas = no + TextBox1.Text + Format(Now, "HHMMss")
        Label18.Text = nolunas

        Try
            Call koneksi()
            Dim simpanlunas As String = String.Empty

            simpanlunas = "insert into Lunas values('" & nolunas & "','" & DateTimePicker1.Text & _
                        "','" & TextBox10.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & _
                        "','" & TextBox4.Text & "','" & TextBox18.Text & "','" & status & "')"

            Dim perintahlunas As OleDbCommand = New OleDbCommand(simpanlunas, cnn)
            perintahlunas.ExecuteNonQuery()

            Dim updbayar As String = String.Empty

            updbayar = "Update pembayaran set statusbayar = '" & status & "', dp = '" & totalbayar & "', sisa = '" & sisa & "', tgllunas = '" & DateTimePicker1.Text & "' where nobayar = '" & TextBox6.Text & "'"

            Dim aksiupdate As OleDbCommand = New OleDbCommand(updbayar, cnn)
            aksiupdate.ExecuteNonQuery()

            MessageBox.Show("Pelunasan Angsuran Berhasil")
        Catch ex As Exception
            MessageBox.Show("Pelunasan Angsuran Gagal")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call lunasi()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmnotalunas.notalunas1.SetParameterValue("nobayar", TextBox6.Text)
        frmnotalunas.notalunas1.SetParameterValue("nolunas", Label18.Text)
        frmnotalunas.Show()
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmnotabayar.notabayar1.SetParameterValue("nobayar", TextBox6.Text)
        frmnotabayar.Show()
    End Sub
End Class