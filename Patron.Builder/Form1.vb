Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pizzeria As New Pizzeria
        Dim builder As New PizzaItalianaBuilder
        pizzeria.SetBuiler(builder)
        pizzeria.CrearPizza()
        Dim pizza As New Pizza
        pizza = pizzeria.ObtenerPizza()
    End Sub
End Class
