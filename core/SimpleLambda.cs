using System;
class Program
{
    static void Main()
    {
        // Using a lambda expression with a delegate
        SimpleDelegate del = (message) => Console.WriteLine(message);
        del("Hello from lambda!");

        // Using a lambda expression with LINQ
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
    }
}