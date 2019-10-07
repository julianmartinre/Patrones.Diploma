Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim unProducto As New Producto With {.Nombre = "Naranja", .Cantidad = 100}

        MsgBox(unProducto.Cantidad)

        Dim unaOrden As New OrdenAlta(unProducto, 20)
        Dim otraOrden As New OrdenAlta(unProducto, 80)
        Dim otraOrdenMas As New OrdenBaja(unProducto, 120)

        Dim unaEmpresa As New Empresa
        unaEmpresa.tomarOrden(unaOrden)
        unaEmpresa.tomarOrden(otraOrden)
        unaEmpresa.tomarOrden(otraOrdenMas)

        unaEmpresa.procesarOrdenes()

        MsgBox(unProducto.Cantidad)

    End Sub
End Class
