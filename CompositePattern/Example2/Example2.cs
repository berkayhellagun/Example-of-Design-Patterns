using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Example2
{
    abstract class Component
    {
        public Component()
        {

        }

        public abstract string Operation();

        public virtual void Add(Component component)
        {

        }

        public virtual void Remove(Component component)
        {

        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
    class Leaf : Component
    {
        public override string Operation()
        {
            return "leaf calisti";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }

    class Composite : Component
    {
        List<Component> components = new List<Component>();

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in components)
            {
                result += component.Operation();
                if (i != components.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }


    }
}
