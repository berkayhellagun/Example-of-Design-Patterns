using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example4
{
    class Ekstra
    {
        protected IKargo _kargo;
        public IKargo Kargo
        {
            set { _kargo = value; }
        }

        public virtual void YeniOzellik()
        {
            _kargo.KragoGonder();
        }
    }

    class AnlasmaliKargo : Ekstra
    {
        public override void YeniOzellik()
        {
            base.YeniOzellik();
        }
    }

    interface IKargo
    {
        void KragoGonder();
    }

    class PesinOdeme : IKargo
    {
        public void KragoGonder()
        {
            Console.WriteLine("pesin ödemeli kargo gönderildi");
        }
    }
    class KarsiOdeme : IKargo
    {
        public void KragoGonder()
        {
            Console.WriteLine("karşı ödemeli kargo gönderildi");
        }
    }
}
