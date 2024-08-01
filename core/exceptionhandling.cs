// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             // Code that may throw an exception
//             int[] numbers = { 1, 2, 3 };
//             Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
//         }
//         catch (Exception ex)
//         {
//             // Code to handle the exception
//             Console.WriteLine($"An exception occurred: {ex.Message}");
//         }
//     }
// }


using System;

class Program
{
    static void Main()
    {
        
        try
        {
            // Code that may throw an exception
            int[] numbers = {  2, 3 ,2};
            Console.WriteLine((numbers[2]/numbers[0])/2.0); // This will throw an IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            // Code to handle the exception
            Console.WriteLine($"An exception occurred: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            // Code to handle the exception
            Console.WriteLine($"An exception occurred: {ex.Message}");
        }
        catch(Exception ex)
        {
            // Code to handle the exception
            Console.WriteLine($"An exception occurred: {ex.Message}");
        }
        finally
        {
            // Code that will always execute, regardless of whether an exception is thrown
            Console.WriteLine("This block is always executed.");
        }
    }
}
