
using System;
using System.Collections.Generic;
using System.Collections;
class sampleclass
{


    static void Main(string[] args)
    {


        ArrayList intlist = new ArrayList();
        int count;
        Console.WriteLine("Enter the total number of element");
        count = Convert.ToInt32(Console.ReadLine());
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine("Enter the elements");
            int value = Convert.ToInt32(Console.ReadLine());

            intlist.Add(value);

        }
        foreach (int l in intlist)
        {
            Console.WriteLine(l + " ");
        }


        // List<int> newlist = new List<int>();

        // Console.WriteLine(newlist.Count);

        // newlist.AddRange(intlist);

      


        // Console.WriteLine($" the total element in the new list {newlist.Capacity}");

        // Console.WriteLine($"the total elements in the list is {intlist.Capacity}");
    }

}