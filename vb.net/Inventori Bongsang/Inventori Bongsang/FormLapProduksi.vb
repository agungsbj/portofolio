Public Class FormLapProduksi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormLapIsiProd.Produksi1.SetParameterValue("awal", DateTimePicker1.Value)
        FormLapIsiProd.Produksi1.SetParameterValue("akhir", DateTimePicker2.Value)
        FormLapIsiProd.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class