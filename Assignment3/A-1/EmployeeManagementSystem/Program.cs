using System.IO;
using System;

class Employee
{
    public double Salary;
    public virtual double CalculateSalary() { return this.Salary; }
}

class Manager : Employee
{

    double PA;
    double FA;
    double OA;

    public Manager(double salary)
    {
        this.Salary = salary;
    }
    public double getPA()
    {
        return this.Salary * 0.08;
    }
    public double getFA()
    {
        return this.Salary * 0.13;
    }
    public double getOA()
    {
        return this.Salary * 0.03;
    }
    public double GrossSalary()
    {
        return (this.getPA() + this.getFA() + this.getOA());
    }
    public override double CalculateSalary()
    {
        return (this.Salary + this.GrossSalary());
    }
}

class MarketingExecutive : Employee
{
    double KmTrav;
    double TourA;
    int TeleA = 1000;

    public MarketingExecutive() { }
    public MarketingExecutive(double kmt, double salary)
    {
        this.KmTrav = kmt;
        this.Salary = salary;
    }
    public double getTA()
    {
        return (this.KmTrav * 5);
    }
    public double GrossSalary()
    {
        return (1000 + this.getTA());
    }
    public override double CalculateSalary()
    {
        return (this.Salary + this.GrossSalary());
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for Manager \nEnter 2 for Marketing Executive");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Manager m1 = new Manager(salary);
            Console.WriteLine("Final Salary : " + m1.CalculateSalary());
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter Kilometer travelled and Salary : ");
            double kmt = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            MarketingExecutive me1 = new MarketingExecutive(kmt, salary);
            Console.WriteLine("Final Salary : " + me1.CalculateSalary());
        }
        else
        {
            Console.WriteLine("Wrong Choice");
        }
    }
}