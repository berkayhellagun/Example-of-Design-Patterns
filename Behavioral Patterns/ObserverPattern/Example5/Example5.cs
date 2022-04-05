using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example5
{
    abstract class Youtube
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

    class BarisOzcan : Youtube
    {
        public string name = "Baris";
        public bool VideoStatus = false;

        public bool Status
        {
            get { return VideoStatus; }
            set { VideoStatus = value; }
        }

        public void VideoDurumu()
        {
            if (VideoStatus)
            {
                base.Notify();
            }
        }
    }

    interface IObserver
    {
        void Update(Youtube youtube);
    }

    class Ben : IObserver
    {
        public string _name;
        public Ben(string name)
        {
            _name = name;
        }

        public void Update(Youtube youtube)
        {
            BarisOzcan baris = (BarisOzcan)youtube;
            Console.WriteLine("Değerli " + _name + " " + baris.name + " yeni video ekledi");
        }
    }

    class Annem : IObserver
    {
        public string _name;
        public Annem(string name)
        {
            _name = name;
        }
        public void Update(Youtube youtube)
        {
            BarisOzcan baris = (BarisOzcan)youtube;
            Console.WriteLine("Değerli " + _name + " " + baris.name + " yeni video ekledi");
        }
    }
}
