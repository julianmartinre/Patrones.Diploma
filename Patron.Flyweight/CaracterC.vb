Public Class CaracterC
    Inherits FlyweightCaracter
    Public Sub New()
        simbolo = "C"
    End Sub
    Public Overrides Sub Mostrar(t As Integer)
        tamanio = t
    End Sub
End Class
