using System;

class Animal
{
    // Fields (properties) in the base class
    public string Species { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Mammal : Animal
{
    // Additional field in the derived class
    public int NumberOfLegs { get; set; }

    public void Breathe()
    {
        Console.WriteLine("Mammal is breathing.");
    }
}

class Dog : Mammal
{
    // Specific field for Dog
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class program
{
    static void Main(string[] args)
    {
        // Usage
        Dog myDog = new Dog();
        myDog.Species = "Canine"; // Accessing the base class field
        myDog.NumberOfLegs = 4; // Accessing the derived class field
        myDog.Breed = "Golden Retriever"; // Accessing the specific Dog field
        myDog.Breathe();
        Console.WriteLine($"Species: {myDog.Species}");
        Console.WriteLine($"Legs: {myDog.NumberOfLegs}");
        Console.WriteLine($"Breed: {myDog.Breed}");
    }
}
// using System;


// class Animal
// {
//     public int sample;
//     public string sameple2;
//     public float sample3;
//     public void run()
//     {
//         Console.WriteLine("animal runs");
//     }
//     public virtual void sampleabstractmethod()
//     {
//         Console.WriteLine("in the base class");
//     }
//     public void eat()
//     {
//         Console.WriteLine("animal eats");
//     }




// }

// // base class

// class Dog : Animal
// {


//     public void sleep()
//     {

//         Console.WriteLine(
//           "animal sleeps"
//         );
//     }

//     public override void sampleabstractmethod()
//     {
//         base.sampleabstractmethod();
//         Console.WriteLine("override in derived class");
//     }
// }

// class lab : Dog{

//       sample=1;


// }


// // derived class
// class ProgramP
// {
//     static void Main()
//     {

//         Dog d = new Dog();
//         d.run();
//         d.sampleabstractmethod();

//         Animal a = new Animal();
//         a.sampleabstractmethod();

//         lab l = new lab();
//         l.Sample2="dog breed"

//         Console.WriteLine(l.Sample2);
//         Console.WriteLine(
//     }
// }
