﻿namespace Composite.BaseExample
{
    internal class Composite : Component
    {
        protected List<Component> _children = new();

        public override void Add(Component component)
            => _children.Add(component);

        public override void Remove(Component component)
            => _children.Remove(component);

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in _children)
            {
                if (i != _children.Count - 1)
                {
                    result += "+";
                }

                i++;
            }

            return result + ")";
        }
    }
}
