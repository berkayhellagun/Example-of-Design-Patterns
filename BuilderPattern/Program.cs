class Program
{
    static void Main(string[] args)
    {
        /*IBuilder builder=new OpelConcrete();
        Director director = new Director();
        director.Uret(builder);

        Console.WriteLine(builder.ReturnEdici.ToString());*/

        /*PromosyonBuilder isci = new IsciConcrete();
        PromosyonBuilder amir=new AmilerConcrete();

        Director director = new Director();
        director.Gonder(isci);

        Console.WriteLine(isci.RetunEdici.ToString());*/

        YemekBuilder sulu = new SuluYemek();
        YemekYapici yapici = new YemekYapici();
        yapici.YemekYap(sulu);
        Console.WriteLine(sulu.YemekReturn.ToString());
    }
}
