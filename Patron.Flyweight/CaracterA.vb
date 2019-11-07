Public Class CaracterA
    Inherits FlyweightCaracter
    Public Sub New()
        simbolo = "A"
    End Sub
    Public Overrides Sub Mostrar(t As Integer)
        tamanio = t
    End Sub
End Class
