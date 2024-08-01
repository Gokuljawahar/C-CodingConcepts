using System;

class Program
{
    static void ModifyReference(ref int y)
    {
        y += 10; // Modifies the original 'y'
        Console.WriteLine(y);
    }

    static void Main()
    {
        int value = 5;
        ModifyReference(ref value);
        Console.WriteLine($"Modified value after call by reference: {value}");
    }
}
