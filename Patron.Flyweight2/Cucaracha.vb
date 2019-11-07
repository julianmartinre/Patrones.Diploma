Public Class Cucaracha
    Inherits Especie
    Public Overrides Function ObtenerColor() As String
        Return Me.color
    End Function

    Public Overrides Function ObtenerPatas() As Integer
        Return Me.patas
    End Function
End Class
