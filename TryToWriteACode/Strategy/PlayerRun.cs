using System;

namespace TryToWriteACode.Strategy
{
    class PlayerRun : IPlayerMove
    {
        public void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
