Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fabrica As New Fabrica
        lstEspecies.Items.Add(fabrica.Agregar(1))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fabrica As New Fabrica
        lstEspecies.Items.Add(fabrica.Agregar(2))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fabrica As New Fabrica
        lstEspecies.Items.Add(fabrica.Agregar(3))
    End Sub
End Class
