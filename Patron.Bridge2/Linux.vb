Public Class Linux
    Inherits Plataforma
    Public Sub New(a As IArquitectura)
        MyBase.New(a)
    End Sub
    Public Overrides Sub SetearArquitectura()
        MsgBox("Seteando arquitectura.")
        MyBase.SetearArquitectura()
    End Sub
End Class
