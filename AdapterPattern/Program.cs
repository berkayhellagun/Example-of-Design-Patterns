using AdapterPattern.Example1;
using AdapterPattern.Example2;
using AdapterPattern.Example4;
using AdapterPattern.Example5;

class Program
{
    static void Main(string[] args)
    {
        Example1Test();
        Example2Test();
        Example3Test();
        Example4Test();
        Example5Test();
    }

    private static void Example1Test()
    {
        Diktorgen dik = new Diktorgen();
        dik.degerAl(1, 2);
        Console.WriteLine(dik.AlanHesap());

        AdapterPattern.Example1.Adapter kare = new AdapterPattern.Example1.Adapter();
        kare.K = 2;
        Console.WriteLine(kare.AlanHesap());
    }

    private static void Example2Test()
    {
        Client client = new Client();
        client.OdenecekMeblag(new AdapterPattern.Example2.Adapter());
    }

    private static void Example3Test()
    {
        AdapterPattern.Example3.Adapter adapter=new AdapterPattern.Example3.Adapter();
        adapter.Siparis();
    }

    private static void Example4Test()
    {
        LoggerAdapter adapter = new LoggerAdapter();
        adapter.LogAt("deneme");
    }

    private static void Example5Test()
    {
        AdapterBatch adapter = new AdapterBatch();
        adapter.CreateFolder("c:\\desktop");
        adapter.CreateTextFile("c:\\desktop\\new folder");
        adapter.Copy("comp","c:\\");
    }
}

