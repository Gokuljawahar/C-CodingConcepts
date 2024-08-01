


using System;


class baseclass{
     public int i{get; set; };
     public float b{get; set ;};

     public int I{

        get { return i; }
        set { i = value; }

     }


     public float B{
        get { return b; }
        set { b = value; }
     }

     string name;
     public virtual int basemethod(int i , float b) { 
        return i;

     }
}

partial class derivedclass: baseclass{

    public sealed override int basemethod(int i , float b){
        return i;
    }


}


class program {


     public static void Main(string[] args) {


        derivedclass d = new derivedclass();
        d.i=1;
        
        d.b = 2;
    
        Console.WriteLine($" { d.i } {d.b}");
        Console.WriteLine( d.basemethod(12,2));

     }
}