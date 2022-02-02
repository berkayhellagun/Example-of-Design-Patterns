using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RemoteController:IRemoteControllerService
    {
        private IRemoteControllerService _remoteControllerService;

        public RemoteController(IRemoteControllerService remoteControllerService)
        {
            _remoteControllerService = remoteControllerService;
        }
        public void On(Product product) => _remoteControllerService.On(product);
        public void Off(Product product) => _remoteControllerService.Off(product);
    }
}
