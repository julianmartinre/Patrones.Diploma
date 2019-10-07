Public Class Pizzeria
    Private oPizzaBuilder As PizzaBuilder

    Public Sub SetBuiler(b As PizzaBuilder)
        oPizzaBuilder = b
    End Sub

    Public Sub CrearPizza()
        oPizzaBuilder.construirMasa()
        oPizzaBuilder.construirSalsa()
        oPizzaBuilder.construirAgregado()
    End Sub

    Public Function ObtenerPizza() As Pizza
        Return oPizzaBuilder.obtenerPizza()
    End Function
End Class
