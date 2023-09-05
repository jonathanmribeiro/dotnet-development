using CommandDesignPattern.AnimalsExample;
using CommandDesignPattern.AnimalsExample.Commands;
using CommandDesignPattern.BaseExample;
using CommandDesignPattern.BaseExample.Commands;

BaseExample();

Console.WriteLine();

AnimalsExample();

static void BaseExample()
{
    Invoker invoker = new();
    invoker.SetOnStart(new SimpleCommand("Say Hi!"));

    Receiver receiver = new();
    invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

    invoker.DoSomethingImportant();
}

static void AnimalsExample()
{
    AnimalReceiver dog = new("Dog");
    AnimalReceiver cat = new("Cat");

    IAnimalCommand feedDog = new FeedCommand(dog);
    IAnimalCommand groomCat = new GroomCommand(cat);
    IAnimalCommand trainDog = new TrainCommand(dog);

    AnimalInvoker invoker = new();

    invoker.AddCommand(feedDog);
    invoker.AddCommand(groomCat);
    invoker.AddCommand(trainDog);

    invoker.ExecuteCommands();
}