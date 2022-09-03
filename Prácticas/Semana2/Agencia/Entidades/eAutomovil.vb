Public Class eAutomovil
    Private _automovilid As Integer
    Private _marca As String
    Private _modelo As String
    Private _anio As Integer
    Private _precio As Integer

    Public Property Automovilid As Integer
        Get
            Return _automovilid
        End Get
        Set(value As Integer)
            _automovilid = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return _anio
        End Get
        Set(value As Integer)
            _anio = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(automovilid As Integer, marca As String, modelo As String, anio As Integer, precio As Integer)
        _automovilid = automovilid
        _marca = marca
        _modelo = modelo
        _anio = anio
        _precio = precio
    End Sub

End Class
