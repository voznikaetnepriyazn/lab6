namespace lab6
{
    public static void Main(string[] args)
    {
        List<IObservable> observables = new List<IObservable>
        {
            new ObservableElement(0),
            new ObservableElement(0),
            new ObservableElement(0),
            new ObservableElement(1),
        };
        ConcretObserver observer = new ConcretObserver();
        foreach ( var observable in observables)
        {
            observable.Accept(observer);
        }
    }
}

