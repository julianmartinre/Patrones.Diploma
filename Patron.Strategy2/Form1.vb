Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unInstrumento As New Instrumento
        unInstrumento.EstrategiaSonido = New SonidoGuitarra
        unInstrumento.EstrategiaSonido.Sonar()
    End Sub
End Class
