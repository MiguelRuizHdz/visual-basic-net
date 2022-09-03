Imports Entidades
Imports Datos
Public Class nAutomovil

    Dim dAutomovil As New datoAutomovil

    Public Function AgregarAutomovil(automovil As eAutomovil) As Integer
        Return dAutomovil.AgregarAutomovil(automovil)
    End Function

    Public Function ActualizarAutomovil(automovil As eAutomovil) As Integer
        Return dAutomovil.ActualizarAutomovil(automovil)
    End Function

    Public Function ConsultarAutomovil(automovilid As Integer) As eAutomovil
        Return dAutomovil.ConsultarAutomovil(automovilid)
    End Function

    Public Function ConsultarAutomovil() As List(Of eAutomovil)
        Return dAutomovil.ConsultarAutomovil()
    End Function

    Public Function EliminarAutomovil(automovilid As Integer) As Integer
        Return dAutomovil.EliminarAutomovil(automovilid)
    End Function

End Class
