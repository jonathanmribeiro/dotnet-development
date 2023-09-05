using FlyweightDesignPattern.AnimalsExample.Factory;
using FlyweightDesignPattern.AnimalsExample.FlyweightInterface;
using FlyweightDesignPattern.BaseExample.Context;
using FlyweightDesignPattern.BaseExample.Factory;

BaseExample();

Console.WriteLine();

AnimalsExample();

static void BaseExample()
{
    var factory = new FlyweightFactory(
        new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
        new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
        new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
        new Car { Company = "BMW", Model = "M5", Color = "red" },
        new Car { Company = "BMW", Model = "X6", Color = "white" }
    );

    factory.ListFlyweights();

    AddCarToPoliceDatabase(factory, new Car
    {
        Number = "CL234IR",
        Owner = "James Doe",
        Company = "BMW",
        Model = "M5",
        Color = "red"
    });

    AddCarToPoliceDatabase(factory, new Car
    {
        Number = "CL234IR",
        Owner = "James Doe",
        Company = "BMW",
        Model = "X1",
        Color = "red"
    });

    factory.ListFlyweights();
}

static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
    Console.WriteLine("\nClient: Adding a car to database.");

    var flyweight = factory.GetFlyweight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyweight.Operation(car);
}

static void AnimalsExample()
{
    Zoo zoo = new();

    IAnimal lion = zoo.GetAnimal("lion");
    IAnimal elephant = zoo.GetAnimal("elephant");

    lion.Display("Simba", "Likes to sunbathe");
    elephant.Display("Dumbo", "Enjoys splashing in water");
}