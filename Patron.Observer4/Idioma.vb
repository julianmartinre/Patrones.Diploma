Imports Patron.Observer4

Public Class Idioma
    Implements IObservable
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            NotificarObservador(Me)
        End Set
    End Property
    Private _listaTraducciones As New List(Of Traduccion)
    Public Property ListaTraducciones() As List(Of Traduccion)
        Get
            Return _listaTraducciones
        End Get
        Set(ByVal value As List(Of Traduccion))
            _listaTraducciones = value
        End Set
    End Property

    Public Sub AgregarTraduccion(t As Traduccion)
        _listaTraducciones.Add(t)
    End Sub

    Public Sub QuitarTraduccion(t As Traduccion)
        _listaTraducciones.Remove(t)
    End Sub

    Private _lista As New List(Of IObserver)

    Public Sub AgregarObservador(o As IObserver) Implements IObservable.AgregarObservador
        _lista.Add(o)
    End Sub

    Public Sub QuitarObservador(o As IObserver) Implements IObservable.QuitarObservador
        _lista.Remove(o)
    End Sub

    Public Sub NotificarObservador(o As Idioma) Implements IObservable.NotificarObservador
        For Each item In _lista
            item.Actualizar(o)
        Next
    End Sub
End Class
