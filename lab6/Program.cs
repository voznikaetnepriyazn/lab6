using System;

namespace lab6
{
    static void Main(string[] args)
    {
        List<IObservable> observables = new List<IObservable>
        {
            new ObservableElement(0),
            new ObservableElement(0),
            new ObservableElement(0),
            new ObservableElement(1),
        };
        var observer = new ConcretObserver();
        foreach (var observable in observables)
        {
            observer.Visit(observable);
        }
    }
}

