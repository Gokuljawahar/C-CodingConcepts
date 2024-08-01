using System;

namespace ClassPractice
{
    public class Person
    {
        public int age;
        public string name;
        public string gender;

        private long phoneno;

        public long Phoneno
        {
            set { phoneno = value; }
            get { return phoneno; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person();
            Console.WriteLine(person.age = 11);
            Console.WriteLine(person.name = "praveen ");
            Console.WriteLine(person.gender = "male ");
            // Console.WriteLine(person.phoneno=1121211);
            person.Phoneno = 11111;
            Console.WriteLine(person.Phoneno);
        }
    }
}
