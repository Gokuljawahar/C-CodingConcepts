using System;

class operation
{
    public int totalSum()
    {
        return 0;
    }

    public int totalSum(int a)
    {
        return a;
    }

    public int totalSum(int a, int b)
    {
        return a + b;
    }

    public float totalSum(float a, float b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        operation o = new operation();
        Console.WriteLine(o.totalSum());
        Console.WriteLine(o.totalSum(1, 2));
    }
}
