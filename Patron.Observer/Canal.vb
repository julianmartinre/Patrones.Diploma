Public Class Canal
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _listaVideos As New List(Of Video)
    Public Property ListaVideos() As List(Of Video)
        Get
            Return _listaVideos
        End Get
        Set(ByVal value As List(Of Video))
            _listaVideos = value
        End Set
    End Property

    Public Sub AgregarVideo(video As Video)
        Notificar()
        _listaVideos.Add(video)
    End Sub

    Private _lista As New List(Of ICanalObserver)

    Sub AgregarCanalObserver(c As ICanalObserver)
        _lista.Add(c)
    End Sub

    Sub QuitarCanalObserver(c As ICanalObserver)
        _lista.Remove(c)
    End Sub

    Public Sub Notificar()
        For Each item In _lista
            item.Actualizar(Me)
        Next
    End Sub
End Class
