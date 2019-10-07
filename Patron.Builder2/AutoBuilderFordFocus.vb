Public Class AutoBuilderFordFocus
    Inherits AutoBuilder
    Sub New()
        oAutoBuilder = New Auto
    End Sub
    Public Overrides Sub BuildMarca()
        oAutoBuilder.Marca = "FORD"
    End Sub

    Public Overrides Sub BuildModelo()
        oAutoBuilder.Modelo = "FOCUS"
    End Sub

    Public Overrides Sub BuildMotor()
        oAutoBuilder.Motor = "2.0"
    End Sub

    Public Overrides Sub BuildPuertas()
        oAutoBuilder.CantidadPuertas = 5
    End Sub
End Class
