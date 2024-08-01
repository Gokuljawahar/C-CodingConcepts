using System;

public class Shape
{
    public virtual void Draw(string s)
    {
        Console.WriteLine($"Performing base class drawing tasks  for {s}");
    }
}

public class Circle : Shape
{
    public override void Draw(string s1)
    {
        Console.WriteLine($"Drawing a circle {s1}");
        base.Draw("Different types of shapes");
    }
}

public class Rectangle : Shape
{
    public override void Draw(string s2)
    {
        Console.WriteLine($"Drawing a Rectangle {s2}");
    }
}

public class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.Draw("Rectangle");
        Circle c = new Circle();
        c.Draw("circle ");
    }
}
