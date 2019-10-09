Imports Patron.StateObserver

Public Class Tramite

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _estado As Estado
    Public Property Estado() As Estado
        Get
            Return _estado
        End Get
        Set(ByVal value As Estado)
            _estado = value
        End Set
    End Property

End Class
