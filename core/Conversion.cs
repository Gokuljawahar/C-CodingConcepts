using System;
class Program{
    static void Main(string[] args){

        int A = 10;
        double B = 10.20;
        float C = 11.2f;

        string  s1 = " google";
        string s2 = "23";

        B = A; //implciit casting
        A = (int)C;  //explicit casting 
        int cont = int.Parse(s2); // conversion
        int cont2 = Convert.ToInt32(s1);
        //Console.WriteLine(cont2);//compile time error 
        Console.WriteLine(cont);
        
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(A + B + C);
    }
}