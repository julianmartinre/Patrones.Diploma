Public Class CaracterB
    Inherits FlyweightCaracter
    Public Sub New()
        simbolo = "B"
    End Sub
    Public Overrides Sub Mostrar(t As Integer)
        tamanio = t
    End Sub
End Class
