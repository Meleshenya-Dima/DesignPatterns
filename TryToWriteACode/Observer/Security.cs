using System;

namespace TryToWriteACode.Observer
{
    class Security : IObserver
    {
        public Security(IObservable observableObject, string nameHuman)
        {
            ObservableObject = observableObject;
            NameHuman = nameHuman;
            ObservableObject.AddObserver(this);
        }

        public IObservable ObservableObject { get; set; }
        public string NameHuman { get; set; }

        public void ChangeSignal()
        {
            Console.WriteLine("Человек под именем {0} заметил движение. Была вызвана полиция!", NameHuman);
        }
    }
}
