using System;
using System.Collections.Generic;

class Simple
{
    public static void Main()
    {
        Dictionary<int, string> Dict = new Dictionary<int, string>();

        Console.Write("Enter the number of entries you want to add: ");
        int numEntries = int.Parse(Console.ReadLine());

        for (int i = 0; i < numEntries; i++)
        {
            Console.Write("Enter key: ");
            int key = int.Parse(Console.ReadLine());

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            Dict.Add(key, value);
        }
        // Print the dictionary
        foreach (KeyValuePair<int, string> item in Dict)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}
