using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Example2
{
    class Facade
    {
        Sistem1 _sistem1;
        Sistem2 _sistem2;
        TcKontrol _TcKontrol;
        public Facade()
        {
            _sistem1 = new Sistem1();
            _sistem2 = new Sistem2();
            _TcKontrol = new TcKontrol();
        }

        public void UyeEkle(string Tc)
        {
            if (_sistem1.KaraListeKontrol(Tc) && _TcKontrol.TcKontrolEt(Tc))
            {
                _sistem2.Uye(Tc);
            }
            else
            {
                Console.WriteLine("Geçersiz Tc No! ");
            }
        }
    }

    class Sistem1
    {
        public bool KaraListeKontrol(string Tc)
        {
            return true;
        }
    }

    class Sistem2
    {
        public void Uye(string Tc)
        {
            Console.WriteLine("Üyelik başarılı" + Tc);
        }
    }
    class TcKontrol
    {
        public bool TcKontrolEt(string Tc)
        {
            if (Tc.Length != 11)
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
