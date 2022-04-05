using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite general = new Composite("berkay", rank.General);
            Composite colonel = new Composite("ibo", rank.Colonel);
            Leaf liet = new Leaf("oroospu sahil", rank.Lieutenant);
            Leaf de = new Leaf("da", rank.Lieutenant);

            general.Add(colonel);
            general.Add(liet);
            general.Add(de);

            Console.WriteLine(general.ExcuteOrder());
            //Test1();
        }

        /* private static void Test1()
         {
             CompositeDealer genelMudur = new CompositeDealer();
             CompositeDealer icAnadoluMudur = new CompositeDealer();
             CompositeDealer ankaraBolgesi = new CompositeDealer();
             CompositeDealer sivasBolgesi = new CompositeDealer();

             CompositeDealer ankara1 = new CompositeDealer();
             CompositeDealer ankara2 = new CompositeDealer();
             CompositeDealer sivas1 = new CompositeDealer();

             ankara1.Add(new WorkingPerson());
             ankara1.Add(new WorkingPerson());
             ankara1.Add(new WorkingPerson());

             ankara2.Add(new WorkingPerson());
             ankara2.Add(new WorkingPerson());

             sivas1.Add(new WorkingPerson());

             ankaraBolgesi.Add(ankara1);
             ankaraBolgesi.Add(ankara2);

             sivasBolgesi.Add(sivas1);
             icAnadoluMudur.Add(ankaraBolgesi);
             icAnadoluMudur.Add(sivasBolgesi);
             genelMudur.Add(icAnadoluMudur);

             Console.WriteLine("ankara 1 maaş : " + ankara1.GetCost());
             Console.WriteLine("ankara2 maaş : " + ankara2.GetCost());
             Console.WriteLine("ankara bölgesi total : " + ankaraBolgesi.GetCost());
             Console.WriteLine("sivas1 maaş : " + sivas1.GetCost());
             Console.WriteLine("sivas bölge : " + sivasBolgesi.GetCost());
             Console.WriteLine("ic anadolu : " + icAnadoluMudur.GetCost());
             Console.WriteLine("genel : " + genelMudur.GetCost());
         }
     }*/
    }
}

