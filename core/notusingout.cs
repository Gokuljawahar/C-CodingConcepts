

using System;

class Program
{
    // Method without 'out' parameter
    static int CalculateQuotient(int dividend, int divisor)
    {
        return dividend / divisor;
    }

    static void Main()
    {
        int dividend = 42;
        int divisor = 5;

        // Calculate quotient directly
        int quotient = CalculateQuotient(dividend, divisor);

        Console.WriteLine($"Quotient (without 'out'): {quotient}");
    }
}
