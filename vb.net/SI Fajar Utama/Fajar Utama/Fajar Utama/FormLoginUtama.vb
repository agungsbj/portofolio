Public Class FormLoginUtama
    Sub tampil()
        PictureBox2.Image = Nothing
        TextBox1.Clear()
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Hide()
        FormLogin.ShowDialog()
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove
        PictureBox2.Image = PictureBox8.Image
        TextBox1.Text = "Login Admin"
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormLoginIns.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Call tampil()
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox2.Image = PictureBox1.Image
        TextBox1.Text = "Login Instruktur"
    End Sub

   
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        End
    End Sub
End Class