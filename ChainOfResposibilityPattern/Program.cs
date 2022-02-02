using System;
using System.Collections.Generic;

namespace ChainOfResposibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Handler> handlers = new List<Handler>();

            //Handler alinma=new Alınma();
            //Handler tasima = new Taşıma();
            //Handler dagitim = new Dağıtım();
            //Handler teslim=new Teslim();

            //handlers.Add(alinma);
            //handlers.Add(tasima);
            //handlers.Add(dagitim);
            //handlers.Add(teslim);

            //for (int i = 0; i < 3; i++)
            //{
            //    handlers[i].setNext(handlers[i + 1]);
            //}
            //Kargo kargo=new Kargo { alinma=true,tasima=true,dagitim=false, teslim=true };

            //handlers[0].Progress(kargo);
            //var res = handlers[handlers.Count - 1].durum;
            //if (res)
            //{
            //    Console.WriteLine("kargo işlemleri başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("kargo işlemleri başarısız");
            //}
            /*List<Kredi> islemler = new List<Kredi>();

            Customer customer = new Customer { Gecikme = 0, Kefil = true, Maas = true, Skor = 1500 };            
            
            MaasKontrol maas=new MaasKontrol();
            KefilKontrol kefilKontrol=new KefilKontrol();
            KrediSkor kredi = new KrediSkor();
            GecikmeKontrol gecikmeKontrol = new GecikmeKontrol();

            /*islemler.Add(maas);
            islemler.Add(kefilKontrol);
            islemler.Add(kredi);
            islemler.Add(gecikmeKontrol);

            for (int i = 0; i < islemler.Count - 1; i++)
            {
                islemler[i].setNext(islemler[i + 1]);
            }
            islemler[0].Operasyon(customer);

            bool durum=islemler[islemler.Count - 1].durum;*/
           /* maas.setNext(kefilKontrol);
            kefilKontrol.setNext(kredi);
            kredi.setNext(gecikmeKontrol);

            maas.Operasyon(customer);

            if (gecikmeKontrol.durum)
            {
                Console.WriteLine("işlemler başarılı");
            }
            else
            {
                Console.WriteLine("işlemleer başarısız");
            }*/
            
            //KrediTest();
            //Player();
        }

       /* private static void KrediTest()
        {
            List<Kredi> kredi = new List<Kredi>();
            kredi.Add(new ChechKBBScore());
            kredi.Add(new CreditCart());

            kredi[0].Next = kredi[1];
            kredi[0].SomeOperation();

            bool creditConfirm = kredi[kredi.Count - 1].CreditConfirmed;
            if (creditConfirm)
            {
                Console.WriteLine("kredi başarılı");
            }
            else
            {
                Console.WriteLine("kredi başarısız");
            }
        }*/

             /* private static void Player()
                {
                    PlayerHandler mp4 = new Mp4();
                    PlayerHandler mpg = new Mpg();
                    PlayerHandler avi = new Avi();

                    mp4.setNext(mpg);
                    mpg.setNext(avi);

                    mp4.Play("selam.avi");
                    mp4.Play("deniz_baykal.mp4");
                    mp4.Play("enterSandman.mpg");
                    mp4.Play("selami.swf");
                }*/
    }
    




    

   


   
}
