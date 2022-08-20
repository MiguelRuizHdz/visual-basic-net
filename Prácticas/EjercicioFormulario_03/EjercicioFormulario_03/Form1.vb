Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valorUno, ValorDos As Integer
        valorUno = 10
        ValorDos = 3
        TextBox1.Text = valorUno + ValorDos
        TextBox2.Text = valorUno - ValorDos
        TextBox3.Text = valorUno * ValorDos
        TextBox4.Text = valorUno / ValorDos
        TextBox5.Text = valorUno \ ValorDos
        TextBox6.Text = valorUno Mod ValorDos
        TextBox7.Text = valorUno ^ ValorDos
    End Sub
End Class
