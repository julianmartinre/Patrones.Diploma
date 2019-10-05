Public Class Compra
    Private _importe As Decimal
    Public Property importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property
End Class
