Public Class Idioma
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Notificar()
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

    Private List As New List(Of IIdioma)

    Public Sub AgregarObservador(i As IIdioma)
        List.Add(i)
    End Sub

    Public Sub QuitarObservador(i As IIdioma)
        List.Remove(i)
    End Sub

    Public Sub Notificar()
        For Each item In List
            item.Actualizar(Me)
        Next
    End Sub

End Class
