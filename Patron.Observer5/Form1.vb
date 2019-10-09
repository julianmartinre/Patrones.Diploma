Public Class Form1

    Dim eCommerce As ECommerce
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        eCommerce = New ECommerce With {.Nombre = "MercadoFree"}

        Dim unCliente As New Cliente With {.Nombre = "Julian"}

        Dim unaPromocion As New Promocion With {.Nombre = "Alpargatas 0 km.", .Precio = 200}

        eCommerce.AgregarPromocion(unaPromocion)

        eCommerce.AgregarObservador(unCliente)

        Dim otraPromocion As New Promocion With {.Nombre = "Alitas de cerdo atr.", .Precio = 200}

        eCommerce.AgregarPromocion(otraPromocion)

    End Sub
End Class
