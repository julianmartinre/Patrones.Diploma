Public Class OrdenBaja
    Inherits Orden
    Sub New(p As Producto, c As Integer)
        MyBase.New(p, c)
    End Sub
    Public Overrides Sub Ejecutar()
        Producto.RestarStock(Cantidad)
    End Sub
End Class
