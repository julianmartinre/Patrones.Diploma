Public Class Producto
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _cantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Sub RestarStock(c As Integer)
        Cantidad = Cantidad - c
    End Sub

    Sub AgregarStock(c As Integer)
        Cantidad = Cantidad + c
    End Sub
End Class
