using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example4
{
    abstract class Observable
    {
        List<IObserver> izlemciler;

        public Observable()
        {
            izlemciler = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            izlemciler.Add(observer);
        }

        public void Delete(IObserver observer)
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

    class Termometre : Observable
    {
        public decimal AnlikSicaklik;
        public decimal maxSicalik = 28;
        public decimal minSicalik = 20;

        public decimal Anlik
        {
            get { return AnlikSicaklik; }
            set { AnlikSicaklik = value; }
        }

        public void Tempature()
        {
            if (AnlikSicaklik > maxSicalik || AnlikSicaklik < minSicalik)
            {
                base.Notify();
            }
        }
    }

    interface IObserver
    {
        void Update(Observable observable);
    }

    class Ebeveyn : IObserver
    {
        public string _name;

        public Ebeveyn(string name)
        {
            _name = name;
        }

        public void Update(Observable observable)
        {
            Termometre termometre = (Termometre)observable;
            Console.WriteLine(_name + " kişisine sıcaklık değiştiği bilgisi verildi. Yeni sıcaklık :" + termometre.AnlikSicaklik);
        }
    }
}
