using System;

public delegate int EmployeeIdDelegate();
public delegate string EmployeeNameDelegate();
class Employee
{
    int empId;
    string empName;
    public Employee(int id, string name)
    {
        empId = id;
        empName = name;
    }
    public int EmployeeId()
    {
        return empId;
    }
    public string EmployeeName()
    {
        return empName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Employee Id");
        int empId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        string empName = Console.ReadLine();
        Employee emp = new Employee(empId, empName);
        EmployeeIdDelegate id = new EmployeeIdDelegate(emp.EmployeeId);
        EmployeeNameDelegate name = new EmployeeNameDelegate(emp.EmployeeName);

        int i = id();
        string s = name();
        Console.WriteLine("Employee Id : " + i);
        Console.WriteLine("Employee Name : " + s);
        
    }
}