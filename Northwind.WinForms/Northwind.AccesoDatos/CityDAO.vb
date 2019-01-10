Imports System.Data.SqlClient
Imports Northwind.Entidades

Public Class CityDAO : Implements CityService
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function ObtenerCity() As List(Of CityBE) Implements CityService.ObtenerCity
        Dim listaResp As New List(Of CityBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_CIUDADES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _CityBE As New CityBE
                            _CityBE.CityId = reader("Codigo")
                            _CityBE.CityValue = reader("Descripcion")
                            listaResp.Add(_CityBE)
                        End While
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return listaResp
    End Function

    Public Function ObtenerCityData() As DataTable Implements CityService.ObtenerCityData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_CIUDADES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using sqlAdp As SqlDataAdapter = New SqlDataAdapter(sqlCmd)
                        sqlAdp.Fill(dtResp)
                    End Using
                End Using
                sqlCnx.Close()
            End Using
            Return dtResp
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCityPorId(codigo As String) As List(Of CityBE) Implements CityService.ObtenerCityPorId
        Dim listaResp As New List(Of CityBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_CIUDAD_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@CIUDAD", SqlDbType.NVarChar).Value = codigo
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _CityBE As New CityBE
                            _CityBE.CityId = reader("Codigo")
                            _CityBE.CityValue = reader("Descripcion")
                            listaResp.Add(_CityBE)
                        End While
                    End Using
                End Using
            End Using
            Return listaResp
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCityPorIdData(codigo As String) As DataTable Implements CityService.ObtenerCityPorIdData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_CIUDAD_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@CIUDAD", SqlDbType.NVarChar).Value = codigo
                    Using sqlAdp As SqlDataAdapter = New SqlDataAdapter(sqlCmd)
                        sqlAdp.Fill(dtResp)
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return dtResp
    End Function
End Class
