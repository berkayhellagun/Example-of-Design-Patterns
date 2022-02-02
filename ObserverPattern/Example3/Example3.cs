using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example3
{
    class Customer
    {
        public string _name;
        public long _no;
        protected List<IObserver> izlemciler = new List<IObserver>();
        public int _time;

        public Customer(string name, long no)
        {
            _name = name;
            _no = no;
            _time = 0;
        }
        public int Time
        {
            set { _time = value; }
        }

        public void Add(IObserver observer)
        {
            izlemciler.Add(observer);
        }
        public void Delete(IObserver observer)
        {
            izlemciler.Remove(observer);
        }

        public void TimeControl()
        {
            int gecenZaman = 2;
            if (_time > gecenZaman)
            {
                Notify();
            }
        }

        private void Notify()
        {
            foreach (IObserver observer in izlemciler)
            {
                observer.Update(this);
            }
        }

    }

    interface IObserver
    {
        void Update(Customer customer);
    }

    class MakeCampaign : IObserver
    {
        public void Update(Customer customer)
        {
            Console.WriteLine(customer._name + " e kampanya gönderildi geçerli telefon numarası: " + customer._no);
        }
    }
    class SendCredit : IObserver
    {
        public void Update(Customer customer)
        {
            Console.WriteLine(customer._name + " e kontör gönderildi geçerli telefon numarası: " + customer._no);

        }
    }
}
