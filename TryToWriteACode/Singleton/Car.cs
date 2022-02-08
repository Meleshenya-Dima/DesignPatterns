namespace TryToWriteACode.Singleton
{
    class Car
    {
        private Singleton engine;

        public void EngineInstallation()
        {
            engine = Singleton.GetSingletonObject("GoodCar", 180, 700);
        }
        public void GetInfoAboutEngine()
        {
            System.Console.WriteLine($"Engine name: {engine.NameEngine}, Engine power: {engine.Power}, Engine weight: {engine.Weight}");
        }
    }
}
