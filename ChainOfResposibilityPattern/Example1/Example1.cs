using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.Example1
{
    abstract class PlayerHandler
    {
        protected PlayerHandler _next { get; set; }

        public void setNext(PlayerHandler playerHandler)
        {
            _next = playerHandler;
        }

        public virtual void Play(string filePath)
        {
            if (_next != null)
            {
                _next.Play(filePath);
            }
        }
    }

    class Mp4 : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine("mp4 calisti");
            }
            else
            {
                base.Play(filePath);
            }
        }
    }
    class Mpg : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mpg"))
            {
                Console.WriteLine("mpg olarak acildi");
            }
            else
            {
                base.Play(filePath);
            }
        }

    }
    class Avi : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".avi"))
            {
                Console.WriteLine("avi calisti");
            }
            else
            {
                Console.WriteLine("gecersiz video formatı");
            }
        }
    }
}
