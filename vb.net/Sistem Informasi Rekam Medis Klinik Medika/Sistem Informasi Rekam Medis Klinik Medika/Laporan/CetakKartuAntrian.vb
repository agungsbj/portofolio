Public Class CetakKartuAntrian

    Private Sub CetakKartuAntrian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class