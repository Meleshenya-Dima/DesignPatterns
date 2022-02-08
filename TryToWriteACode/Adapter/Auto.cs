using System;

namespace TryToWriteACode.Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Дорожный автобус едет по дороге.");
        }
    }
}
