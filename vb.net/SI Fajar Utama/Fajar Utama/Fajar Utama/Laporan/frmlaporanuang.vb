Public Class frmlaporanuang

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call resetcombo1()
        Call resetcombo2()
        Me.Dispose()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.Enabled = True
        Panel2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Panel2.Enabled = True
        Panel1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim int_bulan As Integer

        Try
            Select Case ComboBox1.Text
                Case "Januari"
                    int_bulan = 1
                Case "Februari"
                    int_bulan = 2
                Case "Maret"
                    int_bulan = 3
                Case "April"
                    int_bulan = 4
                Case "Mei"
                    int_bulan = 5
                Case "Juni"
                    int_bulan = 6
                Case "Juli"
                    int_bulan = 7
                Case "Agustus"
                    int_bulan = 8
                Case "September"
                    int_bulan = 9
                Case "Oktober"
                    int_bulan = 10
                Case "November"
                    int_bulan = 11
                Case "Desember"
                    int_bulan = 12
            End Select

            If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pilih Bulan dan Tahun Lebih Dulu!!", MsgBoxStyle.Information)
            Else
                frmLapUangBulanan.CrystalReportViewer1.SelectionFormula = "Month({pembayaran.tglbayar}) =" & Val(int_bulan) & " and Year({pembayaran.tglbayar}) =" & Val(ComboBox2.Text)
                frmLapUangBulanan.CrystalReportViewer1.RefreshReport()
                frmLapUangBulanan.Show()
            End If

        Catch ex As Exception

            MessageBox.Show("Report Error", "Form Filter Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call resetcombo1()
        RadioButton1.Checked = False
        Panel1.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox3.Text = "" Then
            MsgBox("Pilih Tahun Lebih Dulu!!", MsgBoxStyle.Information)
        Else
            frmLapUangTahunan.CrystalReportViewer1.SelectionFormula = "Year({pembayaran.tglbayar}) =" & Val(ComboBox3.Text)
            frmLapUangTahunan.CrystalReportViewer1.RefreshReport()
            frmLapUangTahunan.Show()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call resetcombo2()
        RadioButton2.Checked = False
        Panel2.Enabled = False
    End Sub

    Private Sub frmlaporanuang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Enabled = False
        Panel2.Enabled = False
    End Sub
    Sub resetcombo1()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    Sub resetcombo2()
        ComboBox3.SelectedIndex = -1
    End Sub
End Class