namespace ChainOfResponsibilityDesignPattern.BaseExample.ConcreteHandlers
{
    internal class SquirrelHandler : AbstractHandler
    {
        public override object? Handle(object request)
            => request.ToString().Equals("Nut")
                ? $"Squirrel: I'll eat the {request}.\n"
                : base.Handle(request);
    }
}
