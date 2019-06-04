Public Class LapBuatSurat

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FLapBuatSurat.rptbuatsurat1.SetParameterValue("awal", DateTimePicker1.Value)
        FLapBuatSurat.rptbuatsurat1.SetParameterValue("akhir", DateTimePicker2.Value)
        FLapBuatSurat.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub LapBuatSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasiatas(Me, True)
    End Sub
End Class