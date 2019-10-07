Public Class Auto
    Private _motor As String
    Public Property Motor() As String
        Get
            Return _motor
        End Get
        Set(ByVal value As String)
            _motor = value
        End Set
    End Property
    Private _marca As String
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property
    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property
    Private _cantidadPuertas As Integer
    Public Property CantidadPuertas() As Integer
        Get
            Return _cantidadPuertas
        End Get
        Set(ByVal value As Integer)
            _cantidadPuertas = value
        End Set
    End Property
End Class
