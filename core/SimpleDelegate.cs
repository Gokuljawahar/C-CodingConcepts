using System;
public delegate void SimpleDelegate(string message,int a);

class Program
{
    static void Main()
    {

        SimpleDelegate del2 = PrintMessage;
        del2("jsdskajdk",1);
        SimpleDelegate del = PrintMessage;
        del("Hello from delegate!",0);
    }

    static void PrintMessage(string message , int a)
    {
        Console.WriteLine($"{message}  {a}");
    }
    
}


   
        
    
