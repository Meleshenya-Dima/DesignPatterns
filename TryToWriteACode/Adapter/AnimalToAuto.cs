using System;
namespace TryToWriteACode.Adapter
{
    class AnimalToAuto : ITransport
    {
        public AnimalToAuto(IAnimal animal)
        {
            Animal = animal;
        }

        public IAnimal Animal { get; set; }
        public void Drive()
        {
            Animal.Run();
        }
    }
}
