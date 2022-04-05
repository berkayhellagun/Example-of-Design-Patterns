using System;

public class Program
{

    static void Main(string[] args)
    {
        generic tot = new generic(new DBFinder(), new Web());
        tot.bas("ağaç");

        Dictionary<string, string> keys = new Dictionary<string, string>();
        keys.Add("london", "england");
        var deger = keys["london"];
        System.Console.WriteLine(deger);
    }
}

public class generic
{
    IFinder _finder;
    IRenderer _render;
    public generic(IFinder finder, IRenderer renderer)
    {
        _finder = finder;
        _render = renderer;
    }
    public void bas(string name)
    {
        _render.Display(_finder.Find(name));
    }
}

public interface IFinder
{
    string Find(string name);
}
public class DBFinder : IFinder
{
    public string Find(string name)
    {
        return name + "isimli ürün db de bulundu";
    }
}
public class wsFinder : IFinder
{
    public string Find(string name)
    {
        return name + "isimli ürün ws de bulundu";
    }
}
public interface IRenderer
{
    void Display(string content);
}
public class Console : IRenderer
{
    public void Display(string content)
    {
        System.Console.WriteLine(content + "konsola basıldı");
    }
}
public class Web : IRenderer
{
    public void Display(string content)
    {
        System.Console.WriteLine(content + "webe yazıldı");
    }
}


