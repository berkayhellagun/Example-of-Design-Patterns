using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Example4
{
    interface ILoger
    {
        void LogAt(string logl);
    }

    class DatabaseLogger : ILoger
    {
        public void LogAt(string logl)
        {
            Console.WriteLine(logl + "database loglandı");
        }
    }
    class FileLoger : ILoger
    {
        public void LogAt(string logl)
        {
            Console.WriteLine(logl + "file loglandı");
        }
    }

    class LoggerAdapter : ILoger
    {
        ThirdPartyLogger _thirdParty;

        public LoggerAdapter()
        {
            _thirdParty = new ThirdPartyLogger();
        }

        public void LogAt(string logl)
        {
            _thirdParty.LoglamaYap(logl);
        }
    }

    class ThirdPartyLogger
    {
        public void LoglamaYap(string logItem)
        {
            Console.WriteLine(logItem + "3.party logged");
        }
    }
}
