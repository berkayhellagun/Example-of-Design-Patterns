using SingletonPattern.Example1;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1Test();
        }

        private static void Example1Test()
        {
            Dock dock = Dock.DengeleyiciGetir();
            for (int i = 0; i < 15; i++)
            {
                string server = dock.Sunucu;
                Console.WriteLine("istek yapıldı : " + server);
            }
        }
    }

}
