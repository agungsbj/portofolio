Imports System.Data.OleDb
Public Class frmcetaksertifikat


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call kecuali()
    End Sub
    Sub kecuali()
        If Label3.Text = "Belum Lulus" Then
            MsgBox("Maaf! Siswa ini belum Lulus", MsgBoxStyle.Information, "Perhatian")
            TextBox1.Focus()
        ElseIf Label5.Text = "Belum Lunas" Or Label5.Text = "Angsur" Then
            MsgBox("Maaf! Siswa ini belum melunasi pembayaran", MsgBoxStyle.Information, "Perhatian")
            TextBox1.Focus()
        ElseIf Label3.Text = "Lulus" And Label5.Text = "Lunas" Then
            frmsertifikat.Sertifikat1.SetParameterValue("nis1", Label2.Text)
            frmsertifikat.Sertifikat1.SetParameterValue("nis2", Label2.Text)
            frmsertifikat.ShowDialog()
        Else
            MsgBox("Maaf! Siswa tidak bisa mendapatkan sertifikat", MsgBoxStyle.Information, "Perhatian")
            TextBox1.Focus()
        End If
    End Sub
    Sub updatelulus()
        Dim status As String
        status = "Lulus"
        Try
            Call koneksi()
            Dim str As String

            str = "Update pendaftaran set status = '" & status & "' where nis = '" & Label2.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Selamat anda telah lulus. Klik cetak sertifikat untuk mencetak sertifikat")
            Call listdata()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmcetaksertifikat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosong()
        Call listdata()
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
    Public Sub listdata()
        Call clearlist()

        Dim aksi As String
        Dim x As Integer

        aksi = "select * from pendaftaran where nama like '%" & Trim(TextBox1.Text) & "%' order by nis asc"

        Call koneksi()

        Dim cmd As New OleDbCommand(aksi, cnn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader

        Try
            While dr.Read
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1)

                With ListView1
                    ListView1.Items.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = dr.GetString(1)
                    ListView1.Items(x).SubItems(2).Text = dr.GetString(5)
                    ListView1.Items(x).SubItems(3).Text = dr.GetDateTime(4)
                    ListView1.Items(x).SubItems(4).Text = dr.GetString(6)
                    ListView1.Items(x).SubItems(5).Text = dr.GetString(10)
                End With
            End While
        Finally
            dr.Close()

        End Try
    End Sub
    Sub pilih()
        Try
            Label2.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            Label3.Text = ListView1.SelectedItems(0).SubItems(5).Text.ToString
        Catch ex As Exception
        End Try
    End Sub

    Public Sub clearlist()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call listdata()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Call pilih()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Call pilih()
        Call tampilsttbyr()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label3.Text = "Berhenti/Resign" Then
            MsgBox("Maaf! Siswa ini telah berhenti", MsgBoxStyle.Information, "Perhatian")
            TextBox1.Focus()
        Else
            CETAKKARTU.kw1.SetParameterValue("nis", Label2.Text)
            CETAKKARTU.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Call kosong()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim status As String
        cmd = New OleDbCommand("SELECT *FROM pendaftaran WHERE nis='" & Label2.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            status = dr.Item(10)
            If status = "Lulus" Then
                MsgBox("Siswa ini sudah lulus!", MsgBoxStyle.Critical)
                TextBox1.Focus()
            ElseIf status = "Berhenti/Resign" Then
                MsgBox("Siswa ini sudah berhenti!", MsgBoxStyle.Critical)
                TextBox1.Focus()
            ElseIf Label5.Text = "Belum Lunas" Then
                MsgBox("Maaf! Siswa ini belum melunasi pembayaran", MsgBoxStyle.Information, "Perhatian")
                TextBox1.Focus()
            ElseIf Label5.Text = "Angsur" Then
                MsgBox("Maaf! Siswa ini belum melunasi pembayaran", MsgBoxStyle.Information, "Perhatian")
                TextBox1.Focus()
            ElseIf Label5.Text = "Lunas" Then
                Call updatelulus()
                Call listdata()
            Else
                MsgBox("Maaf! Siswa tidak bisa diluluskan", MsgBoxStyle.Information, "Perhatian")
                TextBox1.Focus()
            End If
        Else
        End If
    End Sub
    Sub tampilsttbyr()
        Dim status2 As String
        cmd = New OleDbCommand("SELECT *FROM pembayaran WHERE nis='" & Label2.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            status2 = dr.Item(12)
            Label5.Text = status2
        Else
            Label5.Text = "Belum Lunas"
        End If
    End Sub
End Class