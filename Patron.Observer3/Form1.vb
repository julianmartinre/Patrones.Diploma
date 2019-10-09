Public Class Form1
    Dim unIdioma As Idioma
    Dim otroIdioma As Idioma
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instancio un idioma.
        unIdioma = New Idioma With {.Nombre = "Inglés"}

        'Instancio dos palabras base.
        Dim palabra1 As New Palabra With {.Texto = "Hola"}
        Dim palabra2 As New Palabra With {.Texto = "Chau"}

        'Instancio las traducciones pertinentes.
        Dim traduccion1 As New Traduccion With {.PalabraTraducida = "Hello", .PalabraOriginal = palabra1}
        Dim traduccion2 As New Traduccion With {.PalabraTraducida = "Bye", .PalabraOriginal = palabra2}

        'Agrego las traducciones a mi idioma.
        unIdioma.AgregarTraduccion(traduccion1)
        unIdioma.AgregarTraduccion(traduccion2)

        'Instancio la sesión y asigno idioma.
        Dim unaSesion As New Sesion
        unaSesion.Idioma = unIdioma

        'Instancio otro idioma.
        otroIdioma = New Idioma With {.Nombre = "Español"}

        'Asigno otro idioma.
        unaSesion.Idioma.Nombre = "TEST"
    End Sub
End Class
