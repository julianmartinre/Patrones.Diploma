Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cuenta As New Cuenta
        cuenta.user = "julian"
        cuenta.password = "123456"
        cuenta.state = New Activa
        cuenta.intentos = 4

        cuenta.state.ControlarCuenta(cuenta)

        cuenta.state.ControlarCuenta(cuenta)

    End Sub
End Class
