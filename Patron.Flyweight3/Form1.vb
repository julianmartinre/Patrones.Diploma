Public Class Form1
    Dim fabrica As New FactoryFlyweightPelota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pelota As PelotaFlyweight = fabrica.ObtenerPelota("ROJA")
        pelota.x = txtX.Text
        pelota.y = txtY.Text
        lstPelotas.Items.Add("Color: " & pelota.color & " Radio: " & pelota.radio & " X: " & pelota.x & " Y: " & pelota.y)
        lblObjetos.Text = fabrica.ObtenerCantidadDePelotas()
        lblPelotas.Text = lstPelotas.Items.Count()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pelota As PelotaFlyweight = fabrica.ObtenerPelota("VERDE")
        pelota.x = txtX.Text
        pelota.y = txtY.Text
        lstPelotas.Items.Add("Color: " & pelota.color & " Radio: " & pelota.radio & " X: " & pelota.x & " Y: " & pelota.y)
        lblObjetos.Text = fabrica.ObtenerCantidadDePelotas()
        lblPelotas.Text = lstPelotas.Items.Count()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pelota As PelotaFlyweight = fabrica.ObtenerPelota("AZUL")
        pelota.x = txtX.Text
        pelota.y = txtY.Text
        lstPelotas.Items.Add("Color: " & pelota.color & " Radio: " & pelota.radio & " X: " & pelota.x & " Y: " & pelota.y)
        lblObjetos.Text = fabrica.ObtenerCantidadDePelotas()
        lblPelotas.Text = lstPelotas.Items.Count()
    End Sub
End Class
