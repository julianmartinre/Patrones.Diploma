Public Class Empresa
    Private _ordenes As New List(Of Orden)
    Public Property Ordenes() As List(Of Orden)
        Get
            Return _ordenes
        End Get
        Set(ByVal value As List(Of Orden))
            _ordenes = value
        End Set
    End Property

    Sub tomarOrden(o As Orden)
        Ordenes.Add(o)
    End Sub

    Sub procesarOrdenes()
        For Each item In Ordenes
            item.Ejecutar()
        Next
        Ordenes.Clear()
    End Sub
End Class
