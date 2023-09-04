using Adapter.AnimalsExample;
using Adapter.BaseExample;

BaseExample();

Console.WriteLine("\n");

AnimalsExample();

static void BaseExample()
{
    Adaptee adaptee = new();
    ITarget target = new BaseExampleAdapter(adaptee);

    Console.WriteLine("Adaptee interface is incompatible with the client");
    Console.WriteLine("But with adapter client can call it's method.");

    Console.WriteLine(target.GetRequest());

}

static void AnimalsExample()
{
    Lion lion = new();
    IAnimal adaptedLion = new LionAdapter(lion);

    Console.WriteLine("Client code expects an IAnimal:");
    adaptedLion.MakeSound();

    Console.WriteLine("\nDirectly accessing the Lion class:");
    lion.Roar();
}