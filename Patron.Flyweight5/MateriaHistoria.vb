Public Class MateriaHistoria
    Inherits MateriaFlyweight
    Public Overrides Function ObtenerNombre() As String
        Me.nombre = "Historia"
        Return Me.nombre
    End Function
End Class
