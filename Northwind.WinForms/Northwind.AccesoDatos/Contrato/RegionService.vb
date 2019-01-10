Imports Northwind.Entidades

Public Interface RegionService
#Region "INTERFACE QUE CONTIENE LOS METODOS DE RegionBE."
    Function ObtenerRegion() As List(Of RegionBE) 'OBTENER TODOS LOS RegionBE (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerRegionPorId(ByVal codigo As String) As List(Of RegionBE) 'OBTENER TODOS LOS RegionBE POR CODIGO (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerRegionData() As DataTable 'OBTENER TODOS LOS RegionBE (TIPO DATATABLE)
    Function ObtenerRegionPorIdData(ByVal codigo As String) As DataTable 'OBTENER TODOS LOS RegionBE POR CODIGO (TIPO DATATABLE)
#End Region
End Interface
