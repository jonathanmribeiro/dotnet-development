namespace DecoratorDesignPattern.BaseExample
{
    internal class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp) { }

        public override string Operation()
            => $"ConcreteDecoratorB({base.Operation()})";
    }
}
