Public MustInherit Class PelotaFlyweight
    Private _radio As Integer
    Public Property radio() As Integer
        Get
            Return _radio
        End Get
        Set(ByVal value As Integer)
            _radio = value
        End Set
    End Property
    Private _color As String
    Public Property color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property
    Private _x As Integer
    Public Property x() As Integer
        Get
            Return _x
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property
    Private _y As Integer
    Public Property y() As Integer
        Get
            Return _y
        End Get
        Set(ByVal value As Integer)
            _y = value
        End Set
    End Property
End Class
