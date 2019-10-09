Public Class Traduccion
    Private _palabraTraducida As String
    Public Property PalabraTraducida() As String
        Get
            Return _palabraTraducida
        End Get
        Set(ByVal value As String)
            _palabraTraducida = value
        End Set
    End Property
    Private _palabraOriginal As Palabra
    Public Property PalabraOriginal() As Palabra
        Get
            Return _palabraOriginal
        End Get
        Set(ByVal value As Palabra)
            _palabraOriginal = value
        End Set
    End Property
End Class
