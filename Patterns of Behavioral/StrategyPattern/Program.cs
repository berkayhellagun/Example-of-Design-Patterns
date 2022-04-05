using StrategyPattern.Example1;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1Test();
        }

        private static void Example1Test()
        {
            Total total = new Total();
            total.setMaas(new MuhendisMaas());
            total.Maas();
        }
    }


}
