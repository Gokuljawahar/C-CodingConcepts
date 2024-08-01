using System.Collections.Generic;
using System;
using System.Collections;

public class sample2<T>{
    public int add( int a , int b) 
    
    {
       return a+ b ;
    }
    public float add( float a , float b) 
    
    {
       return a+ b ;
    }

}
public class sample{

    
    public static void Main(string[] args)
    {
        sample2<int> s = new sample2<int>();
        Console.WriteLine(s.add(2,1));
        
       
    }
}