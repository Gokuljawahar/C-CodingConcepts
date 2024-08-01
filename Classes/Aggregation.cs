using System;

// Define the Engine class
public class Engine
{
    public string Model { get; set; }

    public Engine(string model)
    {
        this.Model = model;
    }

    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

// Define the Car class
public class Car
{
    // The Car class has a reference to an object of the Engine class
    private Engine engine;

    public Car(Engine engine)
    {
        this.engine = engine;
    }

    public void Drive()
    {
        this.engine.Start();
        Console.WriteLine("Car is driving");
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create an Engine object
        Engine engine = new Engine("V8");

        // Create a Car object with the Engine object
        Car car = new Car(engine);

        // Drive the car
        car.Drive();
    }
}
