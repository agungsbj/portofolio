Public Class Lapuang

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FLapUang.rptkeuangan1.SetParameterValue("awal", DateTimePicker1.Value)
        FLapUang.rptkeuangan1.SetParameterValue("akhir", DateTimePicker2.Value)
        FLapUang.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Lapuang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasikanan(Me, True)
    End Sub
End Class