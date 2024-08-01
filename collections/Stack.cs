using System;
using System.Collections;
using System.Collections.Generic;


public class stackexample{



    public static void Main(){


          Stack<int> s = new Stack<int>();
          s.Push(1);
          s.Push(2);
         
          int no = int.Parse(Console.ReadLine());
          for(int k =0 ; k < no ; k++){
              int value = int.Parse(Console.ReadLine());
              s.Push(value);
          }
          foreach(var ss in s){

             Console.WriteLine(ss);
          }

        Stack s2 = new Stack();
        s2.Push(1);
        


    }
}