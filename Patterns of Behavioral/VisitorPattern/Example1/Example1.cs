using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Example1
{
    abstract class Tablet
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Tablet(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public abstract void Accept(IVisitor visitor);
    }
    interface IVisitor
    {
        void Visit(Galaxy galaxy);
        void Visit(Ipad ipad);
    }
    class Wifi : IVisitor
    {
        public void Visit(Galaxy galaxy)
        {
            Console.WriteLine(galaxy.Name + " wifi acildi");
        }

        public void Visit(Ipad ipad)
        {
            Console.WriteLine(ipad.Name + " wifi mevcut değil");
        }
    }
    class ThreeG : IVisitor
    {
        public void Visit(Galaxy galaxy)
        {
            Console.WriteLine(galaxy.Name + " 3g mevcut değil");
        }

        public void Visit(Ipad ipad)
        {
            Console.WriteLine(ipad.Name + " 3g acildi");
        }
    }

    class Ipad : Tablet
    {
        public Ipad(string name, string model) : base(name, model)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Galaxy : Tablet
    {
        public Galaxy(string name, string model) : base(name, model)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
