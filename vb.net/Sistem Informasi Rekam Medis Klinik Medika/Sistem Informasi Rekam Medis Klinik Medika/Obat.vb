Imports System.Data.OleDb
Public Class Obat

    Sub kosong()
        Button1.Text = "SIMPAN"
        lbledit.Text = "0"
        TextBox6.Clear()
        TextBox4.Clear()
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
    End Sub
    Sub simpanlog()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Menambahkan Obat " + TextBox2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarObat.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpanlogupdate()
        Dim id As String = Format(Now, "ddMMyy-HHmmss")
        Dim aksi As String = "Memperbaharui Obat " + DaftarObat.Label2.Text
        Dim str As String

        str = "INSERT INTO log VALUES ('" & id & "','" & Now & "','" & Now & _
            "', '" & DaftarObat.lblnama.Text & "', '" & aksi & "')"
        cmd = New OleDbCommand(str, cnn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Updateobat()
        Try
            Call koneksi()
            Dim str As String

            If DateTimePicker2.Value <= Now Then
                Label13.Text = "Kadaluarsa"
            Else
                Label13.Text = "Aman"
            End If

            str = "Update obat set namaobat = '" & TextBox2.Text & "', namagen = '" & TextBox3.Text & _
                "', gol = '" & ComboBox1.Text & "', tglbeli = '" & DateTimePicker1.Value & _
                "', tglex = '" & DateTimePicker2.Value & "', hargabeli = '" & TextBox4.Text & _
                "', hargajual = '" & TextBox5.Text & "', stok = '" & TextBox6.Text & "', satuan = '" & ComboBox2.Text & _
                "', status = '" & Label13.Text & "', kdobat = '" & TextBox1.Text & "' where kdobat = '" & DaftarObat.Label1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            Call simpanlogupdate()
            MessageBox.Show("Data berhasil diperbaharui")
            Call DaftarObat.Tampilobat()
            Call kosong()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbaharui")
        End Try
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Isi data dengan lengkap!")
        Else
            Try
                Call koneksi()
                If DateTimePicker2.Value <= Now Then
                    Label13.Text = "Kadaluarsa"
                Else
                    Label13.Text = "Aman"
                End If

                Dim str As String

                str = "INSERT INTO obat VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & _
                    "', '" & ComboBox1.Text & "', '" & DateTimePicker1.Value & "', '" & DateTimePicker2.Value & "', '" & TextBox4.Text & _
                    "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & ComboBox2.Text & "', '" & Label13.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                Call simpanlog()
                MessageBox.Show("Tambah Obat Berhasil")
                Call DaftarObat.Tampilobat()
                Call kosong()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If e.KeyChar = Chr(13) Then
            If DateTimePicker2.Value <= DateTimePicker1.Value Then
                MsgBox("Penulisan Masa Berlaku Salah")
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            If CInt(TextBox5.Text) < CInt(TextBox4.Text) Then
                MsgBox("Harga jual harus lebih tinggi dari harga beli")
                Button1.Enabled = False
            Else
                TextBox6.Focus()
                Button1.Enabled = True
            End If
        End If
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        exp()
    End Sub
    Sub exp()
        If DateTimePicker2.Value <= DateTimePicker1.Value Then
            MsgBox("Penulisan Masa Berlaku Salah")
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
    Sub kodeobat()
        Dim jenis As String
        Dim id As String
        If ComboBox1.SelectedIndex = 0 Then
            jenis = "01"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            jenis = "02"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            jenis = "03"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            jenis = "04"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            jenis = "05"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            jenis = "06"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            jenis = "07"
        ElseIf ComboBox1.SelectedIndex = 7 Then
            jenis = "08"
        ElseIf ComboBox1.SelectedIndex = 8 Then
            jenis = "09"
        ElseIf ComboBox1.SelectedIndex = 9 Then
            jenis = "10"
        ElseIf ComboBox1.SelectedIndex = 10 Then
            jenis = "11"
        ElseIf ComboBox1.SelectedIndex = 11 Then
            jenis = "12"
        ElseIf ComboBox1.SelectedIndex = 12 Then
            jenis = "13"
        ElseIf ComboBox1.SelectedIndex = 13 Then
            jenis = "14"
        ElseIf ComboBox1.SelectedIndex = 14 Then
            jenis = "15"
        ElseIf ComboBox1.SelectedIndex = 15 Then
            jenis = "16"
        ElseIf ComboBox1.SelectedIndex = 16 Then
            jenis = "17"
        ElseIf ComboBox1.SelectedIndex = 17 Then
            jenis = "18"
        ElseIf ComboBox1.SelectedIndex = 18 Then
            jenis = "19"
        ElseIf ComboBox1.SelectedIndex = 19 Then
            jenis = "20"
        ElseIf ComboBox1.SelectedIndex = 20 Then
            jenis = "21"
        ElseIf ComboBox1.SelectedIndex = -1 Then
            jenis = ""
        End If

        Dim satuan As String
        Select Case ComboBox2.SelectedIndex
            Case Is = 0
                satuan = "01"
            Case Is = 1
                satuan = "02"
            Case Is = 2
                satuan = "03"
            Case Is = 3
                satuan = "04"
            Case Is = 4
                satuan = "05"
            Case Is = 5
                satuan = "06"
        End Select
        Dim thn As String
        thn = Format(DateTimePicker2.Value, "MMyy")
        Dim kata As String
        kata = Microsoft.VisualBasic.Left(TextBox2.Text, 3)
        id = jenis + satuan + kata + thn
        TextBox1.Text = id
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call kodeobat()
    End Sub
    Sub aktif()
        If lbledit.Text = 0 Then
            Panel4.Visible = False
            TextBox6.Enabled = True
        ElseIf lbledit.Text = 1 Then
            Panel4.Visible = True
            TextBox6.Enabled = False
        End If
        
    End Sub
    Private Sub Obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        Call koneksi()
        kosong()
        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("SELECT *FROM obat WHERE kdobat='" & TextBox1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox2.Text = dr.Item(1)
            TextBox3.Text = dr.Item(2)
            ComboBox1.Text = dr.Item(3)
            DateTimePicker1.Value = dr.Item(4)
            DateTimePicker2.Value = dr.Item(5)
            TextBox4.Text = dr.Item(6)
            TextBox5.Text = dr.Item(7)
            TextBox6.Text = dr.Item(8)
            ComboBox2.Text = dr.Item(9)
        Else
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If Val(TextBox5.Text) <= Val(TextBox4.Text) Then
            MsgBox("Harga jual harus lebih tinggi dari harga beli")
            Button1.Enabled = False
        Else
            TextBox6.Focus()
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kosong()
        TextBox2.Focus()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DateTimePicker2.Value < Now Then
            MsgBox("Penulisan masa berlaku salah!!!", MsgBoxStyle.Critical)
            DateTimePicker1.Value = Now
        Else
            kodeobat()
            If lbledit.Text = "0" Then
                Call simpan()
                Button1.Text = "SIMPAN"
            ElseIf lbledit.Text = "1" Then
                Button1.Text = "PERBAHARUI"
                Call Updateobat()
            End If
        End If

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            TextBox6.Text = Val(TextBox6.Text) + Val(TextBox7.Text)
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub Panel4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.Click
        If GroupBox1.Visible = False Then
            GroupBox1.Visible = True
            TextBox7.Focus()
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value < Now Then
            DateTimePicker1.Value = Now
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class