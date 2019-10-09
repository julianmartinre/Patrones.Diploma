Imports Patron.StateObserver

Public Class EstadoFinalizado
    Inherits Estado
    Public Overrides Sub ControlarTramite(t As Tramite)
        MsgBox("Está finalizado.")
    End Sub
End Class
