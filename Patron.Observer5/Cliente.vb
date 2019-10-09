Imports Patron.Observer5

Public Class Cliente
    Implements IObserver
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Sub Actualizar(p As ECommerce) Implements IObserver.Actualizar
        MsgBox("Se agregaron nuevas promociones.")
    End Sub
End Class
