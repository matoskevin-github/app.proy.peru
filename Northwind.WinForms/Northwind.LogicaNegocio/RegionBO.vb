Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class RegionBO
    Private _RegionDAO As RegionDAO

    Public Sub New()
        _RegionDAO = New RegionDAO()
    End Sub

    Public Function ObtenerRegion() As List(Of RegionBE)
        Return _RegionDAO.ObtenerRegion
    End Function

    Public Function ObtenerRegionData() As DataTable
        Return _RegionDAO.ObtenerRegionData
    End Function

    Public Function ObtenerRegionPorId(codigo As String) As List(Of RegionBE)
        Return _RegionDAO.ObtenerRegionPorId(codigo)
    End Function

    Public Function ObtenerRegionPorIdData(codigo As String) As DataTable
        Return _RegionDAO.ObtenerRegionPorIdData(codigo)
    End Function
End Class
