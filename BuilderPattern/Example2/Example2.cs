using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Example2
{
    class Director
    {
        public void Gonder(PromosyonBuilder promosyon)
        {
            promosyon.SetPromosyonAdi();
            promosyon.SetUrunAdi();
            promosyon.CalisanAdi();
        }
    }

    class Promosyon
    {
        public string UrunAdi { get; set; }
        public string PromosyonAdi { get; set; }
        public string CalisanProfili { get; set; }

        public override string ToString()
        {
            return $"{UrunAdi} adlı ürün {PromosyonAdi} uygulanarak {CalisanProfili} ne gönderildi.";
        }
    }

    abstract class PromosyonBuilder
    {
        protected Promosyon promosyon;

        public Promosyon RetunEdici
        {
            get { return promosyon; }
        }
        public abstract void SetUrunAdi();
        public abstract void SetPromosyonAdi();
        public abstract void CalisanAdi();
    }

    class AmilerConcrete : PromosyonBuilder
    {
        public AmilerConcrete()
        {
            promosyon = new Promosyon();
        }

        public override void CalisanAdi()
        {
            promosyon.CalisanProfili = "Amir";
        }

        public override void SetPromosyonAdi()
        {
            promosyon.PromosyonAdi = "ilk siparişe özel indirim";
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "her ürün";
        }
    }

    class IsciConcrete : PromosyonBuilder
    {
        public IsciConcrete()
        {
            promosyon = new Promosyon();
        }

        public override void CalisanAdi()
        {
            promosyon.CalisanProfili = "Emekçi";
        }

        public override void SetPromosyonAdi()
        {
            promosyon.PromosyonAdi = "her şey ücretsiz";
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "tüm ürünlerde geçerli";
        }
    }
}
