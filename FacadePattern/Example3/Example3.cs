using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Example3
{
    class Facade
    {
        Eft eft;
        Kredi kredi;

        public Facade()
        {
            eft = new Eft();
            kredi = new Kredi();
        }

        public void Kredi(int value)
        {
            kredi.KrediCek(value);
        }
        public void Eft(int value)
        {
            eft.EftYolla(value);
        }
    }

    class Eft
    {
        public void EftYolla(int value)
        {
            if (HesapKontrol.EftKontrol(value))
            {
                Console.WriteLine(value + " Eft olarak yollandı");
                Console.WriteLine("Yeni Hesap bakiyesi : " + (HesapKontrol.Hesapprice - value));
            }
            else
            {
                Console.WriteLine("Yetersiz miktar.");
            }
        }
    }

    class Kredi
    {
        public void KrediCek(int value)
        {
            if (HesapKontrol.KrediKontrol(value))
            {
                Console.WriteLine(value + " Kredi çekilebilir");
            }
            else
            {
                Console.WriteLine("Kredi miktarı verilemez.");
            }
        }
    }

    static class HesapKontrol
    {
        public static double Hesapprice = 1000;
        public static bool EftKontrol(int value)
        {
            if (value > Hesapprice)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double KrediPrice = 200000;

        public static bool KrediKontrol(int value)
        {
            if (value > KrediPrice)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
