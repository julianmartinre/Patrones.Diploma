Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As IColor = New Rojo
        Dim figura As Figura = New Cuadrado(c)
        figura.AplicarColor()
    End Sub
End Class
