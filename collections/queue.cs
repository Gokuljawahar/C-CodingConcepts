using System;
using System.Collections;
using System.Collections.Generic;
public class queuepractice{


    public static void Main(){



        Queue<string> qu = new Queue<string>();
         
         
        int no = int.Parse((Console.ReadLine()));
        for(int i = 0; i < no ; i++){
            string value = Console.ReadLine();
            qu.Enqueue(value);

        }
        Console.WriteLine( "-------------------------------------------------------");
        
     
        foreach(var q in qu){
            Console.WriteLine(q);
        }
    }
}