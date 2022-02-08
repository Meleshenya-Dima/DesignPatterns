namespace TryToWriteACode.Observer
{
    interface IObserver
    {
        public IObservable ObservableObject { get; set; }
        public void ChangeSignal();
    }
}
