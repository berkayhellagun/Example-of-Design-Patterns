using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Example3
{
    class YemekYapici
    {
        public void YemekYap(YemekBuilder yemek)
        {
            yemek.SetAdi();
            yemek.SetTipi();
            yemek.SetTuz();
        }
    }

    class Yemek
    {
        public bool Tuz { get; set; }
        public string Adi { get; set; }
        public string Tipi { get; set; }
        public override string ToString()
        {
            return $"{Tuz} tuz değerli , {Adi} adlı yemeek , {Tipi} ne aittir";
        }
    }

    abstract class YemekBuilder
    {
        protected Yemek yemek;

        public Yemek YemekReturn
        {
            get { return yemek; }
        }

        public abstract void SetTuz();
        public abstract void SetAdi();
        public abstract void SetTipi();
    }

    class Sebzeli : YemekBuilder
    {
        public Sebzeli()
        {
            yemek = new Yemek();
        }

        public override void SetAdi()
        {
            yemek.Adi = "salata";
        }

        public override void SetTipi()
        {
            yemek.Tipi = "sebzeli";
        }

        public override void SetTuz()
        {
            yemek.Tuz = false;
        }
    }

    class SuluYemek : YemekBuilder
    {
        public SuluYemek()
        {
            yemek = new Yemek();
        }
        public override void SetAdi()
        {
            yemek.Adi = "kurufasulye";
        }

        public override void SetTipi()
        {
            yemek.Tipi = "sulu";
        }

        public override void SetTuz()
        {
            yemek.Tuz = true;
        }
    }
}
