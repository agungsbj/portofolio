Imports System.Data.OleDb
Public Class FrmDataSiswa
    Public Sub listdatanama()
        Call clearlist()

        Dim nama As String
        Dim x As Integer

        nama = "select * from pendaftaran where nama like '%" & Trim(TextBox1.Text) & "%' order by nis asc"
        
        Call koneksi()

        Dim cmd As New OleDbCommand(nama, cnn)
        Dim dr1 As OleDbDataReader
        dr1 = cmd.ExecuteReader

        Try
            While dr1.Read
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
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr1.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = Format(dr1.GetDateTime(2), "dd MMM yyyy")
                    ListView1.Items(x).SubItems(2).Text = dr1.GetString(1)
                    ListView1.Items(x).SubItems(3).Text = dr1.GetString(5)
                    ListView1.Items(x).SubItems(4).Text = dr1.GetString(9)
                    ListView1.Items(x).SubItems(5).Text = dr1.GetString(10)
                    ListView1.Items(x).SubItems(6).Text = dr1.GetString(11)
                End With
            End While
        Finally
            dr1.Close()
        End Try
    End Sub
    Public Sub listdatanis()
        Call clearlist()

        Dim nama As String
        Dim x As Integer

        nama = "select * from pendaftaran where nis like '%" & Trim(TextBox1.Text) & "%' order by nis asc"

        Call koneksi()

        Dim cmd As New OleDbCommand(nama, cnn)
        Dim dr1 As OleDbDataReader
        dr1 = cmd.ExecuteReader

        Try
            While dr1.Read
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
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")

                    ListView1.Items(x).SubItems(0).Text = dr1.GetString(0)
                    ListView1.Items(x).SubItems(1).Text = Format(dr1.GetDateTime(2), "dd MMM yyyy")
                    ListView1.Items(x).SubItems(2).Text = dr1.GetString(1)
                    ListView1.Items(x).SubItems(3).Text = dr1.GetString(5)
                    ListView1.Items(x).SubItems(4).Text = dr1.GetString(9)
                    ListView1.Items(x).SubItems(5).Text = dr1.GetString(10)
                    ListView1.Items(x).SubItems(6).Text = dr1.GetString(11)
                End With
            End While
        Finally
            dr1.Close()
        End Try


    End Sub
    Public Sub clearlist()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub
    Sub awal()
        TextBox1.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Call listdatanama()
    End Sub
    Private Sub FrmDataSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
    End Sub
    Sub tampil()
        cmd = New OleDbCommand("SELECT *FROM pembayaran WHERE nis='" & Label5.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            TextBox2.Text = dr.Item(0)
            TextBox4.Text = dr.Item(12)
        Else
            TextBox2.Text = "Tidak Ada"
            TextBox4.Text = "Tidak Ada"
        End If

        cmd = New OleDbCommand("SELECT *FROM lunas WHERE nis='" & Label5.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            TextBox3.Text = dr.Item(0)
        Else
            TextBox3.Text = "Tidak Ada"
        End If

        cmd = New OleDbCommand("SELECT *FROM pendaftaran WHERE nis='" & Label5.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            TextBox5.Text = dr.Item(12)
        Else
            TextBox5.Text = "Tidak Ada"
        End If
    End Sub
    Sub pilih()
        Try
            Label5.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Call pilih()
        Call tampil()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedIndex = 0 Then
            Call listdatanis()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Call listdatanama()
        Else
            MsgBox("Pilih kategori  dulu")
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label1.Text = "Cari NIS"
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label1.Text = "Cari Nama"
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            Call awal()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
    End Sub
    Sub Updatesiswa()
        Try
            Dim str As String
            Dim status As String
            status = "Berhenti/Resign"

            str = "Update pendaftaran set Status = '" & status & "' where nis = '" & Label5.Text & "'"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Siswa dengan NIS telah diberhentikan")
        Catch ex As Exception
        End Try
    End Sub
    Sub Updatebayar()
        Try
            Dim str2 As String
            Dim sisa As String
            sisa = "0"
            Dim dp As String
            dp = "25000"
            Dim statusbyr As String
            statusbyr = "Refund"

            str2 = "Update pembayaran set dp = '" & dp & "', sisa = '" & sisa & "', statusbayar = '" & statusbyr & "' where nobayar = '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(str2, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Uang pembayaran paket yang telah dibayarkan, akan dikembalikan (kec. uang pendaftaran)")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text = "Tidak Ada" Then
            Call Updatesiswa()
            Call listdatanama()
        Else
            Call Updatesiswa()
            Call Updatebayar()
            Call listdatanama()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New OleDbCommand("SELECT *FROM pendaftaran WHERE nis='" & Label5.Text & "'", cnn)
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            frmPendaftaran.TextBox1.Text = dr.Item(0)
            frmPendaftaran.TextBox2.Text = dr.Item(1)
            frmPendaftaran.TextBox3.Text = dr.Item(3)
            frmPendaftaran.DTPick.Text = dr.Item(4)
            frmPendaftaran.Label8.Text = dr.Item(5)
            frmPendaftaran.TextBox4.Text = dr.Item(6)
            frmPendaftaran.TextBox6.Text = dr.Item(12)
        End If
        frmPendaftaran.Label7.Visible = False
        frmPendaftaran.ComboBox1.Visible = False
        frmPendaftaran.Button9.Visible = True
        frmPendaftaran.GroupBox2.Visible = False
        frmPendaftaran.Show()
    End Sub
End Class