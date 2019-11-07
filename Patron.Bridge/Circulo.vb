Imports Patron.Bridge

Public Class Circulo
    Inherits Figura
    Public Sub New(c As IColor)
        MyBase.New(c)
    End Sub
    Public Overrides Sub AplicarColor()
        Console.WriteLine("Dibujando un circulo")
        MyBase.AplicarColor()
    End Sub
End Class
