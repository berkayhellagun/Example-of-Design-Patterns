using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IRemoteControllerService
    {
        void On(Product product);
        void Off(Product product);
    }
}
