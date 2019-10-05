Imports Patron.State

Public Class Activa
    Inherits Estado
    Public Overrides Sub ControlarCuenta(cuenta As Cuenta)
        If cuenta.intentos > 3 Then
            cuenta.state = New Bloqueada
        End If
    End Sub
End Class
