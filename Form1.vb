Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim discreminant As Decimal
    Dim root1 As Double
    Dim root2 As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        discreminant = (b * b) - (4 * a * c)
        root1 = ((-1 * b) + Math.Sqrt(discreminant)) / (2 * a)
        root2 = ((-1 * b) - Math.Sqrt(discreminant)) / (2 * a)

        TextBox4.Text = root1
        TextBox5.Text = root2
    End Sub
End Class
