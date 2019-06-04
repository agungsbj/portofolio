Public Class MenuPendaftaran

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DaftarPasien.lblnama.Text = lblnama.Text
        DaftarPasien.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Antrian.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LapPasien.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
    Private Sub MenuPendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
        cuaca()
    End Sub
End Class