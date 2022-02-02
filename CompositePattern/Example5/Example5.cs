using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Example5
{
    enum rank
    {
        General,
        Colonel,
        LieutenantColonel,
        Major,
        Captain,
        Lieutenant
    }

    abstract class Component
    {
        protected string _isim;
        protected rank _rank;

        public Component(string isim, rank derece)
        {
            _isim = isim;
            _rank = derece;
        }

        public abstract int ExcuteOrder();
    }

    class Composite : Component
    {
        List<Component> liste = new List<Component>();
        public Composite(string isim, rank derece) : base(isim, derece)
        {

        }

        public void Add(Component t)
        {
            liste.Add(t);
        }
        public void Remove(Component t)
        {
            liste.Add(t);
        }

        public override int ExcuteOrder()
        {
            var res = 0;
            Console.WriteLine(_rank + " " + _isim);
            foreach (Component item in liste)
            {
                res += item.ExcuteOrder();
            }
            return res;
        }

    }

    class Leaf : Component
    {
        public Leaf(string isim, rank derece) : base(isim, derece)
        {

        }

        public override int ExcuteOrder()
        {
            return 100;
        }

    }

}
}
