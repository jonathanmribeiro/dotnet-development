namespace ChainOfResponsibilityDesignPattern.BaseExample.ConcreteHandlers
{
    internal class MonkeyHandler : AbstractHandler
    {
        public override object? Handle(object request)
            => request.ToString().Equals("Banana")
                ? $"Monkey: I'll eat the {request}.\n"
                : base.Handle(request);
    }
}
