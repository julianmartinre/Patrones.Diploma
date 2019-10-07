Public Class PizzaItalianaBuilder
    Inherits PizzaBuilder
    Sub New()
        oPizza = New Pizza
    End Sub

    Public Overrides Sub construirAgregado()
        oPizza.Agregado.Nombre = "Agregado italiano."
    End Sub

    Public Overrides Sub construirSalsa()
        oPizza.Salsa.Nombre = "Salsa italiana."
    End Sub

    Public Overrides Sub construirMasa()
        oPizza.Masa.Nombre = "Masa re italiana."
    End Sub
End Class
