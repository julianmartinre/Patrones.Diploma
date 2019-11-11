Public Class Form1
    Dim facade As New Facade
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facade.inicializarSistemas()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Proceso A")
        facade.procesoA()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Proceso B")
        facade.procesoB()
    End Sub
End Class
