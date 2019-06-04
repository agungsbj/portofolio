Public Class SuratKesehatan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Call SuratKet.autonumber()
    End Sub

    Private Sub SuratKesehatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
    End Sub
End Class