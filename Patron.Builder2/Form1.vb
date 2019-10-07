Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim concesionaria As New Concesionaria
        Dim builder As New AutoBuilderFiatPalio
        concesionaria.SetBuilder(builder)
        concesionaria.CrearAuto()
        Dim unAuto As New Auto
        unAuto = concesionaria.ObtenerAuto()
    End Sub
End Class
