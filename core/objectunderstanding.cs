using System;

//assigning a value type to reference type is called as boxing 
//assigning a reference type to a value type is called as unboxing 

class Program
{
    static void Main()
    {
        // Assigning a value type (int) to an object variable
        object obj1 = 42;
        Console.WriteLine($"obj1: {obj1}, Type: {obj1.GetType()}");

        // Assigning a reference type (string) to an object variable
        object obj2 = "Hello, World!";
        Console.WriteLine($"obj2: {obj2}, Type: {obj2.GetType()}");

        // Assigning a custom type (Person) to an object variable
        Person person = new Person { Name = "Alice", Age = 30 };
        object obj3 = person;
        Console.WriteLine($"obj3: {obj3}, Type: {obj3.GetType()}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}
