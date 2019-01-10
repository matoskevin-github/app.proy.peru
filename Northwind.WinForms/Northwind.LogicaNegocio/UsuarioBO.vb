Imports Northwind.AccesoDatos
Imports Northwind.Entidades

Public Class UsuarioBO
    Private _UsuarioDAO As UsuarioDAO

    Public Sub New()
        _UsuarioDAO = New UsuarioDAO
    End Sub

    Public Function AccesoUsuario(customerBE As UsuarioBE) As Boolean
        Return _UsuarioDAO.AccesoUsuario(customerBE)
    End Function

    Public Function ActualizarUsuario(customerBE As UsuarioBE) As RespuestaBE
        Return _UsuarioDAO.ActualizarUsuario(customerBE)
    End Function

    Public Function EliminarUsuario(customerBE As UsuarioBE) As RespuestaBE
        Return _UsuarioDAO.EliminarUsuario(customerBE)
    End Function

    Public Function GuardarUsuario(customerBE As UsuarioBE) As RespuestaBE
        Return _UsuarioDAO.GuardarUsuario(customerBE)
    End Function

    Public Function ObtenerInfoUsuario(customerBE As UsuarioBE) As UsuarioBE
        Return _UsuarioDAO.ObtenerInfoUsuario(customerBE)
    End Function

    Public Function ObtenerUsuario() As List(Of UsuarioBE)
        Return _UsuarioDAO.ObtenerUsuario()
    End Function

    Public Function ObtenerUsuarioData() As DataTable
        Return _UsuarioDAO.ObtenerUsuarioData()
    End Function

    Public Function ObtenerUsuarioPorId(codigo As String) As List(Of UsuarioBE)
        Return _UsuarioDAO.ObtenerUsuarioPorId(codigo)
    End Function

    Public Function ObtenerUsuariorPorIdData(codigo As String) As DataTable
        Return _UsuarioDAO.ObtenerUsuariorPorIdData(codigo)
    End Function
End Class
