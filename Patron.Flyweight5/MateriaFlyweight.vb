Public MustInherit Class MateriaFlyweight
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    MustOverride Function ObtenerNombre() As String
End Class
