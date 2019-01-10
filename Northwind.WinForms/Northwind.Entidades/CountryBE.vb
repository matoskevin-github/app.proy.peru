Public Class CountryBE
    Private _CountryId As String
    Private _CountryValue As String

    Public Sub New()
        _CountryId = String.Empty
        _CountryValue = String.Empty
    End Sub

    Public Property CountryId() As String
        Get
            Return _CountryId
        End Get
        Set(ByVal value As String)
            _CountryId = value
        End Set
    End Property

    Public Property CountryValue() As String
        Get
            Return _CountryValue
        End Get
        Set(ByVal value As String)
            _CountryValue = value
        End Set
    End Property

End Class
