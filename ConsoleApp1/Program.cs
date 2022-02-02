using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() {name="tv",id=1 };
            RemoteController remoteController = new RemoteController(new RemoteManager());
            remoteController.On(product);
            remoteController.Off(product);
        }
    }
}
