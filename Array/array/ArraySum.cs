using System;

namespace ArraySummation
{
    public class ArraySum
    {
        public static void Sum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}