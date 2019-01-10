Imports Northwind.Entidades
Imports Northwind.LogicaNegocio

Public Class ViewTest
    Private Sub ViewTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Metodos ok
        'Dim oCityBO As New CityBO
        'Dim val As String = "Id-Tsawassen"
        'Dim lista As List(Of CityBE) = oCityBO.ObtenerCity()
        'Dim dtContenedor As DataTable = oCityBO.ObtenerCityData()
        'Dim lista2 As List(Of CityBE) = oCityBO.ObtenerCityPorId(val)
        'Dim dtContenedor2 As DataTable = oCityBO.ObtenerCityPorIdData(val)

        'Metodos ok
        'Dim oCountryBO As New CountryBO
        'Dim val As String = "Id-Poland"
        'Dim lista As List(Of CountryBE) = oCountryBO.ObtenerCountry()
        'Dim dtContenedor As DataTable = oCountryBO.ObtenerCountryData()
        'Dim lista2 As List(Of CountryBE) = oCountryBO.ObtenerCountryPorId(val)
        'Dim dtContenedor2 As DataTable = oCountryBO.ObtenerCountryPorIdData(val)

        'RegionBO
        Dim oRegionBO As New RegionBO
        Dim val As String = "Id-Lara"

        Dim lista As List(Of RegionBE) = oRegionBO.ObtenerRegion()
        Dim dtContenedor As DataTable = oRegionBO.ObtenerRegionData()
        Dim lista2 As List(Of RegionBE) = oRegionBO.ObtenerRegionPorId(val)
        Dim dtContenedor2 As DataTable = oRegionBO.ObtenerRegionPorIdData(val)

    End Sub
End Class