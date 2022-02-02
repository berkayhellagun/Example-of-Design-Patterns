using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Example1
{
    interface IAlanHesapla
    {
        int AlanHesap();
    }

    class Diktorgen : IAlanHesapla
    {
        public int t;
        public int y;

        public void degerAl(int taban, int yukseklik)
        {
            t = taban;
            y = yukseklik;
        }

        public int AlanHesap()
        {
            var alan = t * y;
            return alan;
        }
    }

    class Adapter : IAlanHesapla
    {
        Kare kare;
        private int k;
        public int K
        {
            set { k = value; }
        }
        public Adapter()
        {
            kare = new Kare();
        }

        public int AlanHesap()
        {
            var alan = kare.kareAlanHesap(k);
            return alan;
        }
    }


    class Kare
    {
        public int kareAlanHesap(int k)
        {
            var alan = k * k;
            return alan;
        }
    }
}
