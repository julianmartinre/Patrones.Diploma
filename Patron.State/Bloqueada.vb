Imports Patron.State

Public Class Bloqueada
    Inherits Estado
    Public Overrides Sub ControlarCuenta(cuenta As Cuenta)
        MsgBox("Está bloqueada.")
    End Sub
End Class
