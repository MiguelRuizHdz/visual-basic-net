Public Class Conexion

    Public Shared Function cadenaconexion() As String
        Return "Data Source = localhost; Initial Catalog = Agencia;Trusted_Connection=True;"
        'Return "Data Source = MD3KG02C\SQLEXPRESS,1433; Initial Catalog = Agencia;Integrated Security=true"
    End Function
End Class
