Public Class Director
    Inherits Aprobador
    Public Overrides Sub ProcesarCompra(c As Compra)
        MsgBox("Pagó el director.")
    End Sub
End Class
