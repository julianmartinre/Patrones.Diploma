Public Class Form1
    Dim unaPersona As New Persona With {.Nombre = "Julián"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unTramite As New Tramite With {.Id = 1, .Estado = New EstadoSinIniciar}
        unaPersona.AgregarTramite(unTramite)

        'Iniciando el trámite.
        unaPersona.IniciarTramite(1)

        'Finalizo el trámite.
        unaPersona.FinalizarTramite(1)

    End Sub
End Class
