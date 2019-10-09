Imports Patron.StateObserver

Public Class Tramite
    Implements IObservable
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _estado As Estado
    Public Property Estado() As Estado
        Get
            Return _estado
        End Get
        Set(ByVal value As Estado)
            _estado = value
            Notificar(Me)
        End Set
    End Property

    Private _observadores As New List(Of IObserver)

    Public Sub AgregarObservador(o As IObserver) Implements IObservable.AgregarObservador
        _observadores.Add(o)
    End Sub

    Public Sub QuitarObservador(o As IObserver) Implements IObservable.QuitarObservador
        _observadores.Remove(o)
    End Sub

    Public Sub Notificar(o As Tramite) Implements IObservable.Notificar
        For Each item In _observadores
            item.Actualizar(o)
        Next
    End Sub
End Class
