Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comprador As New Comprador
        Dim gerente As New Gerente
        Dim director As New Director

        comprador.AgregarSiguienteAprobador(gerente)
        gerente.AgregarSiguienteAprobador(director)

        Dim compra As New Compra
        compra.importe = 40

        comprador.ProcesarCompra(compra)

        compra.importe = 120
        comprador.ProcesarCompra(compra)

        compra.importe = 1200
        comprador.ProcesarCompra(compra)

    End Sub
End Class
