using System.IO;
using System;

class Employee
{
    int EmpNo;
    string EmpName;
    double Salary;
    double HRA;
    double TA;
    double DA;
    double PF;
    double TDS;
    double NetSalary;
    double GrossSalary;

    public Employee() { }
    public Employee(int empNo, string empName, double salary)
    {
        this.EmpNo = empNo;
        this.EmpName = empName;
        this.Salary = salary;
    }
    public void setEmpNo(int empNo)
    {
        this.EmpNo = empNo;
    }
    public void setEmpName(string empName)
    {
        this.EmpName = empName;
    }
    public void setSalary(double salary)
    {
        this.Salary = salary;
    }
    public double getHRA()
    {
        if (this.Salary < 5000)
        {
            return this.Salary * 0.10;
        }
        else if (this.Salary < 10000)
        {
            return this.Salary * 0.15;
        }
        else if (this.Salary < 15000)
        {
            return this.Salary * 0.20;
        }
        else if (this.Salary < 20000)
        {
            return this.Salary * 0.25;
        }
        else
        {
            return this.Salary * 0.30;
        }
    }
    public double getTA()
    {
        if (this.Salary < 5000)
        {
            return this.Salary * 0.05;
        }
        else if (this.Salary < 10000)
        {
            return this.Salary * 0.10;
        }
        else if (this.Salary < 15000)
        {
            return this.Salary * 0.15;
        }
        else if (this.Salary < 20000)
        {
            return this.Salary * 0.20;
        }
        else
        {
            return this.Salary * 0.25;
        }
    }
    public double getDA()
    {
        if (this.Salary < 5000)
        {
            return this.Salary * 0.15;
        }
        else if (this.Salary < 10000)
        {
            return this.Salary * 0.20;
        }
        else if (this.Salary < 15000)
        {
            return this.Salary * 0.25;
        }
        else if (this.Salary < 20000)
        {
            return this.Salary * 0.30;
        }
        else
        {
            return this.Salary * 0.35;
        }
    }
    public double getGrossSalary()
    {
        return (this.Salary + getHRA() + getTA() + getDA());
    }
    public double getPF()
    {
        return (getGrossSalary() * 0.10);
    }
    public double getTDS()
    {
        return (getGrossSalary() * 0.18);
    }
    public double getNetSalary()
    {
        return (getGrossSalary() - (getPF() + getTDS()));
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Employee No, Employee Name and Employee Salary");
        int EmpNo = int.Parse(Console.ReadLine());
        string EmpName = Console.ReadLine();
        double EmpSalary = double.Parse(Console.ReadLine());
        Employee emp1 = new Employee(EmpNo, EmpName, EmpSalary);
        double GrossSalary = emp1.getGrossSalary();
        Console.WriteLine("Gross Salary : " + GrossSalary);
    }
}