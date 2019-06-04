Imports System.Data.OleDb
Public Class FormLogin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Label6.Visible = True
            TextBox1.Focus()
        Else
            Panel2.Visible = True
            TextBox2.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox2.Visible = True
        Call login()
    End Sub

    Sub login()
        Call koneksi()

        cmd = New OleDbCommand("SELECT *FROM login WHERE username='" & TextBox1.Text & _
                                "' and pass='" & TextBox2.Text & "'", cnn)
        dr = cmd.ExecuteReader

        If (dr.Read()) Then
            Panel3.Visible = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            Button3.Focus()
        Else
            Panel4.Visible = True
            Button4.Focus()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Dispose()
        FormLoginUtama.Show()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2.Focus()
            Call login()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel4.Visible = False
        PictureBox2.Visible = False
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel3.Visible = False
        Me.Hide()
        MenuBaru.ShowDialog()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel4.Visible = False
        TextBox2.Focus()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
    End Sub
    Sub awal()
        TextBox1.Focus()
        Label6.Visible = False
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Panel2.Visible = False
    End Sub
End Class