using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.Example5
{

    public class Kargo
    {
        public bool alinma { get; set; }
        public bool tasima { get; set; }
        public bool dagitim { get; set; }
        public bool teslim { get; set; }
    }

    abstract class Handler
    {
        protected Handler _next;
        public bool durum;

        public void setNext(Handler handler)
        {
            _next = handler;
        }

        public void Progress(Kargo kargo)
        {
            Execute(kargo);
            if (durum)
            {
                if (_next != null)
                {
                    _next.durum = durum;
                    _next.Progress(kargo);
                }
            }
        }
        public abstract void Execute(Kargo kargo);
    }

    class Alınma : Handler
    {
        public override void Execute(Kargo kargo)
        {
            if (kargo.alinma)
            {
                durum = true;
            }
            else
            {
                Console.WriteLine("kargo henüz alınmadı");
                durum = false;
            }
        }
    }

    class Taşıma : Handler
    {
        public override void Execute(Kargo kargo)
        {
            if (durum)
            {
                if (kargo.tasima)
                {
                    durum = true;
                }
                else
                {
                    Console.WriteLine("kargo taşıma esnasında");
                    durum = false;
                }
            }

        }
    }

    class Dağıtım : Handler
    {
        public override void Execute(Kargo kargo)
        {
            if (durum)
            {
                if (kargo.dagitim)
                {
                    durum = true;
                }
                else
                {
                    Console.WriteLine("dağıtıma henüz çıkmadı");
                    durum = false;
                }

            }
        }
    }

    class Teslim : Handler
    {
        public override void Execute(Kargo kargo)
        {
            if (durum)
            {
                if (kargo.teslim)
                {
                    durum = true;
                }
                else
                {
                    Console.WriteLine("henüz teslim edilmedi");
                    durum = false;
                }
            }
        }
    }
}
