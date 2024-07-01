// See https://aka.ms/new-console-template for more information
using AbstractFactory = DesignPatterns.AbstractFactory;
using Builder = DesignPatterns.Builder;
using FactoryMethod = DesignPatterns.FactoryMethod;
using Prototype = DesignPatterns.Prototype;

// Console.WriteLine("==== Abstract Factory ====");
// new AbstractFactory.Client().Main();
// Console.WriteLine();

// Console.WriteLine("==== Builder ====");
// new Builder.Client().Main();
// Console.WriteLine();

// Console.WriteLine("==== Factory Method ====");
// new FactoryMethod.Client().Main();
// Console.WriteLine();

Console.WriteLine("==== Prototype ====");
new Prototype.Client().Main();
Console.WriteLine();
