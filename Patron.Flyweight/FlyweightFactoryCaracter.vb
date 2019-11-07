Public Class FlyweightFactoryCaracter

    Private caracteres As Dictionary(Of Char, FlyweightCaracter) = New Dictionary(Of Char, FlyweightCaracter)

    Function ObtenerCantidad()
        Return caracteres.Count()
    End Function

    Function ObtenerCaracter(key As Char)
        Dim caracter As FlyweightCaracter

        If caracteres.ContainsKey(key) Then
            caracter = caracteres(key)
        Else
            Select Case key
                Case "A"
                    caracter = New CaracterA
                Case "B"
                    caracter = New CaracterB
                Case "C"
                    caracter = New CaracterC
            End Select
            caracteres.Add(key, caracter)
        End If
        Return caracter
    End Function

End Class
