Public Class LapRM

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FLapRMed.rptrekmed1.SetParameterValue("awal", DateTimePicker1.Value)
        FLapRMed.rptrekmed1.SetParameterValue("akhir", DateTimePicker2.Value)
        FLapRMed.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub LapRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikiri(Me, True)
    End Sub
End Class