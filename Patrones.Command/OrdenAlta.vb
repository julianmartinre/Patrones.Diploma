Public Class OrdenAlta
    Inherits Orden
    Sub New(p As Producto, c As Integer)
        MyBase.New(p, c)
    End Sub
    Public Overrides Sub Ejecutar()
        Producto.AgregarStock(Cantidad)
    End Sub
End Class
