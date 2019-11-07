Public Class Cuadrado
    Inherits Figura
    Public Sub New(c As IColor)
        MyBase.New(c)
    End Sub
    Public Overrides Sub AplicarColor()
        Console.WriteLine("Dibujando un cuadrado")
        MyBase.AplicarColor()
    End Sub
End Class
