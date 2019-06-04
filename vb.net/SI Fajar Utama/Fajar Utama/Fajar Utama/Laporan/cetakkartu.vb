Public Class CETAKKARTU

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CETAKKARTU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        kw1.SetParameterValue("nis", frmPendaftaran.TextBox1.Text)
    End Sub
End Class