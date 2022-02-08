namespace TryToWriteACode.Fluent_Builder
{
    class CreatePet
    {
        private Pet pet = new Pet();
        public CreatePet SetName(string name)
        {
            pet.Name = name;
            return this;
        }
        public CreatePet SetHealth(float health)
        {
            pet.Health = health;
            return this;
        }
        public CreatePet SetWeight(float weight)
        {
            pet.Weight = weight;
            return this;
        }
        public Pet Build()
        {
            return pet;
        }
    }
}
