Public Class RegionBE
    Private _RegionId As String
    Private _RegionValue As String

    Public Sub New()
        _RegionId = String.Empty
        _RegionValue = String.Empty
    End Sub

    Public Property RegionId() As String
        Get
            Return _RegionId
        End Get
        Set(ByVal value As String)
            _RegionId = value
        End Set
    End Property

    Public Property RegionValue() As String
        Get
            Return _RegionValue
        End Get
        Set(ByVal value As String)
            _RegionValue = value
        End Set
    End Property
End Class
