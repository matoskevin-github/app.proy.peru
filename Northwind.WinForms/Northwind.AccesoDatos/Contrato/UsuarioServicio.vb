Imports Northwind.Entidades

Public Interface UsuarioServicio
#Region "INTERFACE QUE CONTIENE LOS METODOS DE UsuarioBE."
    Function ObtenerUsuario() As List(Of UsuarioBE) 'OBTENER TODOS LOS UsuarioBE (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerUsuarioPorId(ByVal codigo As String) As List(Of UsuarioBE) 'OBTENER TODOS LOS UsuarioBE POR CODIGO (LISTA GENERICA O TIPO ENTIDAD)
    Function ObtenerUsuarioData() As DataTable 'OBTENER TODOS LOS UsuarioBE (TIPO DATATABLE)
    Function ObtenerUsuariorPorIdData(ByVal codigo As String) As DataTable 'OBTENER TODOS LOS UsuarioBE POR CODIGO (TIPO DATATABLE)
    Function GuardarUsuario(ByVal customerBE As UsuarioBE) As RespuestaBE 'GUARDAR UsuarioBE
    Function ActualizarUsuario(ByVal customerBE As UsuarioBE) As RespuestaBE 'ACTUALIZAR UsuarioBE
    Function EliminarUsuario(ByVal customerBE As UsuarioBE) As RespuestaBE 'ELIMINAR UsuarioBE
    Function AccesoUsuario(ByVal customerBE As UsuarioBE) As Boolean  'Acceso al Sistema UsuarioBE
    Function ObtenerInfoUsuario(ByVal customerBE As UsuarioBE) As UsuarioBE  'Obtener la entidad UsuarioBE cargada
#End Region

End Interface
