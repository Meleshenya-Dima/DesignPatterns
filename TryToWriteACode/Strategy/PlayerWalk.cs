using System;

namespace TryToWriteACode.Strategy
{
    class PlayerWalk : IPlayerMove
    {
        public void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}
