Public MustInherit Class PizzaBuilder
    MustOverride Sub contruirMasa()
    MustOverride Sub construirSalsa()
    MustOverride Sub construirAgregado()

    Function obtenerPizza() As Pizza

    End Function
End Class
