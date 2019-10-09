Imports Patron.StateObserver

Public Class Persona
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

    Public Sub CancelarTramite(id As Integer)
        _tramites.Find(Function(x) x.Id = id).Estado = New EstadoCancelado
    End Sub

    Public Sub Actualizar(t As Tramite) Implements IObserver.Actualizar
        MsgBox("Cambio el estado de un tramite.")
    End Sub
End Class
