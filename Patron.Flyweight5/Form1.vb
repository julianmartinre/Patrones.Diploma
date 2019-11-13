Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim factory As New FactoryMateria
        Dim m As MateriaFlyweight = factory.obtenerMateria("Informatica")
        MsgBox(m.ObtenerNombre())
    End Sub
End Class
