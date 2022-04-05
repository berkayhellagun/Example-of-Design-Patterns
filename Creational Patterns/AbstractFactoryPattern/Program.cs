using AbstractFactoryPattern.Example1;
using AbstractFactoryPattern.Example2;

class Program
{
    static void Main(string[] args)
    {
        //Example1Test();
        Example2Test();
    }
    private static void Example1Test()
    {
        /*ConcreteA concreteA = new ConcreteA();
        ConcreteB concreteB = new ConcreteB();

        var res1=concreteA.GetProduct();

        var res2=concreteB.GetProductB();

        Console.WriteLine(res1);
        Console.WriteLine(res2);*/

        GenericFabrik forA = new GenericFabrik(new ConcreteA());
        forA.Yazdir();

        GenericFabrik forB = new GenericFabrik(new ConcreteB());
        forB.Yazdir();
    }

    private static void Example2Test()
    {
        GenericFabrika mercedes = new GenericFabrika(new Mercedes(), new Lassa(), new EngineA());
        mercedes.Yazdir();

        GenericFabrika fiat = new GenericFabrika(new Fiat(), new Lassa(), new EngineB());
        fiat.Yazdir();
    }
}

