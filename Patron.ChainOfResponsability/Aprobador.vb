Public MustInherit Class Aprobador
    Private _siguienteAprobador As Aprobador
    Public Property siguienteAprobar() As Aprobador
        Get
            Return _siguienteAprobador
        End Get
        Set(ByVal value As Aprobador)
            _siguienteAprobador = value
        End Set
    End Property
    Public Sub AgregarSiguienteAprobador(aprobador As Aprobador)
        _siguienteAprobador = aprobador
    End Sub
    Public MustOverride Sub ProcesarCompra(c As Compra)
End Class
