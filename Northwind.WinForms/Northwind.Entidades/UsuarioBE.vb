Public Class UsuarioBE
    Private _Nombres As String
    Private _Apellidos As String
    Private _Dni As String
    Private _Usuario As String
    Private _Password As String
    Private _Sexo As String
    Private _Celular As String
    Private _Telefono As String

    Public Sub New()
        _Nombres = String.Empty
        _Apellidos = String.Empty
        _Dni = String.Empty
        _Usuario = String.Empty
        _Password = String.Empty
        _Sexo = String.Empty
        _Celular = String.Empty
        _Telefono = String.Empty
    End Sub

    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Dni() As String
        Get
            Return _Dni
        End Get
        Set(ByVal value As String)
            _Dni = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return _Celular
        End Get
        Set(ByVal value As String)
            _Celular = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
End Class
