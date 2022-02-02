using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example1
{
    class GenericFabrik
    {
        private IConcrete _concrete;
        private IProductA _productA;
        private IProductB _productB;

        public GenericFabrik(IConcrete concrete)
        {
            _concrete = concrete;
            _productA = _concrete.GetProduct();
            _productB = _concrete.GetProductB();
        }

        public void Yazdir()
        {
            var result1 = _productA.Deneme();
            var resukt2 = _productB.Deneme2();
            Console.WriteLine(result1 + " " + resukt2);
        }
    }

    interface IConcrete
    {
        IProductA GetProduct();
        IProductB GetProductB();
    }

    class ConcreteA : IConcrete
    {
        public IProductA GetProduct()
        {
            return new ConcreteProductA();
        }

        public IProductB GetProductB()
        {
            return new ConcreteProductB();
        }
    }

    class ConcreteB : IConcrete
    {
        public IProductA GetProduct()
        {
            return new ConcreteProductA2();
        }

        public IProductB GetProductB()
        {
            return new ConcreteProductB2();
        }
    }

    interface IProductA
    {
        string Deneme();
    }

    interface IProductB
    {
        string Deneme2();
    }

    class ConcreteProductA : IProductA
    {
        public string Deneme()
        {
            return "concrete product a";
        }
    }

    class ConcreteProductA2 : IProductA
    {
        public string Deneme()
        {
            return "concrete product a2";
        }
    }

    class ConcreteProductB : IProductB
    {
        public string Deneme2()
        {
            return "concrete product b";
        }
    }

    class ConcreteProductB2 : IProductB
    {
        public string Deneme2()
        {
            return "concrete product b2";
        }
    }
}
