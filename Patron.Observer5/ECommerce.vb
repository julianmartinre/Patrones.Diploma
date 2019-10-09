Imports Patron.Observer5

Public Class ECommerce
    Implements IObservable
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _promociones As New List(Of Promocion)
    Public Property Promociones() As List(Of Promocion)
        Get
            Return _promociones
        End Get
        Set(ByVal value As List(Of Promocion))
            _promociones = value
        End Set
    End Property

    Public Sub AgregarPromocion(p As Promocion)
        _promociones.Add(p)
        NotificarObserver(Me)
    End Sub

    Public Sub QuitarPromocion(p As Promocion)
        _promociones.Remove(p)
    End Sub

    Private _listaObserver As New List(Of IObserver)

    Public Sub AgregarObservador(o As IObserver) Implements IObservable.AgregarObservador
        _listaObserver.Add(o)
    End Sub

    Public Sub QuitarObservador(o As IObserver) Implements IObservable.QuitarObservador
        _listaObserver.Remove(o)
    End Sub

    Public Sub NotificarObserver(e As ECommerce) Implements IObservable.NotificarObserver
        For Each item In _listaObserver
            item.Actualizar(Me)
        Next
    End Sub
End Class
