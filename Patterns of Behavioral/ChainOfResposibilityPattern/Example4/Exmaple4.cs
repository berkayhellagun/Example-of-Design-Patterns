using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.Example4
{
    abstract class Handler
    {
        public Handler _next;

        public void setNext(Handler handler)
        {
            _next = handler;
        }

        public virtual object Handle(object request)
        {
            if (_next != null)
            {
                return _next.Handle(request);
            }
            else
            {
                Console.WriteLine("invalid food no animal to find ate this food");
                return null;
            }
        }
    }

    class Monkey : Handler
    {
        public override object Handle(object request)
        {
            if (request as String == "banana")
            {
                return "monkey yedi muzu";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Dog : Handler
    {
        public override object Handle(object request)
        {
            if (request as String == "beef")
            {
                return "dog eaten beef";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Squirre : Handler
    {
        public override object Handle(object request)
        {
            if (request as String == "nut")
            {
                return "squirre eaten nut";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
