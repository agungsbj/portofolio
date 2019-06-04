Public Class Lapobat
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FLapObat.rptobat1.SetParameterValue("awal", DateTimePicker1.Value)
        FLapObat.rptobat1.SetParameterValue("akhir", DateTimePicker2.Value)
        FLapObat.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Lapobat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikanan(Me, True)
    End Sub
End Class