Public Class FacadeUniversidad
    Private _administracion As Administracion
    Public Property administracion() As Administracion
        Get
            Return _administracion
        End Get
        Set(ByVal value As Administracion)
            _administracion = value
        End Set
    End Property
    Private _bedelia As Bedelia
    Public Property bedelia() As Bedelia
        Get
            Return _bedelia
        End Get
        Set(ByVal value As Bedelia)
            _bedelia = value
        End Set
    End Property
    Private _recursos As Recursos
    Public Property recursos() As Recursos
        Get
            Return _recursos
        End Get
        Set(ByVal value As Recursos)
            _recursos = value
        End Set
    End Property

    Sub IniciarSectores()
        administracion = New Administracion
        bedelia = New Bedelia
        recursos = New Recursos
    End Sub

    Sub AnotarExamen()
        bedelia.AnotarExamen()
    End Sub

    Sub TodosLosMetodos()
        administracion.CobrarCuota()
        bedelia.AnotarExamen()
        recursos.PagarSueldo()
    End Sub
End Class
