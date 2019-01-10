Imports Northwind.Entidades

Public Interface CountryService
#Region "INTERFACE QUE CONTIENE LOS METODOS DE CountryBE."
    Function ObtenerCountry() As List(Of CountryBE) 'OBTENER TODOS LOS CountryBE (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCountryPorId(ByVal codigo As String) As List(Of CountryBE) 'OBTENER TODOS LOS CountryBE POR CODIGO (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCountryData() As DataTable 'OBTENER TODOS LOS CountryBE (TIPO DATATABLE)
    Function ObtenerCountryPorIdData(ByVal codigo As String) As DataTable 'OBTENER TODOS LOS CountryBE POR CODIGO (TIPO DATATABLE)
#End Region


End Interface
