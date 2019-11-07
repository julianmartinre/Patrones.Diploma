Public MustInherit Class Figura
    Protected color As IColor
    Sub New(c As IColor)
        color = c
    End Sub

    Public Overridable Sub AplicarColor()
        color.AplicarColor()
    End Sub
End Class
