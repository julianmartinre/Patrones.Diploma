Public Class AutoBuilderFiatSiena
    Inherits AutoBuilder
    Sub New()
        oAutoBuilder = New Auto
    End Sub
    Public Overrides Sub BuildMarca()
        oAutoBuilder.Marca = "FIAT"
    End Sub

    Public Overrides Sub BuildModelo()
        oAutoBuilder.Modelo = "SIENA"
    End Sub

    Public Overrides Sub BuildMotor()
        oAutoBuilder.Motor = "1.6"
    End Sub

    Public Overrides Sub BuildPuertas()
        oAutoBuilder.CantidadPuertas = 5
    End Sub
End Class
