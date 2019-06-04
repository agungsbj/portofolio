Public Class FormLapJual

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormLapJualNama.CrystalReportViewer1.RefreshReport()
        FormLapJualNama.ShowDialog()
    End Sub
End Class