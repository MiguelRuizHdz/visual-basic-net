Public Class Form1
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub cmdEvaluar_Click(sender As Object, e As EventArgs) Handles cmdEvaluar.Click
        Dim valor1, valor2, valor3, mayor, menor, medio As Integer
        valor1 = CInt(txtValor1.Text)
        valor2 = CInt(txtValor2.Text)
        valor3 = CInt(txtValor3.Text)
        If (valor1 > valor2 And valor1 > valor3) Then
            mayor = valor1
            If (valor2 < valor3) Then
                menor = valor2
                medio = valor3
            Else
                menor = valor3
                medio = valor2
            End If
        End If
        If (valor2 > valor1 And valor2 > valor3) Then
            mayor = valor2
            If (valor1 < valor3) Then
                menor = valor1
                medio = valor3
            Else
                menor = valor3
                medio = valor1
            End If
        End If
        If (valor3 > valor1 And valor3 > valor2) Then
            mayor = valor3
            If (valor1 < valor2) Then
                menor = valor1
                medio = valor2
            Else
                menor = valor2
                medio = valor1
            End If
        End If
        lblMayor.Text = mayor.ToString
        lblMenor.Text = menor.ToString
        lblMedio.Text = medio.ToString

    End Sub
End Class
