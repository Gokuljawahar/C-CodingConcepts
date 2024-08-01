using System;

public abstract class Shape
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public void PrintDetails(object name)
    {
        Console.WriteLine($"Area of {name}: {CalculateArea()}");
        Console.WriteLine($"Perimete of {name}r: {CalculatePerimeter()}");
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double CalculateArea()
    {
        return _width * _height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (_width + _height);
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5.0, 3.0);
        rectangle.PrintDetails(rectangle);

        Console.WriteLine();

        Circle circle = new Circle(4.0);
        circle.PrintDetails(circle);
    }
}
