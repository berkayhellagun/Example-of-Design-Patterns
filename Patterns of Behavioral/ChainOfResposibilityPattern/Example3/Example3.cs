using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.Example3
{
    class Customer
    {
        public bool Maas { get; set; }
        public bool Kefil { get; set; }
        public int Gecikme { get; set; }
        public int Skor { get; set; }
    }

    abstract class Kredi
    {
        public Kredi _next;
        public bool durum;

        public void setNext(Kredi kredi)
        {
            _next = kredi;
        }

        public void Operasyon(Customer customer)
        {
            Execute(customer);
            if (durum)
            {
                if (_next != null)
                {
                    _next.durum = durum;
                    _next.Operasyon(customer);
                }
            }
        }


        public abstract void Execute(Customer customer);
    }

    class KrediSkor : Kredi
    {
        public override void Execute(Customer customer)
        {
            if (customer.Skor < 1000)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
    }
    class KefilKontrol : Kredi
    {
        public override void Execute(Customer customer)
        {
            if (customer.Kefil == false)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
    }
    class MaasKontrol : Kredi
    {
        public override void Execute(Customer customer)
        {
            if (customer.Maas == false)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
    }
    class GecikmeKontrol : Kredi
    {
        public override void Execute(Customer customer)
        {
            if (customer.Gecikme > 3)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
    }
}
