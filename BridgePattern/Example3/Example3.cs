using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example3
{
    abstract class DbAbstration
    {
        protected IDbImplementor dbImplementor;

        public IDbImplementor DbImplementor
        {
            set { dbImplementor = value; }
        }

        public abstract void ConOpen();
        public abstract void Exec();
    }

    class DbRefined : DbAbstration
    {
        public override void ConOpen()
        {
            dbImplementor.OpenCon();
        }
        public override void Exec()
        {
            dbImplementor.Execute();
        }
    }



    interface IDbImplementor
    {
        void Execute();
        void OpenCon();
    }

    class Sql : IDbImplementor
    {
        public void Execute()
        {
            Console.WriteLine("sql execute");
        }

        public void OpenCon()
        {
            Console.WriteLine("sql opencon");
        }
    }
    class Oracle : IDbImplementor
    {
        public void Execute()
        {
            Console.WriteLine("oracle execute");
        }

        public void OpenCon()
        {
            Console.WriteLine("oracle opencon");
        }
    }
}
