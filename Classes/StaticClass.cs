using System;

public static class MathHelper
{
    public static double PI = 3.14159;

    public static double CalculateCircleArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculateCirclePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double radius = 5.0;

        double area = MathHelper.CalculateCircleArea(radius);
        double perimeter = MathHelper.CalculateCirclePerimeter(radius);

        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
    }
}
