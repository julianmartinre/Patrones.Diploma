Public Class Comprador
    Inherits Aprobador
    Public Overrides Sub ProcesarCompra(c As Compra)
        If c.importe < 100 Then
            MsgBox("Pagó el comprador.")
        Else
            Me.siguienteAprobar.ProcesarCompra(c)
        End If
    End Sub
End Class
