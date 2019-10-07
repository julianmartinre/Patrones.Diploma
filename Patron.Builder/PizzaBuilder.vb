Public MustInherit Class PizzaBuilder
    Protected oPizza As Pizza
    MustOverride Sub construirMasa()
    MustOverride Sub construirSalsa()
    MustOverride Sub construirAgregado()

    Function obtenerPizza() As Pizza
        Return oPizza
    End Function
End Class
