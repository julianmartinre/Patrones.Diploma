Public Class Video
    Private _numeroVideo As Integer
    Public Property NumeroVideo() As Integer
        Get
            Return _numeroVideo
        End Get
        Set(ByVal value As Integer)
            _numeroVideo = value
        End Set
    End Property
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
End Class
