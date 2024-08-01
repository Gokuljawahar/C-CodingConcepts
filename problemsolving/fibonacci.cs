using System;
using System.Collections.Generic;
using System.Collections;
class fibo
{

    static int fib(int x)
    {
        if (x <= 2)
        {
            return 1;
        }
        else
        {
            return fib(x - 1) + fib(x - 2);
        }
    }
    public static void Main(String[] args)
    {

        int val = int.Parse(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=val; i++)
        {
            Console.WriteLine(fibo.fib(i));
        }

    }
}