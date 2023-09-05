namespace ChainOfResponsibilityDesignPattern.BaseExample
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object? Handle(object request);
    }
}
