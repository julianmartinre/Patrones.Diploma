Public Class Form1

    Dim dolar As Dolar
    Dim cliente As Cliente
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dolar = New Dolar With {.Nombre = "DOLAR", .PrecioCompra = 60}
        cliente = New Cliente With {.Nombre = "JULIÁN"}
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dolar.AgregarDivisaObserver(cliente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dolar.SetPrecioCompra(200)
    End Sub
End Class
