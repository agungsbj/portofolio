Imports System.Data.OleDb
Public Class FormHasil
    Sub cari()
        Call koneksi()
        da = New OleDbDataAdapter("select guru.nip, guru.nama, guru.jabatan, loghasil.masajabatan, loghasil.hasil from guru inner join loghasil on guru.nip = loghasil.nip where guru.nama like '%" & Trim(TextBox6.Text) & "%' order by loghasil.hasil desc", cnn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "detail")
        DataGridView1.DataSource = ds.Tables("detail")
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 120
        DataGridView1.Columns(0).HeaderText = "NIP"
        DataGridView1.Columns(1).HeaderText = "NAMA GURU"
        DataGridView1.Columns(2).HeaderText = "JABATAN"
        DataGridView1.Columns(3).HeaderText = "MASA JABATAN"
        DataGridView1.Columns(4).HeaderText = "HASIL"
        DataGridView1.Refresh()
        tampilreset()
    End Sub

    Sub pilihgrid()
        Dim ubah As Integer = Nothing
        ubah = DataGridView1.CurrentRow.Index
        With DataGridView1
            Label2.Text = .Item(1, ubah).Value
            Label1.Text = .Item(0, ubah).Value
        End With
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        cari()
        tampilreset()
    End Sub
    Sub tampilreset()
        If Chart1.Visible = False Then
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False
        Else
            Button2.Visible = False
            Button1.Visible = False
            Button3.Visible = True
        End If
    End Sub

    Private Sub FormHasil_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampilreset()
    End Sub
    Private Sub FormHasil_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Chart1.Visible = False
        cari()
        DataGridView1.Refresh()
    End Sub

    Private Sub FormHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilreset()
        cari()
        Dim jmldata As Integer
        jmldata = DataGridView1.RowCount
        If jmldata = 0 Then
            MsgBox("Maaf belum ada data penilaian, isi data penilaian terlebih dahulu")
            Me.Close()
        ElseIf jmldata > 0 Then
            Chart1.Visible = False
            pilihgrid()
            Dim pesan As String
            pesan = MsgBox("Guru Terbaik adalah " + Label2.Text + " Untuk melihat grafik penilaian pilih Yes", vbQuestion + vbYesNo, "pesan")
            If pesan = vbYes Then
                grafik()
                Chart1.Visible = True
                Chart1.Dock = DockStyle.Fill
                Me.WindowState = FormWindowState.Maximized
            Else
                TextBox6.Focus()
                Me.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub
    Sub grafik()
        Try
            Chart1.Series.Add("Hasil")
            Dim cmd As OleDbCommand = New OleDbCommand("select * from loghasil where nip like '%" & Label1.Text & _
                                      "%' order by nip asc", cnn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                Chart1.Series("Hasil").Points.AddXY("Kehadiran", dr("p1").ToString)
                Chart1.Series("Hasil").Points.AddXY("Keterampilan", dr("p2").ToString)
                Chart1.Series("Hasil").Points.AddXY("Wawasan Luas", dr("p3").ToString)
                Chart1.Series("Hasil").Points.AddXY("Menguasai Media Pembelajaran", dr("p4").ToString)
                Chart1.Series("Hasil").Points.AddXY("Penguasaan Teknologi", dr("p5").ToString)
                Chart1.Series("Hasil").Points.AddXY("Kepribadian", dr("p6").ToString)
                Chart1.Series("Hasil").Points.AddXY("Teladan yang Baik", dr("p7").ToString)
            End While
        Catch ex As Exception
            MsgBox("Error !", MsgBoxStyle.Critical, ex)
        End Try
        tampilreset()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim ubah As Integer = Nothing
            ubah = DataGridView1.CurrentRow.Index
            With DataGridView1
                Label1.Text = .Item(0, ubah).Value
                Label2.Text = .Item(1, ubah).Value
            End With
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        grafik()
        Chart1.Visible = True
        Chart1.Dock = DockStyle.Fill
        tampilreset()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Chart1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chart1.DoubleClick
        Chart1.Visible = False
        Chart1.Dock = DockStyle.None
        Chart1.Series.Clear()
        tampilreset()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Sub hapus()
        Try
            Dim str As String
            str = "Delete * from loghasil"
            cmd = New OleDbCommand(str, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di reset")
        Catch ex As Exception
            MsgBox("Gagal Mereset Data Karena " + ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hapus()
        cari()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
    Sub penjabaran()
        Dim status As String
        Dim p1, p2, p3, p4, p5, p6, p7, p1x, p2x, p3x, p4x, p5x, p6x, p7x, p1j, p2j, p3j, p4j, p5j, p6j, p7j As String
        p1x = "disiplin waktu"
        p2x = "keterampilan mengajar"
        p3x = "wawasan"
        p4x = "media pembelajaran"
        p5x = "teknologi"
        p6x = "pribadi"
        p7x = "teladan"

        cmd = New OleDbCommand("SELECT *FROM loghasil WHERE nip='" & Label1.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            p1 = dr.Item(4)
            p2 = dr.Item(5)
            p3 = dr.Item(6)
            p4 = dr.Item(7)
            p5 = dr.Item(8)
            p6 = dr.Item(9)
            p7 = dr.Item(10)
        End If

        If p1 >= 7 Then
            p1j = p1x + " yang baik"
        Else
            p1j = p1x + " kurang baik"
        End If

        If p2 >= 7 Then
            p2j = p2x + " yang baik"
        Else
            p2j = p2x + " kurang baik"
        End If

        If p3 >= 7 Then
            p3j = p3x + " yang luas"
        Else
            p3j = p3x + " yang sempit"
        End If

        If p4 >= 7 Then
            p4j = " menguasai " + p4x
        Else
            p4j = " kurang menguasai " + p4x
        End If

        If p5 >= 7 Then
            p5j = " menguasai " + p5x
        Else
            p5j = " kurang menguasai " + p5x
        End If

        If p6 >= 7 Then
            p6j = p6x + " yang baik"
        Else
            p6j = p6x + " kurang baik"
        End If

        If p7 >= 7 Then
            p7j = p7x + " yang baik"
        Else
            p7j = p7x + " kurang baik"
        End If

        MsgBox(Label2.Text + " memiliki " + p1j + ", " + p2j + ", " + p3j + ", " + p4j + ", " + p5j + ", " + p6j + " dan " + p7j + " " + Label2.Text + " Dapat dikandidatkan sebagai wakil kepala sekolah")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        penjabaran()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class