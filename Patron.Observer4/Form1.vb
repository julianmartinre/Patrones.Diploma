Imports Patron.Observer4

Public Class Form1
    Implements IObserver
    Dim unIdioma As Idioma
    Dim otroIdioma As Idioma
    Dim unaSesion As New Sesion
    Public Sub Actualizar(i As Idioma) Implements IObserver.Actualizar
        MsgBox("Se cambió el idioma.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instancio un idioma.
        unIdioma = New Idioma With {.Nombre = "Inglés"}

        'Instancio dos palabras base.
        Dim palabra1 As New Palabra With {.Texto = "Hola"}
        Dim palabra2 As New Palabra With {.Texto = "Chau"}

        'Instancio las traducciones pertinentes.
        Dim traduccion1 As New Traduccion With {.Traduccion = "Hello", .Palabra = palabra1}
        Dim traduccion2 As New Traduccion With {.Traduccion = "Bye", .Palabra = palabra2}

        'Agrego las traducciones a mi idioma.
        unIdioma.AgregarTraduccion(traduccion1)
        unIdioma.AgregarTraduccion(traduccion2)

        'Asigno idioma a sesión.
        unaSesion.Idioma = unIdioma

        'Instancio otro idioma.
        otroIdioma = New Idioma With {.Nombre = "Español"}

        unaSesion.Idioma.AgregarObservador(Me)

        'Asigno otro idioma.
        unaSesion.Idioma.Nombre = "Test"
    End Sub
End Class
