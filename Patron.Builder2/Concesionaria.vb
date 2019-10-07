Public Class Concesionaria
    Private oAutoBuilder As AutoBuilder

    Public Sub SetBuilder(b As AutoBuilder)
        oAutoBuilder = b
    End Sub

    Public Sub CrearAuto()
        oAutoBuilder.BuildMarca()
        oAutoBuilder.BuildModelo()
        oAutoBuilder.BuildMotor()
        oAutoBuilder.BuildPuertas()
    End Sub

    Public Function ObtenerAuto() As Auto
        Return oAutoBuilder.ObtenerAuto()
    End Function
End Class
