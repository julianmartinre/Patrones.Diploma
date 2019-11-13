Public Class Mueble
    Sub New(m As IMaterial)
        material = m
    End Sub
    Private _material As IMaterial
    Public Property material() As IMaterial
        Get
            Return _material
        End Get
        Set(ByVal value As IMaterial)
            _material = value
        End Set
    End Property
    Public Overridable Sub SetearMaterial()
        material.setearMaterial()
    End Sub
End Class
