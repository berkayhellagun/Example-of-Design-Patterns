using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example1
{
    class Soket
    {
        public int _port;
        public ISoketState _state;

        public Soket(int soket)
        {
            _port = soket;
            State = new Acik();
        }
        public ISoketState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Do()
        {
            _state.Handle(this);
        }
    }

    interface ISoketState
    {
        void Handle(Soket soket);
    }

    class Acik : ISoketState
    {
        public void Handle(Soket soket)
        {
            Console.WriteLine(soket._port + " acildi");
            soket.State = new Dinlen();
        }
    }

    class Dinlen : ISoketState
    {
        public void Handle(Soket soket)
        {
            Console.WriteLine(soket._port + " dinlenmeye alındı");
            soket.State = new Kapat();
        }
    }

    class Kapat : ISoketState
    {
        public void Handle(Soket soket)
        {
            Console.WriteLine(soket._port + " kapatıldı");
            soket.State = new Acik();
        }
    }
}
