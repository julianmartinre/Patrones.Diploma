Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim material As IMaterial
        material = New Pino
        Dim mueble As Mueble = New Silla(material)
        mueble.SetearMaterial()
    End Sub
End Class
