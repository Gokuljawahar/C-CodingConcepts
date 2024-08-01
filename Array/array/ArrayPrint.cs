using System;

namespace ArrayDisplaying
{
    public class ArrayPrint
    {
        public static void Print(int[] array)
        {
            foreach (int nums in array)
            {
                Console.WriteLine(nums);
            }

        }
    }
}