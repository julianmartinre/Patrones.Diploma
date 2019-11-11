Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arquitectura As IArquitectura = New x64
        Dim so As Plataforma = New Windows(arquitectura)
        so.SetearArquitectura()
    End Sub
End Class
