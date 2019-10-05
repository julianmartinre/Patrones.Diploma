Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unJugador As New Jugador
        unJugador.disparo = New DisparoBazooka
        unJugador.disparo.Disparar()
        unJugador.disparo = New DisparoAk47
        unJugador.disparo.Disparar()
        unJugador.disparo = New DisparoPistola
        unJugador.disparo.Disparar()
    End Sub
End Class
