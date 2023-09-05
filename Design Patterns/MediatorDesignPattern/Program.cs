﻿using MediatorDesignPattern.BaseExample.Components;
using MediatorDesignPattern.BaseExample.Mediator;

BaseExample();

static void BaseExample()
{
    Component1 component1 = new();
    Component2 component2 = new();
    _ = new ConcreteMediator(component1, component2);

    Console.WriteLine("Client triggers operation A.");
    component1.DoA();

    Console.WriteLine();

    Console.WriteLine("Client triggers operation D.");
    component2.DoD();
}
