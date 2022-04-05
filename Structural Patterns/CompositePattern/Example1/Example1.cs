using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Example1
{
    abstract class Worker
    {
        public abstract int GetCost();
    }

    class WorkingPerson : Worker
    {
        public override int GetCost()
        {
            return 25;
        }
    }
    class CompositeDealer : Worker
    {
        List<Worker> worker = new List<Worker>();
        public CompositeDealer()
        {

        }
        public void Add(Worker worke)
        {
            worker.Add(worke);
        }
        public override int GetCost()
        {
            var result = 0;
            foreach (Worker work in worker)
            {
                result += work.GetCost();
            }
            return result;
        }
    }
}
