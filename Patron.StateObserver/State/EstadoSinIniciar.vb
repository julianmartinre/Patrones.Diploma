Imports Patron.StateObserver

Public Class EstadoSinIniciar
    Inherits Estado
    Public Overrides Sub ControlarTramite(t As Tramite)
        MsgBox("Está sin iniciar.")
    End Sub
End Class
