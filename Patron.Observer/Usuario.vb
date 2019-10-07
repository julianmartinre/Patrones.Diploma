Imports Patron.Observer

Public Class Usuario
    Implements ICanalObserver
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Sub Actualizar(unCanal As Canal) Implements ICanalObserver.Actualizar
        MsgBox("Nuevo video de: " & unCanal.Nombre)
    End Sub
End Class
