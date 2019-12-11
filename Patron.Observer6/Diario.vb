Imports Patron.Observer6

Public Class Diario
    Implements IObservable

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _noticias As New List(Of Noticia)
    Public Property noticias() As List(Of Noticia)
        Get
            Return _noticias
        End Get
        Set(ByVal value As List(Of Noticia))
            _noticias = value
        End Set
    End Property
    Private _lista As New List(Of IDiarioObserver)
    Public Sub AgregarObservador(o As IDiarioObserver) Implements IObservable.AgregarObservador
        _lista.Add(o)
    End Sub

    Public Sub QuitarObservador(o As IDiarioObserver) Implements IObservable.QuitarObservador
        _lista.Remove(o)
    End Sub

    Public Sub NotificarObserver(e As Diario) Implements IObservable.NotificarObserver
        For Each item In _lista
            item.Actualizar(e)
        Next
    End Sub
    Public Sub AgregarNoticia(n As Noticia)
        NotificarObserver(Me)
        noticias.Add(n)
    End Sub
End Class
