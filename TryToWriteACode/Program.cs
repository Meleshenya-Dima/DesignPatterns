using System.Collections.Generic;
using TryToWriteACode.Adapter;
using TryToWriteACode.Factory_Method;
using TryToWriteACode.Fluent_Builder;
using TryToWriteACode.Observer;
using TryToWriteACode.Strategy;
using TryToWriteACode.Singleton;

namespace TryToWriteACode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method
            List<Enemy> enemies = new();
            CreateEnemy createEnemy = new CreateWorm();
            enemies.Add(createEnemy.CreateEnemyMethod());
            createEnemy = new CreateSpider();
            enemies.Add(createEnemy.CreateEnemyMethod());
            createEnemy = new CreateSlime();
            enemies.Add(createEnemy.CreateEnemyMethod());
            //Strategy
            Player player = new Player(new PlayerWalk(), "Дима");
            player.GetPace();
            player.PlayerMove = new PlayerRun();
            player.GetPace();
            //Observer
            Room room = new Room();
            Camera camera = new Camera(1, room);
            Security Dima = new Security(room, "Дима");
            room.SomethingInTheRoom();
            //Adapter
            Auto auto = new Auto();
            GoDrive.Drive(auto);
            Cat cat = new Cat();
            AnimalToAuto animalToAuto = new AnimalToAuto(cat);
            GoDrive.Drive(animalToAuto);
            //Fluent Builder
            Pet pet = new CreatePet().SetName("Барсик").SetHealth(3f).SetWeight(4f).Build();
            pet.ShowInfo();
            //Singleton
            Car car = new Car();
            car.EngineInstallation();
            car.GetInfoAboutEngine();
            //😘
        }
    }
}
