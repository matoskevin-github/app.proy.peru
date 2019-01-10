Imports System.Data.SqlClient
Imports Northwind.Entidades

Public Class CountryDAO : Implements CountryService
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler()
    End Sub
    Public Function ObtenerCountry() As List(Of CountryBE) Implements CountryService.ObtenerCountry
        Dim listaResp As New List(Of CountryBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_PAISES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _CountryBE As New CountryBE
                            _CountryBE.CountryId = reader("Codigo")
                            _CountryBE.CountryValue = reader("Descripcion")
                            listaResp.Add(_CountryBE)
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

    Public Function ObtenerCountryData() As DataTable Implements CountryService.ObtenerCountryData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_PAISES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
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

    Public Function ObtenerCountryPorId(codigo As String) As List(Of CountryBE) Implements CountryService.ObtenerCountryPorId
        Dim listaResp As New List(Of CountryBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_PAIS_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@PAIS", SqlDbType.NVarChar).Value = codigo
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _CountryBE As New CountryBE
                            _CountryBE.CountryId = reader("Codigo")
                            _CountryBE.CountryValue = reader("Descripcion")
                            listaResp.Add(_CountryBE)
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

    Public Function ObtenerCountryPorIdData(codigo As String) As DataTable Implements CountryService.ObtenerCountryPorIdData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_PAIS_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@PAIS", SqlDbType.NVarChar).Value = codigo
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

