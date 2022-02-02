using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Example1
{
    class Facade
    {
        private Subsystem1 _system1;
        private Subsystem2 _system2;
        private Subsystem3 _system3;
        private static Facade nesne = null;

        private Facade()
        {
            _system1 = new Subsystem1();
            _system2 = new Subsystem2();
            _system3 = new Subsystem3();
        }

        public static Facade CreateFacade()
        {
            if (nesne == null)
            {
                nesne = new Facade();
            }
            return nesne;
        }
        public void DoWork()
        {
            _system1.Bar();
            _system2.Test();
        }

        public void Sample()
        {

            _system3.Tar();
        }

        public void Deneme()
        {
            Subsystem4.Zet();
        }

    }

    public class Subsystem1
    {
        public void Foo()
        {
            Console.WriteLine("sbs1=foo");
        }
        public void Bar()
        {
            Console.WriteLine("sbs1=Bar");
        }
    }
    public class Subsystem3
    {
        public void Tar()
        {
            Console.WriteLine("sbs3=tar");
        }
    }
    internal class Subsystem2
    {
        public void Test()
        {
            Console.WriteLine("sbs2=test");
        }
        public void Bar()
        {
            Console.WriteLine("sbs2=Bar");
        }
    }
    internal static class Subsystem4
    {
        public static void Zet()
        {
            Console.WriteLine("sbs4=zet");
        }
    }
}
