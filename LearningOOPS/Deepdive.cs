using System;
class Program
{
    // Main method with string[] args parameter
     static void Main(string[] args)
     {
        Console.WriteLine("Number of arguments: " + args.Length);
        
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Argument {i}: {args[i]}");
        }
        // Check if any arguments were passed
        if (args.Length > 0)
        {
            Console.WriteLine("Command-line arguments:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        else
        {
            Console.WriteLine("No command-line arguments were provided.");
        }    
    }
}
