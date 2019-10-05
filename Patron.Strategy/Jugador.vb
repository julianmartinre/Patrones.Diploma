Public Class Jugador

    Private _disparo As EstrategiaDisparo
    Public Property disparo() As EstrategiaDisparo
        Get
            Return _disparo
        End Get
        Set(ByVal value As EstrategiaDisparo)
            _disparo = value
        End Set
    End Property

    Function disparar(estrategia As EstrategiaDisparo)
        Me.disparo = estrategia
    End Function

End Class
