Public Class CityBE
    Private _CityId As String
    Private _CityValue As String

    Public Sub New()
        _CityId = String.Empty
        _CityValue = String.Empty
    End Sub
    Public Property CityId() As String
        Get
            Return _CityId
        End Get
        Set(ByVal value As String)
            _CityId = value
        End Set
    End Property

    Public Property CityValue() As String
        Get
            Return _CityValue
        End Get
        Set(ByVal value As String)
            _CityValue = value
        End Set
    End Property

End Class
