using System;

namespace SomeClassLibrary
{
    public class Class1
    {
        public int X;
        private int Y;

        public int P1 { get; set; }
        private int P2 { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method1 Invoked");
        }

        private void Method2()
        {
            Console.WriteLine("Method2 Invoked");
        }
    }
}
