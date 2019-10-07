Public Class PizzaLightBuilder

    Inherits PizzaBuilder
    Sub New()
        oPizza = New Pizza
    End Sub

    Public Overrides Sub construirAgregado()
        oPizza.Agregado.Nombre = "Agregado light."
    End Sub

    Public Overrides Sub construirSalsa()
        oPizza.Salsa.Nombre = "Salsa light."
    End Sub

    Public Overrides Sub construirMasa()
        oPizza.Masa.Nombre = "Masa re light."
    End Sub
End Class
