Public Class RespuestaBE
    Private _Respuesta As Integer
    Private _Mensaje As String

    Public Sub New()
        _Respuesta = 0
        _Mensaje = String.Empty
    End Sub

    Public Property Respuesta() As Integer
        Get
            Return _Respuesta
        End Get
        Set(ByVal value As Integer)
            _Respuesta = value
        End Set
    End Property

    Public Property Mensaje() As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property

End Class
