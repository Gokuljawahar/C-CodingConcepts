using System;

public class Rectangle
{
    // Fields
    private double _width;
    private double _height;

    // Constructor
    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    // Methods
    public double CalculateArea()
    {
        return _width * _height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (_width + _height);
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Width: {_width}");
        Console.WriteLine($"Height: {_height}");
        Console.WriteLine($"Area : {CalculateArea()}");
        //Console.WriteLine($"Area: ");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Rectangle class
        Rectangle rectangle = new Rectangle(5.0, 3.0);

        // Call the methods
        // double area = rectangle.CalculateArea();
        // double perimeter = rectangle.CalculatePerimeter();

        rectangle.PrintDetails();
    }
}
