using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example2
{
    abstract class absUrun
    {
        private string _isim;
        protected int _fiyat;

        public List<IObserver> izleyiciler = new List<IObserver>();
        public List<IObserver> favoriler = new List<IObserver>();

        public absUrun(string name, int fiyat)
        {
            _fiyat = fiyat;
            _isim = name;
        }
        public int Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (_fiyat > value)
                {
                    Notify();
                    _fiyat = value;
                }
            }
        }
        public void Favori(IObserver observer)
        {
            favoriler.Add(observer);

        }

        public void Add(IObserver observer)
        {
            izleyiciler.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            Uyelik(observer);
            izleyiciler.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in izleyiciler)
            {
                observer.Update(this);
            }
        }
        public void Uyelik(IObserver observer)
        {
            observer.Silindi();
        }

    }

    class Urun : absUrun
    {
        public Urun(string name, int fiyat) : base(name, fiyat)
        {
        }

    }

    interface IObserver
    {
        void Update(absUrun urun);
        void Silindi();
    }

    class Uye : IObserver
    {
        public string _eMail;

        public Uye(string email)
        {
            _eMail = email;
        }

        public void Update(absUrun urun)
        {
            Console.WriteLine(_eMail + " adresine yeni fiyat bilgisi" + " iletildi. Yeni fiyat : " + urun.Fiyat);
        }

        public void Silindi()
        {
            Console.WriteLine(_eMail + " adresine ait üyelik silindi .");
        }
    }
}
