using System;
namespace TryToWriteACode.Fluent_Builder
{
    class Pet
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public float Weight { get; set; }
        public CreatePet CreateNewPet()
        {
            return new CreatePet();
        }
        public void ShowInfo()
        {
            Console.WriteLine("Имя животного: {0}, количество здоровья {1}, вес животного {2} кг", Name, Health, Weight);
        }
    }
}
