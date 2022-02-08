using System;

namespace TryToWriteACode.Factory_Method
{
    class Worm : Enemy
    {
        public Worm()
        {
            EnemyName = "Червь";
            Damage = 2;
            Weight = 25;
            Difficulty = "Normal";
            Health = 6;
        }
    }
}
