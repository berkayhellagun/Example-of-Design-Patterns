using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example6
{
    abstract class Observable
    {
        List<IObserver> izlemciler = new List<IObserver>();

        public void Add(IObserver observer)
        {
            izlemciler.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            izlemciler.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in izlemciler)
            {
                observer.Update(this);
            }
        }
    }

    class Urun1 : Observable
    {
        public int _fiyat = 100;
        public int Fiyat
        {
            get { return _fiyat; }
            set
            {
                _fiyat = value;
            }
        }
        public void Kontrol()
        {
            var deger = _fiyat - _fiyat / 2;
            if (deger < 50)
            {
                Notify();
            }
        }
    }

    class Urun2 : Observable
    {
        public bool _stok = false;
        public bool Stok
        {
            get { return _stok; }
            set
            {
                _stok = value;
                if (_stok)
                {
                    Notify();
                }
            }
        }
    }

    interface IObserver
    {
        void Add(Observable observable);
        void Delete(Observable observable);
        void Update(Observable observable);
    }
    class Berkay : IObserver
    {
        List<Observable> ürünler = new List<Observable>();

        public void Add(Observable observable)
        {
            ürünler.Add(observable);
            observable.Add(this);
        }

        public void Delete(Observable observable)
        {
            ürünler.Remove(observable);
            observable.Remove(this);
        }

        public List<Observable> GetProd()
        {
            return ürünler;
        }

        public void Update(Observable observable)
        {
            Console.WriteLine("üründe değişiklik var");
        }
    }
}
