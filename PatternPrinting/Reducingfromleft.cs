using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class patternprinting
{
    public static void Main(string[] args)
    {

        /*******
        *******
        ******
        ****
        **
        */


        int size;

        try
        {
            size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)   // base condition 
            {

                for (int j = i; j <= size; j++)  // print condition 
                {

                    Console.Write("*");
                }
                Console.WriteLine('\n');
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}