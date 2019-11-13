Public Class FactoryMateria
    Private materias As Dictionary(Of Char, MateriaFlyweight) = New Dictionary(Of Char, MateriaFlyweight)
    Function obtenerCantidadMaterias()
        Return materias.Count()
    End Function

    Function obtenerMateria(key) As MateriaFlyweight
        Dim materia As MateriaFlyweight
        If materias.ContainsKey(key) Then
            materia = materias(key)
        Else
            Select Case key
                Case "Informatica"
                    materia = New MateriaInformatica
                Case "Matematica"
                    materia = New MateriaMatematica
                Case "Historia"
                    materia = New MateriaHistoria
            End Select
            materias.Add(key, materia)
        End If
        Return materia
    End Function
End Class
