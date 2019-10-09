Imports Patron.Observer3

Public Class Sesion
    Implements IIdioma
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _idioma As Idioma
    Public Property Idioma() As Idioma
        Get
            Return _idioma
        End Get
        Set(ByVal value As Idioma)
            _idioma = value
            Actualizar(Idioma)
        End Set
    End Property

    Private list As New List(Of IIdioma)

    Public Sub Actualizar(i As Idioma) Implements IIdioma.Actualizar
        MsgBox("Se cambió el idioma.")
    End Sub

End Class
