using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun1 urun1 = new Urun1();
            Urun2 urun2 = new Urun2();


            Berkay mehtap = new Berkay();
            Berkay berkay = new Berkay();
            
            
            
            mehtap.Add(urun1);
            mehtap.Add(urun2);

            urun2.Stok = true;
            foreach (var item in mehtap.GetProd())
            {
                Console.WriteLine(item);
            }
            
        }
    }
}    