using System;
enum Weekdays
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}
class Program
{
    static void Main(string[] args)

    {
        
        var sample = Weekdays.Sunday;
        Console.WriteLine("Name: " + sample);
        Console.WriteLine("Value: " + (int)sample);
        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
        {
            Console.WriteLine($"Name: {day}, Value: {(int)day}");
        }
    }


}

