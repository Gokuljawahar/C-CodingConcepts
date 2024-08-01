using System;

// Base Class
class Person
{
    public string Name { get; set; }
    public int AadharId { get; set; }
    public int Age { get; set; }

    public Person(int aadharId, int age, string name)
    {
        AadharId = aadharId;
        Age = age;
        Name = name;
    }
}

// Derived Class: Teacher
class Teacher : Person
{
    public Teacher(int aadharId, int age, string name) : base(aadharId, age, name)
    {
        
    }

    public void TeacherDetails()
    {
        Console.WriteLine($"Teacher: {Name}, Aadhar ID: {AadharId}, Age: {Age}");
    }
}

// Derived Class: Doctor
class Doctor : Person
{
    public Doctor(int aadharId, int age, string name) : base(aadharId, age, name)
    {
    }

    public void DoctorDetails()
    {
        Console.WriteLine($"Doctor: {Name}, Aadhar ID: {AadharId}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher(123, 35, "John");
        teacher.TeacherDetails();

        Doctor doctor = new Doctor(456, 40, "Dr. Smith");
        doctor.DoctorDetails();
    }
}
