Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fabrica As New FabricaRemeras
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("AZUL")
        fabrica.ObtenerRemera("VERDE")
        fabrica.ObtenerRemera("ROJA")
        MsgBox(fabrica.ObtenerCantidadRemeras())
    End Sub
End Class
