using System;

namespace ConsoleApp1
{
    class RemoteManager : IRemoteControllerService
    {
        public void Off(Product product)
        {
            Console.WriteLine(product.name + " kapandı");
        }

        public void On(Product product)
        {
            Console.WriteLine(product.name + " açıldı");
        }
    }
}
