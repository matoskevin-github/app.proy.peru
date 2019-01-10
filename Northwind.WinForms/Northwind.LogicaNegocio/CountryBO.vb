Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class CountryBO
    Private _CountryDAO As CountryDAO

    Public Sub New()
        _CountryDAO = New CountryDAO()
    End Sub
    Public Function ObtenerCountry() As List(Of CountryBE)
        Return _CountryDAO.ObtenerCountry()
    End Function

    Public Function ObtenerCountryData() As DataTable
        Return _CountryDAO.ObtenerCountryData()
    End Function

    Public Function ObtenerCountryPorId(codigo As String) As List(Of CountryBE)
        Return _CountryDAO.ObtenerCountryPorId(codigo)
    End Function

    Public Function ObtenerCountryPorIdData(codigo As String) As DataTable
        Return _CountryDAO.ObtenerCountryPorIdData(codigo)
    End Function
End Class
