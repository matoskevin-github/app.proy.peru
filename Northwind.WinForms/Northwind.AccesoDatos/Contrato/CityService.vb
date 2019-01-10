Imports Northwind.Entidades

Public Interface CityService
#Region "INTERFACE QUE CONTIENE LOS METODOS DE CityBE."
    Function ObtenerCity() As List(Of CityBE) 'OBTENER TODOS LOS CityBE (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCityPorId(ByVal codigo As String) As List(Of CityBE) 'OBTENER TODOS LOS CityBE POR CODIGO (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCityData() As DataTable 'OBTENER TODOS LOS CityBE (TIPO DATATABLE)
    Function ObtenerCityPorIdData(ByVal codigo As String) As DataTable 'OBTENER TODOS LOS CityBE POR CODIGO (TIPO DATATABLE)
#End Region
End Interface
