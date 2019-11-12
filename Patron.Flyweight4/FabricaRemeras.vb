Public Class FabricaRemeras

    Private remeras As Dictionary(Of Char, RemeraFlyweight) = New Dictionary(Of Char, RemeraFlyweight)

    Function ObtenerCantidadRemeras()
        Return remeras.Count()
    End Function

    Function ObtenerRemera(key As Char)
        Dim remera As RemeraFlyweight

        If remeras.ContainsKey(key) Then
            remera = remeras(key)
        Else
            Select Case key
                Case "ROJA"
                    remera = New RemeraRoja
                Case "VERDE"
                    remera = New RemeraRoja
                Case "AZUL"
                    remera = New RemeraAzul
            End Select
            remeras.Add(key, remera)
        End If
        Return remera
    End Function

End Class
