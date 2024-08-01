using System;
class Program
{
    static void Main(string[] args)
    {
        // Boxing
        int num = 123;  // A value type
        object boxed = num;  // Boxing

        Console.WriteLine("Boxing:");
        Console.WriteLine("The value-type value = {0}", num);
        Console.WriteLine("The object-type value = {0}", boxed);

        // Unboxing
        int unboxed = (int)boxed;  // Unboxing

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("The unboxed value = {0}", unboxed);
    }
}
