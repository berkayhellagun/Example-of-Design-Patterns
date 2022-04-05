using System;
using System.Collections.Generic;

namespace CompositeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("john","manager");
            Developer a = new Developer("selami", "developer");
            manager.Add(a);
            manager.WorkerDetail();
        }
    }
    //component
    public abstract class Worker
    {
        protected string _name;
        protected string _mission;

        public Worker(string name,string mission)
        {
            _name = name;
            _mission = mission;
        }
        public abstract void WorkerDetail();
    }

    //composite
    public class Manager : Worker
    {
        private List<Worker> calisanlar = new List<Worker>();
        public Manager(string name, string mission) : base(name, mission)
        {

        }

        public void Add(Worker t)
        {
            calisanlar.Add(t);
        }

        public void Delete(Worker t)
        {
            calisanlar.Remove(t);
        }
        public override void WorkerDetail()
        {
            Console.WriteLine("Yonetici : "+_name + "- "+ _mission);
            foreach (Worker item in calisanlar)
            {
                item.WorkerDetail();
            }
        }
    }

    public class Developer : Worker
    {
        public Developer(string name,string mission):base(name,mission)
        {

        }
        public override void WorkerDetail()
        {
            Console.WriteLine("Developer : " + _name +"-"+ _mission);
        }
    }
    public class Designer : Worker
    {
        public Designer(string name,string mission):base(name,mission)
        {
        }
        public override void WorkerDetail()
        {
            Console.WriteLine("Designer : " + _name + "- "+ _mission);
        }
    }

}

