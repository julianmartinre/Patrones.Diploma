Public Class Noticia
    Private _contenido As String
    Public Property contenido() As String
        Get
            Return _contenido
        End Get
        Set(ByVal value As String)
            _contenido = value
        End Set
    End Property
End Class
