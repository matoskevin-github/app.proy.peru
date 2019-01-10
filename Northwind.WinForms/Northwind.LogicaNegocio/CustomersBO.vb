Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class CustomersBO
    Private _CustomersDAO As CustomersDAO

    Public Sub New()
        _CustomersDAO = New CustomersDAO
    End Sub
    Public Function ActualizarCustomer(customerBE As CustomersBE) As RespuestaBE
        Return _CustomersDAO.ActualizarCustomer(customerBE)
    End Function

    Public Function EliminarCustomer(customerBE As CustomersBE) As RespuestaBE
        Return _CustomersDAO.EliminarCustomer(customerBE)
    End Function

    Public Function GuardarCustomer(customerBE As CustomersBE) As RespuestaBE
        Return _CustomersDAO.GuardarCustomer(customerBE)
    End Function

    Public Function ObtenerCustomer() As List(Of CustomersBE)
        Return _CustomersDAO.ObtenerCustomer
    End Function

    Public Function ObtenerCustomerData() As DataTable
        Return _CustomersDAO.ObtenerCustomerData
    End Function

    Public Function ObtenerCustomerPorId(codigo As String) As List(Of CustomersBE)
        Return _CustomersDAO.ObtenerCustomerPorId(codigo)
    End Function

    Public Function ObtenerCustomerPorIdData(codigo As String) As DataTable
        Return _CustomersDAO.ObtenerCustomerPorIdData(codigo)
    End Function

End Class
