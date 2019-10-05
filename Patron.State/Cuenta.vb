Public Class Cuenta

    Private _user As String
    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _state As Estado
    Public Property state() As Estado
        Get
            Return _state
        End Get
        Set(ByVal value As Estado)
            _state = value
        End Set
    End Property

    Private _intentos As Integer
    Public Property intentos() As Integer
        Get
            Return _intentos
        End Get
        Set(ByVal value As Integer)
            _intentos = value
        End Set
    End Property

    Public Sub Login(user As String, password As String)
        state.ControlarCuenta(Me)
    End Sub

End Class
