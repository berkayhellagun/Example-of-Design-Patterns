using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Example1
{
    class Director
    {
        public void Uret(IBuilder builder)
        {
            builder.SetModel();
            builder.SetMarka();
            builder.SetKM();
            builder.SetVites();
        }
    }

    //Product classı
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Vites { get; set; }
        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vites olarak üretilmiştir.";
        }
    }

    //builder class
    abstract class IBuilder
    {
        protected Araba araba;
        public Araba ReturnEdici
        {
            get { return araba; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }

    //builder concrete yapaan class
    class OpelConcrete : IBuilder
    {
        public OpelConcrete()
        {
            araba = new Araba();
        }

        public override void SetKM()
        {
            araba.KM = 100;
        }

        public override void SetMarka()
        {
            araba.Marka = "Opel";
        }

        public override void SetModel()
        {
            araba.Model = "Astra";
        }

        public override void SetVites()
        {
            araba.Vites = true;
        }
    }
}
