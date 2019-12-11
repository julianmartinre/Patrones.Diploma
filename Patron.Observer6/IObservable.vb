Public Interface IObservable

    Sub AgregarObservador(o As IDiarioObserver)
    Sub QuitarObservador(o As IDiarioObserver)
    Sub NotificarObserver(e As Diario)

End Interface
