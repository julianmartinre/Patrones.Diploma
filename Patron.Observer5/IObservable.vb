Public Interface IObservable

    Sub AgregarObservador(o As IObserver)
    Sub QuitarObservador(o As IObserver)
    Sub NotificarObserver(e As ECommerce)

End Interface
