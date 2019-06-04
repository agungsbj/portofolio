Public Class FormCtkLapJualBeli

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            Call penjualan()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Call pembelian()
        Else
            MsgBox("Pilih Laporan!!!")
        End If
    End Sub
    Sub penjualan()
        FormLapJual.rptpenjualan1.SetParameterValue("awal", DateTimePicker1.Text)
        FormLapJual.rptpenjualan1.SetParameterValue("akhir", DateTimePicker2.Text)
        FormLapJual.Show()
    End Sub
    Sub pembelian()
        FormLapBeli.rptpembelian1.SetParameterValue("awal", DateTimePicker1.Text)
        FormLapBeli.rptpembelian1.SetParameterValue("akhir", DateTimePicker2.Text)
        FormLapBeli.Show()
    End Sub
End Class