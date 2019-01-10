Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class CityBO
    Private _CityDAO As CityDAO

    Public Sub New()
        _CityDAO = New CityDAO()
    End Sub

    Public Function ObtenerCity() As List(Of CityBE)
        Return _CityDAO.ObtenerCity()
    End Function

    Public Function ObtenerCityData() As DataTable
        Return _CityDAO.ObtenerCityData
    End Function

    Public Function ObtenerCityPorId(codigo As String) As List(Of CityBE)
        Return _CityDAO.ObtenerCityPorId(codigo)
    End Function

    Public Function ObtenerCityPorIdData(codigo As String) As DataTable
        Return _CityDAO.ObtenerCityPorIdData(codigo)
    End Function
End Class
