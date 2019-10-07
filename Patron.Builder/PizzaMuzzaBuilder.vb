Public Class PizzaMuzzaBuilder
    Inherits PizzaBuilder
    Sub New()
        oPizza = New Pizza
    End Sub

    Public Overrides Sub construirAgregado()
        oPizza.Agregado.Nombre = "Agregado muzza."
    End Sub

    Public Overrides Sub construirSalsa()
        oPizza.Salsa.Nombre = "Salsa muzza."
    End Sub

    Public Overrides Sub construirMasa()
        oPizza.Masa.Nombre = "Masa re muzza."
    End Sub
End Class
