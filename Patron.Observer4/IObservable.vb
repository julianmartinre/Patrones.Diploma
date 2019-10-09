Public Interface IObservable
    Sub AgregarObservador(o As IObserver)
    Sub QuitarObservador(o As IObserver)
    Sub NotificarObservador(o As Idioma)
End Interface
