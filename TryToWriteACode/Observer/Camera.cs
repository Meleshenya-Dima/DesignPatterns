using System;

namespace TryToWriteACode.Observer
{
    class Camera : IObserver
    {
        public Camera(int numberCamera, IObservable observableObject)
        {
            NumberCamera = numberCamera;
            ObservableObject = observableObject;
            ObservableObject.AddObserver(this);
        }

        public int NumberCamera { get; set; }
        public IObservable ObservableObject { get; set; }

        public void ChangeSignal()
        {
            Console.WriteLine("Камера номер: {0} заметила движение. Была вызвана полиция!", NumberCamera);
        }
    }
}
