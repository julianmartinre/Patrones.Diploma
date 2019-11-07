Public MustInherit Class Especie
    Private _patas As Integer
    Public Property patas() As Integer
        Get
            Return _patas
        End Get
        Set(ByVal value As Integer)
            _patas = value
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
    Public MustOverride Function ObtenerColor() As String
    Public MustOverride Function ObtenerPatas() As Integer

End Class
