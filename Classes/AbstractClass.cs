using System;

public abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public abstract decimal CalculateBonus();

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary:C}");
        Console.WriteLine($"Bonus: {CalculateBonus():C}");
    }
}

public class SalariedEmployee : Employee
{
    private decimal _bonusPercentage;

    public SalariedEmployee(string name, int age, decimal salary, decimal bonusPercentage)
    {
        Name = name;
        Age = age;
        Salary = salary;
        _bonusPercentage = bonusPercentage;
    }

    public override decimal CalculateBonus()
    {
        return Salary * _bonusPercentage;
    }
}

public class HourlyEmployee : Employee
{
    private decimal _hourlyRate;
    private int _hoursWorked;

    public HourlyEmployee(string name, int age, decimal hourlyRate, int hoursWorked)
    {
        Name = name;
        Age = age;
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }

    public override decimal CalculateBonus()
    {
        return _hourlyRate * _hoursWorked * 0.1m; // 10% bonus
    }
}

class Program
{
    static void Main(string[] args)
    {
        SalariedEmployee salariedEmployee = new SalariedEmployee("John Doe", 35, 50000.00m, 0.1m);
        salariedEmployee.PrintDetails();

        Console.WriteLine();

        HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane Smith", 28, 25.00m, 160);
        hourlyEmployee.PrintDetails();

        Console.ReadLine();
    }
}
