Public Class AutoBuilderFordFiesta
    Inherits AutoBuilder
    Sub New()
        oAutoBuilder = New Auto
    End Sub
    Public Overrides Sub BuildMarca()
        oAutoBuilder.Marca = "FORD"
    End Sub

    Public Overrides Sub BuildModelo()
        oAutoBuilder.Modelo = "FIESTA"
    End Sub

    Public Overrides Sub BuildMotor()
        oAutoBuilder.Motor = "1.6"
    End Sub

    Public Overrides Sub BuildPuertas()
        oAutoBuilder.CantidadPuertas = 5
    End Sub
End Class
