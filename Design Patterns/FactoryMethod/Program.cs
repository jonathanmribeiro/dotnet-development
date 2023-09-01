using FactoryMethod.AnimalsExample.Creators;
using FactoryMethod.BaseExample.Creators;
using FactoryMethod.GameCharactersExample.Creators;
using FactoryMethod.GameCharactersExample.Products;

Console.WriteLine("Running base examples:");
BaseExample();

Console.WriteLine("\nRunning animals examples:");
AnimalsExample();

Console.WriteLine("\nRunning game characters examples:");
GameCharactersExample();

void BaseExample()
{
    var creator = new ConcreteCreator1();
    var operationResult = creator.SomeOperation();

    Console.WriteLine(operationResult);

    var creator2 = new ConcreteCreator2();
    operationResult = creator2.SomeOperation();

    Console.WriteLine(operationResult);
}

void AnimalsExample()
{
    var elephantCreator = new ElephantCreator();
    var lionCreator = new LionCreator();
    var penguinCreator = new PenguinCreator();

    Console.WriteLine(elephantCreator.MakeSound());
    Console.WriteLine(lionCreator.MakeSound());
    Console.WriteLine(penguinCreator.MakeSound());
}

void GameCharactersExample()
{
    var archerFactory = new ArcherFactory();
    var mageFactory = new MageFactory();
    var warriorFactory = new WarriorFactory();

    ICharacter gameCharacter;

    gameCharacter = archerFactory.ObtainCharacter();
    Console.WriteLine($"The character class is {gameCharacter.Name} wich have {gameCharacter.Health} points of health");
    
    gameCharacter = mageFactory.ObtainCharacter();
    Console.WriteLine($"The character class is {gameCharacter.Name} wich have {gameCharacter.Health} points of health");
    
    gameCharacter = warriorFactory.ObtainCharacter();
    Console.WriteLine($"The character class is {gameCharacter.Name} wich have {gameCharacter.Health} points of health");
}