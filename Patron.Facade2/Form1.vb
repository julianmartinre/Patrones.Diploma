Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim facade As New FacadeUniversidad
        facade.IniciarSectores()
        facade.AnotarExamen()
        facade.TodosLosMetodos()
    End Sub
End Class
