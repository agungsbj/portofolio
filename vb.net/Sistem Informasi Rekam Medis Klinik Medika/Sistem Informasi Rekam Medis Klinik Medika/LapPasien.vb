Imports System.Data.OleDb
Public Class LapPasien


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FLapPasien.rptpasien1.SetParameterValue("Awal", DateTimePicker1.Value)
        FLapPasien.rptpasien1.SetParameterValue("Akhir", DateTimePicker2.Value)
        FLapPasien.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub LapPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animasibawah(Me, True)
    End Sub
End Class