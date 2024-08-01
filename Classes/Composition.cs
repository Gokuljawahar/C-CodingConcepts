using System;

// Define the Ceiling class
public class Ceiling
{
    public string BuildCeiling()
    {
        return "Building ceiling...";
    }
}

// Define the Floor class
public class Floor
{
    public string BuildFloor()
    {
        return "Building floor...";
    }
}

// Define the House class
public class House
{
    // The House class has-a Ceiling and Floor
    private readonly Ceiling _ceiling;
    private readonly Floor _floor;

    public House()
    {
        _ceiling = new Ceiling();
        _floor = new Floor();
    }

    public void BuildHouse()
    {
        Console.WriteLine(_ceiling.BuildCeiling());
        Console.WriteLine(_floor.BuildFloor());
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create a House object
        House house = new House();

        // Build the house
        house.BuildHouse();
    }
}
