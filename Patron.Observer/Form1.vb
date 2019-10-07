Public Class Form1

    Dim unUsuario As Usuario
    Dim unCanal As Canal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Instancio un usuario
        unUsuario = New Usuario With {.Nombre = "Julian"}

        'Instancio un canal
        unCanal = New Canal With {.Nombre = "Programación ATR"}

        'Instancio videos
        Dim unVideo1 As New Video With {.NumeroVideo = 1, .Nombre = "0 - Primeros pasos.", .Descripcion = "Primeros pasos en el mundo de la programación."}
        Dim unVideo2 As New Video With {.NumeroVideo = 2, .Nombre = "1 - Variables.", .Descripcion = "Definición de variables."}
        Dim unVideo3 As New Video With {.NumeroVideo = 3, .Nombre = "2 - Condicionales.", .Descripcion = "Uso del condicional."}
        Dim unVideo4 As New Video With {.NumeroVideo = 4, .Nombre = "3 - Ciclos.", .Descripcion = "Estructura y uso de ciclos."}

        'Agrego los videos al canal
        unCanal.AgregarVideo(unVideo1)
        unCanal.AgregarVideo(unVideo2)
        unCanal.AgregarVideo(unVideo3)
        unCanal.AgregarVideo(unVideo4)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unCanal.AgregarCanalObserver(unUsuario)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim unVideo As New Video With {.NumeroVideo = 5, .Nombre = "5 - Test", .Descripcion = "Video test."}
        unCanal.AgregarVideo(unVideo)
    End Sub
End Class
