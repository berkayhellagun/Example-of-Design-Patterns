public class MailAyarlari
{
	private static MailAyarlari nesne;
	private static Ayar ayar = new Ayar();

	private MailAyarlari()
	{
	}

	public static MailAyarlari getMailAyarlari()
	{
		if (nesne == null)
		{
			nesne = new MailAyarlari();
		}
		return nesne;
	}
	public static void ayarla(Kutu mailKutusu, Kutu mailIcerigi, Kutu basliklar)
	{
		ayar = new Ayar(mailKutusu, mailIcerigi, basliklar);
	}
	public static void ayarlariGetir()
	{
        Console.WriteLine(ayar.toString());
	}
}


public class Kutu
{
	String isim;
	String konum;
	int boyut;

	public Kutu(String isim, String konum, int boyut)
	{
		this.isim = isim;
		this.konum = konum;
		this.boyut = boyut;
	}
	public Kutu()
	{

	}
	public String getIsim()
	{
		return isim;
	}

	public void setIsim(String isim)
	{
		this.isim = isim;
	}

	public String getKonum()
	{
		return konum;
	}

	public void setKonum(String konum)
	{
		this.konum = konum;
	}

	public int getBoyut()
	{
		return boyut;
	}

	public void setBoyut(int boyut)
	{
		this.boyut = boyut;
	}
	
	public String toString()
	{
		return "Kutu [isim=" + isim + ", konum=" + konum + ", boyut=" + boyut + "]";
	}
}

public class Ayar
{
	Kutu mailKutusu;
	Kutu mailicerigi;
	Kutu baslıklar;
	public Ayar(Kutu mailKutusu, Kutu mailicerigi, Kutu baslıklar)
	{
		
		this.mailKutusu = mailKutusu;
		this.mailicerigi = mailicerigi;
		this.baslıklar = baslıklar;
	}

	public Ayar()
	{

	}

	public Kutu getMailKutusu()
	{
		return mailKutusu;
	}
	
	public void setMailKutusu(Kutu mailKutusu)
	{
		this.mailKutusu = mailKutusu;
	}
	
	public Kutu getMailicerigi()
	{
		return mailicerigi;
	}
	
	public void setMailicerigi(Kutu mailicerigi)
	{
		this.mailicerigi = mailicerigi;
	}
	
	public Kutu getBaslıklar()
	{
		return baslıklar;
	}
	
	public void setBaslıklar(Kutu baslıklar)
	{
		this.baslıklar = baslıklar;
	}

	public String toString()
	{
		return "Ayar [mailKutusu=" + mailKutusu + ", mailicerigi=" + mailicerigi + ", baslıklar=" + baslıklar + "]";
	}
}