namespace DecoratorDesignPattern.BaseExample
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp) { }

        public override string Operation()
            => $"ConcreteDecoratorA({base.Operation()})";
    }
}
