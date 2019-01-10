Imports System.Data.SqlClient
Imports Northwind.Entidades

Public Class RegionDAO : Implements RegionService
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub
    Public Function ObtenerRegion() As List(Of RegionBE) Implements RegionService.ObtenerRegion
        Dim listaResp As New List(Of RegionBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_REGIONES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _RegionBE As New RegionBE
                            _RegionBE.RegionId = reader("Codigo")
                            _RegionBE.RegionValue = reader("Descripcion")
                            listaResp.Add(_RegionBE)
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

    Public Function ObtenerRegionData() As DataTable Implements RegionService.ObtenerRegionData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_REGIONES"
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

    Public Function ObtenerRegionPorId(codigo As String) As List(Of RegionBE) Implements RegionService.ObtenerRegionPorId
        Dim listaResp As New List(Of RegionBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_REGION_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@REGION", SqlDbType.NVarChar).Value = codigo
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _RegionBE As New RegionBE
                            _RegionBE.RegionId = reader("Codigo")
                            _RegionBE.RegionValue = reader("Descripcion")
                            listaResp.Add(_RegionBE)
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

    Public Function ObtenerRegionPorIdData(codigo As String) As DataTable Implements RegionService.ObtenerRegionPorIdData
        Dim dtResp As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.CommandText = "SP_SEL_OBTENER_REGION_X_ID"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@REGION", SqlDbType.NVarChar).Value = codigo
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
