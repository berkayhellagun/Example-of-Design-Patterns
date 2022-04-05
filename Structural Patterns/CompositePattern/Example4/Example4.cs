using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Example4
{
    enum enDerece
    {
        GenelMudur = 1,
        Mudur = 2,
        DepartmanSorumlusu = 3,
        İsci = 4
    }

    abstract class Calisan
    {
        protected string _isim;
        protected enDerece _derece;

        public Calisan(string isim, enDerece derece)
        {
            _isim = isim;
            _derece = derece;
        }

        public abstract void Goster();
    }

    class CompositeCalisan : Calisan
    {
        List<Calisan> calisan = new List<Calisan>();
        public CompositeCalisan(string isim, enDerece derece) : base(isim, derece)
        {

        }

        public void Add(Calisan t)
        {
            calisan.Add(t);
        }

        public override void Goster()
        {
            Console.WriteLine(_isim + " " + _derece);
            foreach (Calisan item in calisan)
            {
                item.Goster();
            }
        }

    }

    class LeafCalisan : Calisan
    {
        public LeafCalisan(string isim, enDerece derece) : base(isim, derece)
        {

        }

        public override void Goster()
        {
            Console.WriteLine("son " + _isim + " " + _derece);
        }
    }
}

