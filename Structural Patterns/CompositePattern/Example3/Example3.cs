using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Example3
{
    enum bolum
    {
        ArGe,
        Analist,
        Test,
        Senior,
        Junior
    }

    abstract class Sirket
    {
        protected string _isim;
        protected bolum _departman;

        public Sirket(string isim, bolum bolum)
        {
            _departman = bolum;
            _isim = isim;
        }
        public abstract void Yazdir(int satirbasi);
    }

    class Kadro : Sirket
    {
        List<Sirket> sirket = new List<Sirket>();
        public Kadro(string isim, bolum bolum) : base(isim, bolum)
        {

        }

        public void Ekle(Sirket t)
        {
            sirket.Add(t);
        }
        public void Remove(Sirket t)
        {
            sirket.Remove(t);
        }
        public override void Yazdir(int satirbasi)
        {
            Console.WriteLine(satirbasi + " " + _isim + " " + _departman);

            foreach (Sirket item in sirket)
            {
                item.Yazdir(satirbasi + 2);
            }
        }
    }

    class Yazilim : Sirket
    {
        public Yazilim(string isim, bolum departman) : base(isim, departman)
        {

        }
        public override void Yazdir(int satirbasi)
        {
            Console.WriteLine(satirbasi + _isim + "Yazilim");
        }
    }
}
