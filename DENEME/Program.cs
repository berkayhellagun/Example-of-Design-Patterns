using System;
using System.Collections.Generic;

namespace DENEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri { Maas=true,Gecikme=1,Kefil=true,Skor=1600};
            List<KrediIstegi> islemler = new List<KrediIstegi>();
            islemler.Add(new KrediSkor());
            islemler.Add(new Gecikme());
            islemler.Add(new KefilDurum());
            islemler.Add(new MaasDurum());


            islemler[0].SetSonraki(islemler[1]);
            islemler[1].SetSonraki(islemler[2]);
            islemler[2].SetSonraki(islemler[3]);

            islemler[0].ExecuteProcess(musteri);

            bool status = islemler[islemler.Count - 1].Deger;
            if (status)
            {
                Console.WriteLine("islemler basarili");
            }
            else
            {
                Console.WriteLine("islemler basarisiz");
            }
        }
    }
    class Musteri
    {
        public int Skor { get; set; }
        public int Gecikme { get; set; }
        public bool Kefil { get; set; }
        public bool Maas { get; set; }
    }

    abstract class KrediIstegi
    {
        protected KrediIstegi _next;
        public bool Deger;
        
        public void SetSonraki(KrediIstegi kredi)
        {
            _next = kredi;
        }

        public virtual void ExecuteProcess(Musteri musteri)
        {
            Execute(musteri);
            if (_next!=null)
            {
                _next.Deger = Deger;
                _next.ExecuteProcess(musteri);
            }
        }
        public abstract void Execute(Musteri musteri);
    }
    class KrediSkor : KrediIstegi
    {
        public override void Execute(Musteri musteri)
        {
            if (musteri.Skor>1500)
            {
                Deger = true;
            }
            else
            {
                Deger = false;
            }
        }
    }
    class Gecikme : KrediIstegi
    {
        public override void Execute(Musteri musteri)
        {
            if (musteri.Gecikme<=3)
            {
                Deger = true;
            }
            else
            {
                Deger = false;
            }
        }
    }
    class KefilDurum : KrediIstegi
    {
        public override void Execute(Musteri musteri)
        {
            if (musteri.Kefil)
            {
                Deger = true;
            }
            else
            {
                Deger=false;
            }
        }
    }
    class MaasDurum : KrediIstegi
    {
        public override void Execute(Musteri musteri)
        {
            if (musteri.Maas)
            {
                Deger = true;
            }
            else
            {
                Deger = false;
            }
        }
    }
}

