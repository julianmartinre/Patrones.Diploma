Public Class Gerente
    Inherits Aprobador
    Public Overrides Sub ProcesarCompra(c As Compra)
        If c.importe < 1000 Then
            MsgBox("Pagó el gerente.")
        Else
            Me.siguienteAprobar.ProcesarCompra(c)
        End If
    End Sub
End Class
