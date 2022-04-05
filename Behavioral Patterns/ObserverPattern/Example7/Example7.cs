using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example7
{
    abstract class ISubject
    {
        public abstract void Register(Observer observer);
        public abstract void Deregister(Observer observer);
        public abstract void NotifyObservers();
        public abstract void UpdatePrice(int eskiFiyat, int yeniFiyat);
    }

    class Product1 : ISubject
    {
        private int _Fiyat;
        public int fiyat
        {
            get { return _Fiyat; }
            set
            {
                _Fiyat = value;
                NotifyObservers();
            }
        }
        List<Observer> _observers = new List<Observer>();

        public override void Register(Observer observer)
        {
            _observers.Add(observer);
        }
        public override void Deregister(Observer observer)
        {
            _observers.Remove(observer);
        }

        public override void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                UpdatePrice(100, 50);
                observer.Update();
                Console.WriteLine();
            }
        }

        public override void UpdatePrice(int eskiFiyat, int yeniFiyat)
        {
            if (yeniFiyat <= eskiFiyat / 2)
            {
                Console.WriteLine("Product1 : Hemen al ve %50 indirimden faydalan. Bu fırsatı kaçırma");

            }
        }
    }

    class Product2 : ISubject
    {
        private int _Fiyat;
        public int fiyat
        {
            get { return _Fiyat; }
            set
            {
                _Fiyat = value;
                NotifyObservers();
            }
        }
        List<Observer> _observers = new List<Observer>();

        public override void Register(Observer observer)
        {
            _observers.Add(observer);
        }
        public override void Deregister(Observer observer)
        {
            _observers.Remove(observer);
        }

        public override void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                UpdatePrice(100, 80);
                observer.Update();
                Console.WriteLine();
            }
        }

        public override void UpdatePrice(int eskiFiyat, int yeniFiyat)
        {
            if (yeniFiyat <= eskiFiyat / 2)
            {
                Console.WriteLine("Product2 : Hemen al ve %50 indirimden faydalan. Bu fırsatı kaçırma");

            }
        }
    }


    abstract class Observer
    {
        public abstract void Update();
        public abstract void FavoriEkle(ISubject product);
    }

    class ConcreteObserver1 : Observer
    {
        List<ISubject> favoriler = new List<ISubject>();
        public override void FavoriEkle(ISubject product)
        {
            favoriler.Add(product);
            product.Register(this);
        }

        public override void Update()
        {
            Console.WriteLine("ConcreteObserver1 : Ürünümüz şimdi indirimde");
        }
    }

    class ConcreteObserver2 : Observer
    {
        List<ISubject> favoriler = new List<ISubject>();
        public override void FavoriEkle(ISubject product)
        {
            favoriler.Add(product);
            product.Register(this);
        }

        public override void Update()
        {
            Console.WriteLine("ConcreteObserver1 : Ürünümüz şimdi indirimde");
        }
    }


}
*/
}
