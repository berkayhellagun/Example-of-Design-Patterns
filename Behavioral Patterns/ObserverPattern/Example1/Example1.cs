using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example1
{
    interface IObserver
    {
        void Update(ISubject subject);
    }

    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("concreteobservera reacted");
            }
        }
    }
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            var sub = subject as Subject;
            if (sub.State == 0 || sub.State >= 2)
            {
                Console.WriteLine("concreteobserverb reacted");
            }
        }
    }


    interface ISubject
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }

    class Subject : ISubject
    {
        public int State { get; set; } = 0;
        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            Console.WriteLine("add");
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void Remove(IObserver observer)
        {
            Console.WriteLine("removed");
            observers.Remove(observer);
        }
    }
}
