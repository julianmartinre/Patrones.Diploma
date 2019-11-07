Public Class Fabrica
    Private _listaEspecies As New Dictionary(Of Integer, Especie)
    Public Sub New()
        Dim cucaracha As New Cucaracha
        Dim hormiga As New Hormiga
        Dim langosta As New Langosta

        _listaEspecies.Add(1, cucaracha)
        _listaEspecies.Add(2, hormiga)
        _listaEspecies.Add(3, langosta)
    End Sub

    Public Function Agregar(valor As Integer) As Especie
        Return _listaEspecies(valor)
    End Function
End Class
