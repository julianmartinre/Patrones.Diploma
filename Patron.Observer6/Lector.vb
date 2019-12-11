Imports Patron.Observer6

Public Class Lector
    Implements IDiarioObserver
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Sub Actualizar(d As Diario) Implements IDiarioObserver.Actualizar
        MsgBox("El diario " & d.nombre & " tiene una noticia nueva.")
    End Sub
End Class
