using System;
// using System.Reflection;

public class Program
{
    public static void Main()
    {
        // Get the Type information.
        Type type = typeof(System.String);

        // Print the full name of the type
        Console.WriteLine("Full Name: " + type.FullName);

        // Print the namespace of the type
        Console.WriteLine("Namespace: " + type.Namespace);

        // Print the name of the assembly that contains the type
        Console.WriteLine("Assembly: " + type.Assembly);
    }
}
