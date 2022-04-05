using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Example1
{
    class Total
    {
        IMaasHesap _maasHesap;
        IIzınHesap _ızınHesap;

        public void setMaas(IMaasHesap maasHesap)
        {
            _maasHesap = maasHesap;
        }
        public void setIzın(IIzınHesap ızınHesap)
        {
            _ızınHesap = ızınHesap;
        }

        public void Maas()
        {
            Console.WriteLine(_maasHesap.MaasHesapla());
        }
        public void Izın()
        {
            Console.WriteLine(_ızınHesap.IzınHesapla());
        }
    }

    interface IMaasHesap
    {
        int MaasHesapla();
    }

    class MuhendisMaas : IMaasHesap
    {
        public int MaasHesapla()
        {
            return 100;
        }
    }

    class YoneticiMaas : IMaasHesap
    {
        public int MaasHesapla()
        {
            return 150;
        }
    }

    interface IIzınHesap
    {
        int IzınHesapla();
    }

    class DepartmanA : IIzınHesap
    {
        public int IzınHesapla()
        {
            return 15;
        }
    }
    class DepartmanB : IIzınHesap
    {
        public int IzınHesapla()
        {
            return 10;
        }
    }
}
