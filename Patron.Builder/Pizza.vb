Public Class Pizza
    Private _masa As New Masa
    Public Property Masa() As Masa
        Get
            Return _masa
        End Get
        Set(ByVal value As Masa)
            _masa = value
        End Set
    End Property
    Private _salsa As New Salsa
    Public Property Salsa() As Salsa
        Get
            Return _salsa
        End Get
        Set(ByVal value As Salsa)
            _salsa = value
        End Set
    End Property
    Private _agregado As New Agregado
    Public Property Agregado() As Agregado
        Get
            Return _agregado
        End Get
        Set(ByVal value As Agregado)
            _agregado = value
        End Set
    End Property
End Class
