using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Example3
{
    class MevcutSatis
    {
        public virtual void Siparis()
        {
            Console.WriteLine("gitar siparişi verildi");
        }
    }

    class Adaptee
    {
        public void KemenceSiparis()
        {
            Console.WriteLine("saz siparişi verildi");
        }
    }

    class Adapter : MevcutSatis
    {
        Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public override void Siparis()
        {
            _adaptee.KemenceSiparis();
        }

    }
}
