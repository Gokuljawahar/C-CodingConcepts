using System;
using System.Collections.Generic;
using System.Linq;
interface IDisplayable
{
    void Display();
    
}

interface ILoggable
{
    void Log();
}

class MyClass : IDisplayable, ILoggable
{
    public void Display()
    {
        Console.WriteLine("Displaying data...");
    }

    public void Log()
    {
        Console.WriteLine("Logging data...");
    }
}

class program
{
    public static void Main(string[] args){
    // Usage:
    MyClass obj = new MyClass();
    obj.Display();
obj.Log();
}

}