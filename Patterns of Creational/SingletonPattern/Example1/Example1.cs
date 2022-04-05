using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Example1
{
    public class Dock
    {
        private static Dock nesne = new Dock();
        private static object kilit = new object();
        private Random rnd = new Random();
        private List<string> sunucular = new List<string>();


        protected Dock()
        {
            sunucular.Add("1.sunucu");
            sunucular.Add("2.sunucu");
            sunucular.Add("3.sunucu");
            sunucular.Add("4.sunucu");
            sunucular.Add("5.sunucu");
        }

        public static Dock DengeleyiciGetir()
        {
            if (nesne == null)
            {
                lock (kilit)
                {
                    if (nesne == null)
                    {
                        nesne = new Dock();
                    }
                }
            }
            return nesne;
        }
        public string Sunucu
        {
            get
            {
                int r = rnd.Next(sunucular.Count);
                return sunucular[r].ToString();
            }
        }
    }
}

