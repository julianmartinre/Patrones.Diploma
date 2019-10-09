Public Interface IObservable
    Sub AgregarObservador(o As IObserver)
    Sub QuitarObservador(o As IObserver)
    Sub Notificar(o As Tramite)
End Interface
