using StatePattern.Example1;
using System;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1Test();
        }

        private static void Example1Test()
        {
            Soket soket = new Soket(8080);
            soket.Do();
            soket.Do();
        }
    }
}
