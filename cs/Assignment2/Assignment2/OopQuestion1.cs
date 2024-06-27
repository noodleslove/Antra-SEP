namespace Assignment2;

// Abstract base class demonstrating Abstraction
public abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void MakeSound();

    // Encapsulation: Private fields with public properties
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method demonstrating Abstraction
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Derived class demonstrating Inheritance
public class Dog : Animal
{
    // Constructor that calls the base class constructor
    public Dog(string name, int age) : base(name, age) { }

    // Overriding the abstract method demonstrating Polymorphism
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

// Derived class demonstrating Inheritance
public class Cat : Animal
{
    // Constructor that calls the base class constructor
    public Cat(string name, int age) : base(name, age) { }

    // Overriding the abstract method demonstrating Polymorphism
    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}