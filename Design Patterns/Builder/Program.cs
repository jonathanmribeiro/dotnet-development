using Builder.AnimalsExample;
using Builder.AnimalsExample.Builders;
using Builder.BaseExample;

Console.WriteLine("Base Examples:\n");
BaseExample();

Console.WriteLine("\nAnimalExamples:\n");
AnimalExample();

void BaseExample()
{
    var director = new Director();
    var builder = new ConcreteBuilder();

    director.Builder = builder;

    Console.WriteLine("Standard basic product:");
    director.BuildMinimalViableProduct();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("Standard full featured product:");
    director.BuildFullFeaturedProduct();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("Custom product:");
    builder.BuildPartA();
    builder.BuildPartC();
    Console.Write(builder.GetProduct().ListParts());
}

void AnimalExample()
{
    ElephantBuilder elephantBuilder = new();
    AnimalsDirector director = new(elephantBuilder);
    director.BuildFullAnimal();
    Console.WriteLine(elephantBuilder.Animal.Name);
    Console.WriteLine(elephantBuilder.Animal.Weight.ToString());

    LionBuilder lionBuilder = new();
    director = new(lionBuilder);
    director.BuildNamelessAnimal();
    Console.WriteLine(lionBuilder.Animal.Name);
    Console.WriteLine(lionBuilder.Animal.Weight.ToString());
}