Imports System.Data.OleDb
Public Class FormNilai
    Sub nilai()
        If TextBox6.Text = "" Then
            TextBox6.Text = "0"
        ElseIf TextBox7.Text = "" Then
            TextBox7.Text = "0"
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = "0"
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = "0"
        ElseIf TextBox5.Text = "" Then
            TextBox5.Text = "0"
        End If

        If TextBox6.Text > 100 Then
            TextBox6.Text = 100
        ElseIf TextBox7.Text > 100 Then
            TextBox7.Text = 100
        ElseIf TextBox3.Text > 100 Then
            TextBox3.Text = 100
        ElseIf TextBox4.Text > 100 Then
            TextBox4.Text = 100
        ElseIf TextBox5.Text > 100 Then
            TextBox5.Text = 100
        End If

        Dim a As String
        a = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text)
        TextBox8.Text = a / 5

        If Val(TextBox8.Text) >= 85 Then
            lblmutu.Text = "A"
            lblstatus.Text = "Sangat Baik"
        ElseIf Val(TextBox8.Text) >= 75 Then
            lblmutu.Text = "B"
            lblstatus.Text = "Baik"
        ElseIf Val(TextBox8.Text) <= 65 Then
            lblmutu.Text = "C"
            lblstatus.Text = "Cukup"
        Else
            lblmutu.Text = "C"
            lblstatus.Text = "Cukup"
        End If
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        nilai()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        nilai()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        nilai()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        nilai()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        nilai()
    End Sub

    Sub Tampildbgrid()
        Dim SqlQuery As String = " SELECT * FROM nilai "
        Dim SqlCommand As New OleDbCommand
        Dim sqlAdapter As New OleDbDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = cnn
        End With
        With sqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With DataGridView1
                .Rows.Add(TABLE.Rows(i)("nis"), TABLE.Rows(i)("nama"), TABLE.Rows(i)("nilaia"), TABLE.Rows(i)("nilaib"), TABLE.Rows(i)("nilaic"), TABLE.Rows(i)("nilaid"), TABLE.Rows(i)("nilaie"), TABLE.Rows(i)("totalnilai"), TABLE.Rows(i)("mutu"), TABLE.Rows(i)("status"))
            End With
        Next
    End Sub
    Private Sub FormNilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampildbgrid()
        Call awal()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call simpan()
        GroupBox2.Enabled = False
        Call Tampildbgrid()
    End Sub
    Sub simpan()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("harap isi data dengan lengkap")
        Else
            Try
                Call koneksi()

                Dim str As String

                str = "INSERT INTO nilai VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & _
                    "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & _
                    "', '" & TextBox8.Text & "', '" & lblmutu.Text & "', '" & lblstatus.Text & "')"
                cmd = New OleDbCommand(str, cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input Berhasil")
                Call kosong()
            Catch ex As Exception
                MessageBox.Show("Input Gagal")
            End Try
        End If
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
        lblmutu.Clear()
        lblstatus.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button8.Enabled = False
        Button1.Enabled = True
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            TextBox1.Text = .Item(0, ubah).Value
            TextBox2.Text = .Item(1, ubah).Value
            TextBox3.Text = .Item(2, ubah).Value
            TextBox4.Text = .Item(3, ubah).Value
            TextBox5.Text = .Item(4, ubah).Value
            TextBox6.Text = .Item(5, ubah).Value
            TextBox7.Text = .Item(6, ubah).Value
            TextBox8.Text = .Item(7, ubah).Value
            lblmutu.Text = .Item(8, ubah).Value
            lblstatus.Text = .Item(9, ubah).Value
        End With
    End Sub

    Private Sub TextBox1_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles TextBox1.Invalidated

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT *FROM nilai WHERE nis='" & TextBox1.Text & "'", cnn)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                cmd = New OleDbCommand("SELECT *FROM Pendaftaran WHERE nis='" & TextBox1.Text & "'", cnn)
                dr = cmd.ExecuteReader

                If (dr.Read = True) Then
                    TextBox2.Text = dr.Item(1)
                    GroupBox2.Enabled = True
                    TextBox3.Focus()
                Else
                    TextBox2.Text = ""
                    GroupBox2.Enabled = False
                End If
            Else
                MsgBox("Siswa ini sudah dinilai. Silahkan klik NIS pada daftar dibawah untuk mengedit nilai.", MsgBoxStyle.Critical, "Perhatian")
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Updatedata()
    End Sub
    Sub Updatedata()
        Try
            Call koneksi()
            Dim str As String

            str = "Update nilai set nilaia = '" & TextBox3.Text & "', nilaib = '" & TextBox4.Text & "', nilaic = '" & TextBox5.Text & "', nilaid = '" & TextBox6.Text & "', nilaie = '" & TextBox7.Text & "', totalnilai = '" & TextBox8.Text & "', mutu = '" & lblmutu.Text & "', status = '" & lblstatus.Text & "' where nis = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Nilai Sukses")
            Call awal()
        Catch ex As Exception
            MessageBox.Show("Update Nilai Gagal")
        End Try
        Call tampildbgrid()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        FormLoginIns.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call awal()
    End Sub
    Sub awal()
        Call kosong()
        Button1.Enabled = False
        Button8.Enabled = True
        GroupBox2.Enabled = False
        GroupBox1.Enabled = True
    End Sub
End Class