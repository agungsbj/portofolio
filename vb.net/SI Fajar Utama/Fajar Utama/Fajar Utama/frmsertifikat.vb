Public Class frmsertifikat

    Private Sub frmsertifikat_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Sertifikat1.SetParameterValue("nis1", frmcetaksertifikat.Label2.Text)
        Sertifikat1.SetParameterValue("nis2", frmcetaksertifikat.Label2.Text)
    End Sub

    Private Sub frmsertifikat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sertifikat1.SetParameterValue("nis1", frmcetaksertifikat.Label2.Text)
        Sertifikat1.SetParameterValue("nis2", frmcetaksertifikat.Label2.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call frmcetaksertifikat.listdata()
        Call frmcetaksertifikat.kosong()
        Me.Close()
        Me.Dispose()
    End Sub
End Class