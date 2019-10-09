Public Class Sesion
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _idioma As Idioma
    Public Property Idioma() As Idioma
        Get
            Return _idioma
        End Get
        Set(ByVal value As Idioma)
            _idioma = value
        End Set
    End Property
End Class
