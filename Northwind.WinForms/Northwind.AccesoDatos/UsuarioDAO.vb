Imports Northwind.Entidades

Public Class UsuarioDAO : Implements UsuarioServicio

    Public Function AccesoUsuario(customerBE As UsuarioBE) As Boolean Implements UsuarioServicio.AccesoUsuario

    End Function

    Public Function ActualizarUsuario(customerBE As UsuarioBE) As RespuestaBE Implements UsuarioServicio.ActualizarUsuario

    End Function

    Public Function EliminarUsuario(customerBE As UsuarioBE) As RespuestaBE Implements UsuarioServicio.EliminarUsuario

    End Function

    Public Function GuardarUsuario(customerBE As UsuarioBE) As RespuestaBE Implements UsuarioServicio.GuardarUsuario

    End Function

    Public Function ObtenerInfoUsuario(customerBE As UsuarioBE) As UsuarioBE Implements UsuarioServicio.ObtenerInfoUsuario

    End Function

    Public Function ObtenerUsuario() As List(Of UsuarioBE) Implements UsuarioServicio.ObtenerUsuario

    End Function

    Public Function ObtenerUsuarioData() As DataTable Implements UsuarioServicio.ObtenerUsuarioData

    End Function

    Public Function ObtenerUsuarioPorId(codigo As String) As List(Of UsuarioBE) Implements UsuarioServicio.ObtenerUsuarioPorId

    End Function

    Public Function ObtenerUsuariorPorIdData(codigo As String) As DataTable Implements UsuarioServicio.ObtenerUsuariorPorIdData

    End Function
End Class
