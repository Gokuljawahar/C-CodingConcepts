using System;

namespace codepractice
{
    static class solveclass
    {
        public static long biginit(long input)
        {
            long large = 0; // Initialize `large` to negative infinity
            long temp = input; // Initialize `temp` to the input value

            while (temp > 0)
            {
                long rem = temp % 10;
                if (rem > large)
                {
                    large = rem;
                }
                temp = temp / 10; // Update `temp` by integer division
            }

            return large;
        }

        public static long sumofindividualint(long input)
        {
            long sum = 0;
            long temp = input;

            while (temp > 0)
            {
                long rem = temp % 10;
                sum += rem;
                temp = temp / 10;
            }

            return sum;
        }

        public static long reversenum(long input)
        {
            long rem = 0;
            while (input > 0)
            {
                long digit = input % 10;
                rem = rem * 10 + digit;
                input = input / 10;
            }
            return rem;
        }



        // public static long reversenum(long input)
        // {
        //     long rem = 0;
        //     while (input > 0)
        //     {
        //         input = input % 10;
        //         rem = rem * 10 + input;
        //         input = input / 10;
        //     }
        //     return rem;
        // }
    }

    static class mainclass
    {
        public static void Main(string[] args)
        {
            long num = Convert.ToInt64(Console.ReadLine());

            long result = solveclass.biginit(num);
            long result2 = solveclass.sumofindividualint(num);
            long result3 = solveclass.reversenum(num);
            Console.WriteLine($"The largest digit in {num} is {result}.");
            Console.WriteLine($"The sum of all the individual digits in {num} is {result2}.");
            Console.WriteLine($"The sum of all the individual digits in {num} is {result3}.");
        }
    }
}
