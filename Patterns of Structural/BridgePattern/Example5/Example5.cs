using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example5
{
    abstract class Bridge
    {
        protected IRenk _renk;
        protected ISekil _sekil;

        public IRenk Renk
        {
            set { _renk = value; }
        }
        public ISekil Sekil
        {
            set { _sekil = value; }
        }

        public virtual void Birlestir()
        {
            _renk.GetRenk();
            _sekil.GetSekil();
        }
    }

    class Kutu : Bridge
    {
        public override void Birlestir()
        {
            Console.WriteLine("Kutu");
            base.Birlestir();
        }

    }

    class Kagit : Bridge
    {
        public override void Birlestir()
        {
            Console.WriteLine("Kagit");
            _renk.GetRenk();
            _sekil.GetSekil();
        }
    }

    interface IRenk
    {
        void GetRenk();
    }

    class Beyaz : IRenk
    {
        public void GetRenk()
        {
            Console.WriteLine("beyaz ");
        }
    }

    class Siyah : IRenk
    {
        public void GetRenk()
        {
            Console.WriteLine("siyah ");
        }
    }

    interface ISekil
    {
        void GetSekil();
    }

    class Kare : ISekil
    {
        public void GetSekil()
        {
            Console.WriteLine("kare ");
        }
    }

    class Daire : ISekil
    {
        public void GetSekil()
        {
            Console.WriteLine("daire ");
        }
    }
}
