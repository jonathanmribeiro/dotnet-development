namespace MediatorDesignPattern.BaseExample.Mediator
{
    internal interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
