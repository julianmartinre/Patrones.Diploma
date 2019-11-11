Public Class FactoryFlyweightPelota
    Private pelotas As Dictionary(Of Char, PelotaFlyweight) = New Dictionary(Of Char, PelotaFlyweight)

    Function ObtenerCantidadDePelotas()
        Return pelotas.Count()
    End Function

    Function ObtenerPelota(key As Char)
        Dim pelota As PelotaFlyweight

        If pelotas.ContainsKey(key) Then
            pelota = pelotas(key)
        Else
            Select Case key
                Case "ROJA"
                    pelota = New PelotaConcretaRoja
                Case "VERDE"
                    pelota = New PelotaConcretaVerde
                Case "AZUL"
                    pelota = New PelotaConcretaAzul
            End Select
            pelotas.Add(key, pelota)
        End If
        Return pelota
    End Function

End Class
