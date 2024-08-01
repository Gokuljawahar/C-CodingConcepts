using System;
public class Program
{
    enum Level 
    { 
        Low, 
        Medium, 
        High 
    }

    public static void Main()
    {
        Level myLevel = Level.Medium;
        Level myLevel2 = Level.High;
        Level myLevel3 = Level.Low;


        Console.WriteLine(myLevel);


        switch(myLevel)
        {
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium level");
                break;
            case Level.High:
                Console.WriteLine("High level");
                break;
        }
    }
}
