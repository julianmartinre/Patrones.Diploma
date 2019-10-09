Public Class Traduccion
    Private _traduccion As String
    Public Property Traduccion() As String
        Get
            Return _traduccion
        End Get
        Set(ByVal value As String)
            _traduccion = value
        End Set
    End Property
    Private _palabra As Palabra
    Public Property Palabra() As Palabra
        Get
            Return _palabra
        End Get
        Set(ByVal value As Palabra)
            _palabra = value
        End Set
    End Property
End Class
