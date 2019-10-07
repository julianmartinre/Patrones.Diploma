Public Class Divisa
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _precioCompra As Decimal
    Public Property PrecioCompra() As Decimal
        Get
            Return _precioCompra
        End Get
        Set(ByVal value As Decimal)
            _precioCompra = value
        End Set
    End Property

    Sub SetPrecioCompra(p As Decimal)
        _precioCompra = p
        Notificar()
    End Sub

    Private _list As New List(Of IDivisaObserver)
    Sub AgregarDivisaObserver(d As IDivisaObserver)
        _list.Add(d)
    End Sub

    Sub QuitarDivisaObserver(d As IDivisaObserver)
        _list.Remove(d)
    End Sub

    Sub Notificar()
        For Each item In _list
            item.actualizar(Me)
        Next
    End Sub
End Class
