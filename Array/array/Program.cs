using System;
using ArrayDisplaying;
using ArrayMaxValueMinValue;
using ArraySummation;

namespace MainProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            ArrayPrint.Print(a);
            ArraySum.Sum(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ArrayMaxandMin.ArrayMax(a));
            Console.WriteLine(ArrayMaxandMin.ArrayMin(a));
        }
    }
}
