Public Class Plataforma
    Public Sub New(a As IArquitectura)
        arquitectura = a
    End Sub
    Private _arquitectura As IArquitectura
    Public Property arquitectura() As IArquitectura
        Get
            Return _arquitectura
        End Get
        Set(ByVal value As IArquitectura)
            _arquitectura = value
        End Set
    End Property
    Public Overridable Sub SetearArquitectura()
        arquitectura.SetearArquitectura()
    End Sub
End Class
