using System;

// File: EmployeeProps.cs
public partial class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// File: EmployeeMethods.cs
public partial class Employee
{
    public void PerformWork()
    {
        Console.WriteLine("Employee performing his work");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Employee taking the Leave ");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.EmployeeId = 101;
        emp.FirstName = "John";
        emp.LastName = "Doe";
        Console.WriteLine(
            $" Employee id {emp.EmployeeId} Employee name {emp.FirstName} {emp.LastName}"
        );
        emp.PerformWork();
        emp.TakeBreak();
    }
}
