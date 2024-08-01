using System;

class Animal
{
    public int sample;
    public string sameple2;

    public float sample3;

    public void run()
    {
        Console.WriteLine("animal runs");
    }

    public virtual void sampleabstractmethod()
    {
        Console.WriteLine("in the base class");
    }

    public void eat()
    {
        Console.WriteLine("animal eats");
    }
}

// base class

class Dog : Animal
{
    public void sleep()
    {
        Console.WriteLine("animal sleeps");
    }

    public override void sampleabstractmethod()
    {
        base.sampleabstractmethod();
        Console.WriteLine("override in derived class");
    }
}

// derived class
class ProgramP
{
    static void Main()
    {
        Dog d = new Dog();
        d.run();
        d.sampleabstractmethod();

        Animal a = new Animal();
        a.sampleabstractmethod();
    }
}
