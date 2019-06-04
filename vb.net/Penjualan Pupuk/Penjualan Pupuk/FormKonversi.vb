Public Class FormKonversi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "TON"
        Label2.Text = "KG"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "KG"
        Label2.Text = "TON"
    End Sub

    Private Sub FormKonversi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub tonkg()
        Dim ton As Double
        Dim kg As Double
        ton = TextBox1.Text
        kg = ton * 1000
        TextBox2.Text = kg
    End Sub

    Sub kgton()
        Dim ton As Double
        Dim kg As Double
        kg = TextBox1.Text
        ton = kg / 1000
        TextBox2.Text = ton
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Text = "KG" Then
            Call kgton()
        Else
            Call tonkg()
        End If
    End Sub
End Class