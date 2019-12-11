Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l As New Lector With {.nombre = "Julián"}
        Dim d As New Diario With {.nombre = "Clarín"}
        d.AgregarObservador(l)
        Dim n As New Noticia With {.contenido = "Alta nota master."}
        d.AgregarNoticia(n)
    End Sub
End Class