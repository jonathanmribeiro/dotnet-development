namespace ChainOfResponsibilityDesignPattern.BaseExample
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
            => _nextHandler = handler;

        public virtual object? Handle(object request)
            => _nextHandler?.Handle(request);
    }
}
