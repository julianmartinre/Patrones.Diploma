Public Class MateriaMatematica
    Inherits MateriaFlyweight
    Public Overrides Function ObtenerNombre() As String
        Me.nombre = "Matematica"
        Return Me.nombre
    End Function
End Class
