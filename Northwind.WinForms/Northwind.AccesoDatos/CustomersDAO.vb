Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class CustomersDAO : Implements CustomersService

    Public Function ActualizarCustomer(customerBE As CustomersBE) As RespuestaBE Implements CustomersService.ActualizarCustomer

    End Function

    Public Function EliminarCustomer(customerBE As CustomersBE) As RespuestaBE Implements CustomersService.EliminarCustomer

    End Function

    Public Function GuardarCustomer(customerBE As CustomersBE) As RespuestaBE Implements CustomersService.GuardarCustomer

    End Function

    Public Function ObtenerCustomer() As List(Of CustomersBE) Implements CustomersService.ObtenerCustomer

    End Function

    Public Function ObtenerCustomerData() As DataTable Implements CustomersService.ObtenerCustomerData

    End Function

    Public Function ObtenerCustomerPorId(codigo As String) As List(Of CustomersBE) Implements CustomersService.ObtenerCustomerPorId

    End Function

    Public Function ObtenerCustomerPorIdData(codigo As String) As DataTable Implements CustomersService.ObtenerCustomerPorIdData

    End Function
End Class
