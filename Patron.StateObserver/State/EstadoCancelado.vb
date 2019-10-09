Imports Patron.StateObserver

Public Class EstadoCancelado
    Inherits Estado
    Public Overrides Sub ControlarTramite(t As Tramite)
        MsgBox("Está cancelado.")
    End Sub
End Class
