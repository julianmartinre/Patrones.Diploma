Public Class Instrumento
    Private _estrategiaSonido As EstrategiaSonido
    Public Property EstrategiaSonido() As EstrategiaSonido
        Get
            Return _estrategiaSonido
        End Get
        Set(ByVal value As EstrategiaSonido)
            _estrategiaSonido = value
        End Set
    End Property

    Public Sub sonarInstrumento(e As EstrategiaSonido)
        Me.EstrategiaSonido = e
    End Sub
End Class
