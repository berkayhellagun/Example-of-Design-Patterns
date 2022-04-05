using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Example2
{
    class Adaptee
    {
        public double IskontoluTutarHesapla(double fiyat, double adet)
        {
            Console.WriteLine("lütfen iskonto miktarı giriniz");
            var result = Convert.ToDouble(Console.ReadLine());
            return fiyat * adet * (1 - result);
        }
    }

    public interface ITutar
    {
        double Hesapla(double fiyat, double adet);
    }

    public class Adapter : ITutar
    {
        Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public double Hesapla(double fiyat, double adet)
        {
            return _adaptee.IskontoluTutarHesapla(fiyat, adet);
        }
    }
    public class Client
    {
        public void OdenecekMeblag(ITutar tutar)
        {
            Console.WriteLine("fiyat gir");
            var fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("adet gir");
            var adet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hesaplayici : " + tutar.Hesapla(fiyat, adet));
        }
    }
}
