namespace ChainOfResponsibilityDesignPattern.BaseExample.ConcreteHandlers
{
    internal class DogHandler : AbstractHandler
    {
        public override object? Handle(object request)
            => request.ToString().Equals("MeatBall")
                ? $"Dog: I'll eath the {request}.\n"
                : base.Handle(request);
    }
}
