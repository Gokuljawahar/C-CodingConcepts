using System;

public class Person
{
    // Fields
    private string _name;
    private int _age;

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Constructor
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Method
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Age: {_age}");
    }

    public void PrintDetailsforgetset(string name, int age)
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Saravanan", 32);
        p.PrintDetails();
        p.Age = 12;
        p.Name = "lakshmanan";
        p.PrintDetailsforgetset(p.Name = "lakshmanan", p.Age = 12);
    }
}
