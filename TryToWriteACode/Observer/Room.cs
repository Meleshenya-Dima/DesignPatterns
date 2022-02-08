using System.Collections.Generic;

namespace TryToWriteACode.Observer
{
    class Room : IObservable
    {
        public Room()
        {
            Observers = new List<IObserver>();
        }

        List<IObserver> Observers { get; set; }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.ChangeSignal();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void SomethingInTheRoom()
        {
            NotifyObservers();
        }
    }
}
