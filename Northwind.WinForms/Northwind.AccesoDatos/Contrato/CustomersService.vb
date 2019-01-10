Imports Northwind.Entidades

Public Interface CustomersService

#Region "INTERFACE QUE CONTIENE LOS METODOS DE CustomersBE."
    Function ObtenerCustomer() As List(Of CustomersBE) 'OBTENER TODOS LOS CustomersBE (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCustomerPorId(ByVal codigo As String) As List(Of CustomersBE) 'OBTENER TODOS LOS CustomersBE POR CODIGO (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerCustomerData() As DataTable 'OBTENER TODOS LOS CustomersBE (TIPO DATATABLE)
    Function ObtenerCustomerPorIdData(ByVal codigo As String) As DataTable 'OBTENER TODOS LOS CustomersBE POR CODIGO (TIPO DATATABLE)
    Function GuardarCustomer(ByVal customerBE As CustomersBE) As RespuestaBE 'GUARDAR CustomersBE
    Function ActualizarCustomer(ByVal customerBE As CustomersBE) As RespuestaBE 'ACTUALIZAR CustomersBE
    Function EliminarCustomer(ByVal customerBE As CustomersBE) As RespuestaBE 'ELIMINAR CustomersBE
#End Region

End Interface

