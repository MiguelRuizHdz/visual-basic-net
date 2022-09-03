Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports Entidades
Public Class datoAutomovil
    Public Sub New()

    End Sub
    Dim cnn As New SqlClient.SqlConnection(Datos.Conexion.cadenaconexion())

    Public Function AgregarAutomovil(automovil As eAutomovil) As Integer
        Dim cnn As New SqlConnection(Conexion.cadenaconexion())
        Dim cmd As New SqlCommand("AutomovilInserta", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("Marca", SqlDbType.VarChar, 100).Value = automovil.Marca
        cmd.Parameters.Add("Modelo", SqlDbType.VarChar, 100).Value = automovil.Modelo
        cmd.Parameters.Add("Anio", SqlDbType.Int).Value = automovil.Anio
        cmd.Parameters.Add("Precio", SqlDbType.Int).Value = automovil.Precio

        Dim id As Integer
        id = 0
        cnn.Open()
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            id = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return id
    End Function


    Public Function ActualizarAutomovil(automovil As eAutomovil) As Integer
        Dim cnn As New SqlConnection(Conexion.cadenaconexion())
        Dim cmd As New SqlCommand("AutomovilActualiza", cnn)
        Dim id As Integer
        id = 0
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("AutomovilId", SqlDbType.Int).Value = automovil.Automovilid
        cmd.Parameters.Add("Marca", SqlDbType.VarChar, 100).Value = automovil.Marca
        cmd.Parameters.Add("Modelo", SqlDbType.VarChar, 100).Value = automovil.Modelo
        cmd.Parameters.Add("Anio", SqlDbType.Int).Value = automovil.Anio
        cmd.Parameters.Add("Precio", SqlDbType.Int).Value = automovil.Precio

        cnn.Open()
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            id = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return id
    End Function


    Public Function ConsultarAutomovil(ByVal automovilid As Integer) As eAutomovil
        Dim cnn As New SqlConnection(Conexion.cadenaconexion())
        Dim cmd As New SqlCommand("AutomovilConsultaXId", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim automovil As New eAutomovil
        cmd.Parameters.Add("AutomovilId", SqlDbType.Int).Value = automovilid
        cnn.Open()

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                automovil.Marca = dr("Marca")
                automovil.Modelo = dr("Modelo")
                automovil.Anio = dr("Anio")
                automovil.Precio = dr("Precio")
            End If
            dr.Close()
            cnn.Close()
        Catch ex As Exception
            Return automovil
        End Try

        Return automovil
    End Function

    Public Function ConsultarAutomovil() As List(Of eAutomovil)
        Dim cnn As New SqlConnection(Conexion.cadenaconexion())
        Dim cmd As New SqlCommand("AutomovilConsulta", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim lAutomovil As New List(Of eAutomovil)()
        Dim automovil As eAutomovil

        cnn.Open()

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read())
                    automovil = New eAutomovil
                    automovil.Automovilid = dr("AutomovilId")
                    automovil.Marca = dr("Marca")
                    automovil.Modelo = dr("Modelo")
                    automovil.Anio = dr("Anio")
                    automovil.Precio = dr("Precio")
                    lAutomovil.Add(automovil)
                End While
            End If
            dr.Close()
            cnn.Close()
        Catch ex As Exception
            Return lAutomovil
        End Try

        Return lAutomovil
    End Function

    Public Function EliminarAutomovil(ByVal automovilid As Integer) As Integer
        Dim cnn As New SqlConnection(Conexion.cadenaconexion())
        Dim cmd As New SqlCommand("AutomovilElimina", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("AutomovilId", SqlDbType.Int).Value = automovilid
        cnn.Open()

        Dim id As Integer
        id = 0
        cnn.Open()
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            id = cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            Return 0
        End Try

        Return id
    End Function


End Class
