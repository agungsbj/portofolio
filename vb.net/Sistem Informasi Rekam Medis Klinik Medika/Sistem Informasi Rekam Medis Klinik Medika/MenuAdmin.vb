Public Class MenuAdmin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DaftarObat.lblnama.Text = lblnama.Text
        DaftarObat.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DaftarPasien.lblnama.Text = lblnama.Text
        DaftarPasien.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DaftarUser.lblnama.Text = lblnama.Text
        DaftarUser.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LogAktivitas.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.01
            Application.DoEvents()
            Threading.Thread.Sleep(2) 'jedah waktu = 2
        Loop
        Me.Dispose()
    End Sub
    Sub cuaca()
        Dim jam As String
        jam = Format(Now, "HH")

        If jam <= 4 Then
            Label9.Text = "Dini Hari"
        ElseIf jam <= 10 Then
            Label9.Text = "Pagi"
        ElseIf jam <= 14 Then
            Label9.Text = "Siang"
        ElseIf jam <= 17 Then
            Label9.Text = "Sore"
        ElseIf jam = 18 Then
            Label9.Text = "Petang"
        ElseIf jam <= 23 Then
            Label9.Text = "Malam"
        End If
    End Sub

    Private Sub MenuAdmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.01
            Application.DoEvents()
            Threading.Thread.Sleep(2) 'jedah waktu = 2
        Loop
    End Sub
    Private Sub MenuAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
        cuaca()
    End Sub
End Class