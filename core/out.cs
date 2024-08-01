using System;

class Program
{
    public static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }

    static void Main()
    {
        int dividend = 42;
        int divisor = 5;
        int resultQuotient, resultRemainder;

        Divide(dividend, divisor, out resultQuotient, out resultRemainder);

        Console.WriteLine($"Quotient: {resultQuotient}, Remainder: {resultRemainder}");
    }
}
