using System;

namespace biseler
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = new EntityManager(new OrderEntity());
            entityManager.Serialize();
        }
    }
}
