using System;

class Program
{
    static void Main(string[] args)
    {
        // Static typing
        int num = 10;
        Console.WriteLine("Static Typing:");
        Console.WriteLine("Type of num: " + num.GetType().Name);
        Console.WriteLine("Value of num: " + num);

        // Dynamic typing
        dynamic data = 20;
        Console.WriteLine("\nDynamic Typing:");
        Console.WriteLine("Type of data before changing: " + data.GetType().Name);
        Console.WriteLine("Value of data before changing: " + data);

        // Changing the type and value of 'data'
        data = "Hello, World!";
        Console.WriteLine("\nType of data after changing: " + data.GetType().Name);
        Console.WriteLine("Value of data after changing: " + data);
    }
}
