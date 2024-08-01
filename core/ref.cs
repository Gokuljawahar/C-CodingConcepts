using System;
public class RefExample
{
    public int ModifyValue( ref int value)
    {
        // Modify the value directly
        return value += 10;
    }
}

class program
{

    public static void Main()
    {
        // Usage
        int number = 5;
        RefExample refExample = new RefExample();
        Console.WriteLine(refExample.ModifyValue ( ref number));
        Console.WriteLine($"Modified value using ref: {number}");
    }// Output: Modified value using ref: 15

}
