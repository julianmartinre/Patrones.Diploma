Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim factory As New FlyweightFactoryCaracter
        Dim doc As String = "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABC"
        Dim caracteres() As Char = doc.ToCharArray()
        Dim tamanio As Integer = 10

        For Each item In caracteres
            factory.ObtenerCaracter(item).Mostrar(tamanio)
        Next
        MsgBox(caracteres.Count())
        MsgBox(factory.ObtenerCantidad())
    End Sub
End Class
