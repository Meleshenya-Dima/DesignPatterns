using System;

namespace TryToWriteACode.Adapter
{
    class Cat : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("Котик по дому бегает.");
        }
    }
}
