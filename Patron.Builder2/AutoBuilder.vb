Public MustInherit Class AutoBuilder

    Protected oAutoBuilder As Auto

    Function ObtenerAuto() As Auto
        Return oAutoBuilder
    End Function

    MustOverride Sub BuildMotor()
    MustOverride Sub BuildMarca()
    MustOverride Sub BuildModelo()
    MustOverride Sub BuildPuertas()

End Class
