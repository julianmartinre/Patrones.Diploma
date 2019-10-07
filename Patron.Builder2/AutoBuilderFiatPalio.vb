Public Class AutoBuilderFiatPalio
    Inherits AutoBuilder
    Sub New()
        oAutoBuilder = New Auto
    End Sub
    Public Overrides Sub BuildMarca()
        oAutoBuilder.Marca = "FIAT"
    End Sub

    Public Overrides Sub BuildModelo()
        oAutoBuilder.Modelo = "PALIO"
    End Sub

    Public Overrides Sub BuildMotor()
        oAutoBuilder.Motor = "1.3"
    End Sub

    Public Overrides Sub BuildPuertas()
        oAutoBuilder.CantidadPuertas = 5
    End Sub
End Class
