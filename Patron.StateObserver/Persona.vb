Public Class Persona
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _tramites As New List(Of Tramite)
    Public Property Tramites() As List(Of Tramite)
        Get
            Return _tramites
        End Get
        Set(ByVal value As List(Of Tramite))
            _tramites = value
        End Set
    End Property

    Public Sub AgregarTramite(t As Tramite)
        _tramites.Add(t)
    End Sub

    Public Sub IniciarTramite(id As Integer)
        _tramites.Find(Function(x) x.Id = id).Estado = New EstadoIniciado
    End Sub

    Public Sub FinalizarTramite(id As Integer)
        _tramites.Find(Function(x) x.Id = id).Estado = New EstadoFinalizado
    End Sub
End Class
