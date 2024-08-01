using System;
using System.Collections;
using System.Collections.Generic;
class simple
{

    public static void Main()
    {
        ArrayList lists = new ArrayList();
        lists.Add(1);
         lists.Add("sdkjsdkjs");
         lists.Add('a');
         


        foreach(var list in lists){
            Console.WriteLine(list);
        }
      



    }
}