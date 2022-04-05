using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Example3
{
    public abstract class Personel
    {
        public abstract void Accept(IRol rol);
    }

    public class OgretimUyesi : Personel
    {
        public override void Accept(IRol rol)
        {
            rol.Visit(this);
        }
    }

    public class OgretimGorevli : Personel
    {
        public override void Accept(IRol rol)
        {
            rol.Visit(this);
        }
    }
    public class ArastirmaGorevli : Personel
    {
        public override void Accept(IRol rol)
        {
            rol.Visit(this);
        }
    }

    public interface IRol
    {
        public void Visit(OgretimGorevli ogretimGorevli);
        public void Visit(OgretimUyesi ogretimUyesi);
        public void Visit(ArastirmaGorevli arastirmaGorevli);
    }

    public class Staj : IRol
    {
        public void Visit(OgretimGorevli ogretimGorevli)
        {
            Console.WriteLine("ogretim görevli staj notu verdi");
        }

        public void Visit(OgretimUyesi ogretimUyesi)
        {
            Console.WriteLine("ogretim uyesi stajla ilgili bir şey yapamaz");
        }

        public void Visit(ArastirmaGorevli arastirmaGorevli)
        {
            throw new NotImplementedException();
        }
    }
}
