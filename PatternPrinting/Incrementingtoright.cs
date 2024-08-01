// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows;

// public class patternprinting
// {
//     public static void Main(string[] args)
//     {

//         /*
//         *
//         ***
//         *****
//         ******
//         *******/


//         /*
//                *
//               **
//              ***
//             ****
//            *****
//           ******
//         */

//         int size;

//         try
//         {
//             size = int.Parse(Console.ReadLine());

//             for (int i = 1; i <= size; i++)   // base condition 
//             {

//                 for (int j = 1; j <= i; j++)
//                 {

//                     Console.Write(j);

//                 }
//                 Console.WriteLine('\n');


//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }

//     }
// }

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the triangle: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
