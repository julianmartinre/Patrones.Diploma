Public Class Proxy
    Inherits Sujeto
    Private _sujetoConcreto As SujetoConcreto
    Public Property sujetoContreto() As SujetoConcreto
        Get
            Return _sujetoConcreto
        End Get
        Set(ByVal value As SujetoConcreto)
            _sujetoConcreto = value
        End Set
    End Property
    Public Overrides Sub Request()
        If sujetoContreto Is Nothing Then
            sujetoContreto = New SujetoConcreto
        End If
        sujetoContreto.Request()
    End Sub
End Class
