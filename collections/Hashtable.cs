using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
static class Program{
    static void Main(string[] args){
        Hashtable hashTable = new Hashtable();
        hashTable.Add(1, "jds");
        foreach(DictionaryEntry ht in hashTable ){
            Console.WriteLine($"{ht.Key} {ht.Value}"); 
        }
    }
}
