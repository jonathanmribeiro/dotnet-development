namespace Composite.BaseExample
{
    internal abstract class Component
    {
        protected Component() { }

        public abstract string Operation();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
