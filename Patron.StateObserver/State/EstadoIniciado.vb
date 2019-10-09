Imports Patron.StateObserver

Public Class EstadoIniciado
    Inherits Estado
    Public Overrides Sub ControlarTramite(t As Tramite)
        MsgBox("Está iniciado.")
    End Sub
End Class
