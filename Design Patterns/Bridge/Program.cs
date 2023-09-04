using Bridge.AnimalsExample;
using Bridge.BaseExample;

BaseExample();
Console.WriteLine("\n");
AnimalsExample();

static void BaseExample()
{
    Client client = new();
    Abstraction abstraction;

    abstraction = new Abstraction(new ConcreteImplementationA());
    client.ClientCode(abstraction);

    abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
    client.ClientCode(abstraction);
}

static void AnimalsExample()
{
    IAction jumpAction = new JumpAction();
    IAction eatAction = new EatAction();

    AbstractAnimal dog = new Dog(jumpAction);
    AbstractAnimal cat = new Cat(eatAction);

    dog.MakeSound();
    cat.MakeSound();
}