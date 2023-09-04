using DecoratorDesignPattern.AnimalsExample.BaseComponent;
using DecoratorDesignPattern.AnimalsExample.ConcreteComponents;
using DecoratorDesignPattern.AnimalsExample.ConcreteDecorators;
using DecoratorDesignPattern.BaseExample;

BaseExample();

Console.WriteLine();

AnimalsExample();
static void BaseExample()
{
    Client client = new();

    var simple = new ConcreteComponent();

    Console.WriteLine("Client: I get a simple component:");
    client.ClientCode(simple);
    Console.WriteLine();

    ConcreteDecoratorA decorator1 = new(simple);
    ConcreteDecoratorB decorator2 = new(decorator1);
    Console.WriteLine("Client: Now I've got a decorated component:");
    client.ClientCode(decorator2);
}

static void AnimalsExample()
{
    IAnimal dog = new Dog();
    IAnimal cat = new Cat();

    Console.WriteLine("Basic Animals:");
    Console.WriteLine($"{dog.Name}:");
    dog.MakeSound();

    Console.WriteLine($"{cat.Name}:");
    cat.MakeSound();

    IAnimal flyingDog = new FlyingAnimalDecorator(dog);
    IAnimal swimmingCat = new SwimmingAnimalDecorator(cat);

    Console.WriteLine("\nDecorated Animals:");
    Console.WriteLine($"{flyingDog.Name}:");
    flyingDog.MakeSound();
    ((FlyingAnimalDecorator)flyingDog).Fly();

    Console.WriteLine($"{swimmingCat.Name}:");
    swimmingCat.MakeSound();
    ((SwimmingAnimalDecorator)swimmingCat).Swim();
}
