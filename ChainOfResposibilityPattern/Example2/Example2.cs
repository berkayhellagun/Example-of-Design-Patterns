using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.Example2
{
    abstract class Kredi
    {
        protected Kredi _next { get; set; }
        public bool CreditConfirmed;
        public Kredi Next
        {
            set { _next = value; }
        }

        public void SomeOperation()
        {
            Operation();
            if (_next != null)
            {
                _next.CreditConfirmed = CreditConfirmed;
                _next.SomeOperation();
            }
        }
        public abstract void Operation();
    }

    class ChechKBBScore : Kredi
    {
        public override void Operation()
        {
            int kbb = 1200;
            if (kbb > 1000)
            {
                CreditConfirmed = true;
            }
            else
            {
                CreditConfirmed = false;
            }
        }
    }

    class CreditCart : Kredi
    {
        public override void Operation()
        {
            int paymenDelayTime = 1;
            if (CreditConfirmed)
            {
                if (paymenDelayTime > 3)
                {
                    CreditConfirmed = false;
                }
                else
                {
                    CreditConfirmed = true;
                }
            }
        }
    }
}
