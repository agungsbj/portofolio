Public Class MenuUtama
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        FormHasil.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        FormPenilaian.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        InputGuru.ShowDialog()
        InputGuru.Button4.Visible = True
        InputGuru.Button5.Visible = True
        InputGuru.Button6.Visible = True
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Label1.Text = "Input Data Guru"
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        Label1.Text = "Input Penilaian Guru"
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        Label1.Text = "Hasil Penilaian Guru"
    End Sub

End Class
