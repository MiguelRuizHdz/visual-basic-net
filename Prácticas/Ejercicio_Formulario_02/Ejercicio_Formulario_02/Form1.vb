Public Class Form1

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim boleana As Boolean = False
        Dim bytes As Byte = 101
        Dim caracter As Char = "a"
        Dim fechas As Date
        Dim v_decimal As Decimal = 10.2
        Dim entero As Integer = 1000
        Dim doble As Double = 123456789
        Dim largo As Long = 1234567894
        Dim corto As Short = 27000
        Dim cadena As String = "Hola Mundo!"

        TextBox1.Text = boleana
        TextBox2.Text = bytes
        TextBox3.Text = caracter
        TextBox4.Text = fechas
        TextBox5.Text = v_decimal
        TextBox6.Text = doble
        TextBox7.Text = entero
        TextBox8.Text = largo
        TextBox9.Text = corto
        TextBox10.Text = cadena
    End Sub
End Class
