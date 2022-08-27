Module Module1

    Sub Main()
        'Console.WriteLine("Hola Mundo!!")
        Dim edad As Integer
        Dim nombre As String
        edad = 21
        Dim edads As String
        edads = edad.ToString

        nombre = "Miguel"
        'Amperson (&) transforma la variable edad en string
        Console.WriteLine("Hola mi nombre es " & nombre & " y tengo " & edad & " años")
        'Console.WriteLine("Hola mi nombre es " + nombre + " y tengo " + edads + " años")

        Console.ReadKey()
    End Sub

End Module
