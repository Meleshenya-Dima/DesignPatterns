namespace TryToWriteACode.Singleton
{
    class Singleton
    {
        private static Singleton singleton;

        protected Singleton(string nameEngine, int power, int weight)
        {
            NameEngine = nameEngine;
            Power = power;
            Weight = weight;
        }

        public string NameEngine { get; set; }
        public int Power { get; set; }
        public int Weight { get; set; }

        public static Singleton GetSingletonObject(string NameEngine, int Power, int Weight)
        {
            if (singleton == null)
                singleton = new Singleton(NameEngine, Power, Weight);
            return singleton;
        }
    }
}
