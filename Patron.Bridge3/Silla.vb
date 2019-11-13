Public Class Silla
    Inherits Mueble
    Public Sub New(m As IMaterial)
        MyBase.New(m)
    End Sub
    Public Overrides Sub setearMaterial()
        MsgBox("Seteando material.")
        MyBase.SetearMaterial()
    End Sub
End Class
