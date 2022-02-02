using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoyPattern.Example1
{
    public class GenericFac
    {
        IConc _conc;
        IProd _prod;
        public GenericFac(IConc conc)
        {
            _conc = conc;
            _prod = conc.get();
        }
        public void yazdır()
        {
            Console.WriteLine(_conc + " için " + _prod.urun());
        }
    }


    public abstract class IConc
    {
        public abstract IProd get();
    }

    public class A : IConc
    {
        public override IProd get()
        {
            return new AUrun();
        }
    }
    public class B : IConc
    {
        public override IProd get()
        {
            return new BUrun();
        }
    }


    public interface IProd
    {
        public bool urun();
    }

    public class AUrun : IProd
    {
        public bool urun()
        {
            return true;
        }
    }
    public class BUrun : IProd
    {
        public bool urun()
        {
            return true;
        }
    }
}
