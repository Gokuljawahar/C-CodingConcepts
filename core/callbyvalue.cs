// using System;
// class program{


//     // public static int square(int a){
         
//     //      int result = a*a;
//     //      return result;
//     // }


//     public  int refsquare(ref int a){
//         int result =a*a;
//         return  result;
//     }


//    static void Main(string[] args)
// {
//     int realval = 11;

//     // Console.WriteLine(program.square(realval));
//     // Console.WriteLine(realval);


//     program p = new program();
//     // Use 'ref' when calling refsquare
//     // Console.WriteLine(program.refsquare(ref realval));
//     // Console.WriteLine(realval);

//     Console.WriteLine(p.refsquare(ref realval));
//     Console.WriteLine(realval);
// }
// }


using System;

class Program
{
    static void ModifyValue(int x)
    {
        x += 10; // Modifies the local copy of 'x'
        Console.WriteLine(x);
        
        
    }

    static void Main()
    {
        int number = 5;
        ModifyValue(number);
        
        Console.WriteLine($"Original value after call by value: {number}");
    }
}


