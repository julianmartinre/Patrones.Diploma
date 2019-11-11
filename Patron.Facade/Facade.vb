Public Class Facade
    Private _sistema1 As Sistema1
    Public Property sistema1() As Sistema1
        Get
            Return _sistema1
        End Get
        Set(ByVal value As Sistema1)
            _sistema1 = value
        End Set
    End Property
    Private _sistema2 As Sistema2
    Public Property sistema2() As Sistema2
        Get
            Return _sistema2
        End Get
        Set(ByVal value As Sistema2)
            _sistema2 = value
        End Set
    End Property
    Private _sistema3 As Sistema3
    Public Property sistema3() As Sistema3
        Get
            Return _sistema3
        End Get
        Set(ByVal value As Sistema3)
            _sistema3 = value
        End Set
    End Property
    Private _sistema4 As Sistema4
    Public Property sistema4() As Sistema4
        Get
            Return _sistema4
        End Get
        Set(ByVal value As Sistema4)
            _sistema4 = value
        End Set
    End Property

    Sub inicializarSistemas()
        sistema1 = New Sistema1
        sistema2 = New Sistema2
        sistema3 = New Sistema3
        sistema4 = New Sistema4
    End Sub

    Sub procesoA()
        sistema1.MetodoSistema1()
        sistema3.MetodoSistema3()
    End Sub

    Sub procesoB()
        sistema2.MetodoSistema2()
        sistema4.MetodoSistema4()
    End Sub
End Class
