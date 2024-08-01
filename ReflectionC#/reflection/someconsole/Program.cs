using System;
using System.Reflection;
 

public class Program
{
    public static void Main()
    {
        // Load the assembly.
        Assembly assembly = Assembly.LoadFrom("SomeClassLibrary.dll");

        // Get all types within the assembly
        Type[] types = assembly.GetTypes();

        foreach (Type type in types)
        {
            Console.WriteLine("Type: " + type.FullName);

            // Get and display each method within each type.
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine("Method: " + method.Name);
            }

            // Get and display each property within each type.
            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine("Property: " + property.Name);
            }

            // Get and display each field within each type.
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine("Field: " + field.Name);
            }
        }
    }
}
