using System;
class fieldclass{

 
    private int _myField; // Private field
         
         public int MyProperty
         {
             get { return _myField; } // Getter
             set { _myField = value; } // Setter
         }
         public int AnotherProperty { get; set; }

         public int AnotherProperty2{set;}

         

}

public class program{

    public static void Main(string[] args) {
    fieldclass fc = new fieldclass();
    Console.WriteLine(fc.MyProperty = 1);
    fc.AnotherProperty = 1;
    Console.WriteLine(fc.AnotherProperty);
    Console.WriteLine(fc.AnotherProperty2=1);
   // Console.WriteLine(fc._myField=1);
}
}