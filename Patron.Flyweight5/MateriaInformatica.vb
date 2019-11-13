Public Class MateriaInformatica
    Inherits MateriaFlyweight
    Public Overrides Function ObtenerNombre() As String
        Me.nombre = "Informatica"
        Return Me.nombre
    End Function
End Class
