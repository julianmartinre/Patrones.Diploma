Public Class Proxy
    Inherits Asunto
    Private _asuntoReal As AsuntoReal
    Public Property asuntoReal() As AsuntoReal
        Get
            Return _asuntoReal
        End Get
        Set(ByVal value As AsuntoReal)
            _asuntoReal = value
        End Set
    End Property
    Public Overrides Sub Request()
        If asuntoReal Is Nothing Then
            asuntoReal = New AsuntoReal
        End If
        asuntoReal.Request()
    End Sub
End Class
