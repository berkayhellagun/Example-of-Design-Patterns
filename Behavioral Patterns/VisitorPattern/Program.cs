using System;
using VisitorPattern.Example1;
using VisitorPattern.Example3;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1Test();
            Example3Test();
        }
        private static void Example1Test()
        {
            Ipad ıpad = new Ipad("ıpad", "model 8");
            Galaxy galaxy = new Galaxy("samsung", "galaxy");

            ıpad.Accept(new ThreeG());
        }
        private static void Example3Test()
        {
            Personel ogretimu = new OgretimUyesi();
            ogretimu.Accept(new Staj());
        }
    }
}
