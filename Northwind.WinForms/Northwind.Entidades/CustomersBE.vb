Public Class CustomersBE

    Private _CustomerID As String
    Private _CompanyName As String
    Private _ContactName As String
    Private _ContactTitle As String
    Private _Address As String
    Private _City As String
    Private _Region As String
    Private _PostalCode As String
    Private _Country As String
    Private _Phone As String
    Private _Fax As String

    Public Sub New()
        _CustomerID = String.Empty
        _CompanyName = String.Empty
        _ContactName = String.Empty
        _ContactTitle = String.Empty
        _Address = String.Empty
        _City = String.Empty
        _Region = String.Empty
        _PostalCode = String.Empty
        _Country = String.Empty
        _Phone = String.Empty
        _Fax = String.Empty
    End Sub

    Public Property CustomerID() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
        End Set
    End Property

    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return _ContactName
        End Get
        Set(ByVal value As String)
            _ContactName = value
        End Set
    End Property

    Public Property ContactTitle() As String
        Get
            Return _ContactTitle
        End Get
        Set(ByVal value As String)
            _ContactTitle = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property
    Public Property Region() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property
    Public Property PostalCode() As String
        Get
            Return _PostalCode
        End Get
        Set(ByVal value As String)
            _PostalCode = value
        End Set
    End Property
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return _Fax
        End Get
        Set(ByVal value As String)
            _Fax = value
        End Set
    End Property

End Class
