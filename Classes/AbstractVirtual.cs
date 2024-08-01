using System;

public abstract class Animal
{
    public string Name { get; set; }

    //public string description {get; set;}

    public abstract void MakeSound();

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public string type(string description)
    {
        return description;
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public new string type(string description)
    {
        return description;
    }

    public override void Eat()
    {
        //base.Eat();
        base.Eat();
        Console.WriteLine("Dog is eating.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public new string type(string description)
    {
        return description;
    }

    public override void Eat()
    {
        //base.Eat();
        Console.WriteLine("Cat is eating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "mani";
        Console.WriteLine(dog.type("jdkjskd"));

        dog.MakeSound(); // Woof!
        dog.Eat(); // Buddy is eating. Dog is eating.

        Cat cat = new Cat();

        Console.WriteLine(cat.type("jdkjskd"));
        cat.Name = "Whiskers";
        cat.MakeSound(); // Meow!
        cat.Eat(); // Whiskers is eating. Cat is eating.
    }
}
