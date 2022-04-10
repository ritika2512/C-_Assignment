using System;
using System.Collections;
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
        ArrayList empList = new ArrayList();
        while (true)
        {
            Console.WriteLine("Enter 1 to enter employee details \n2 to display employee details \n3 to exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter Employee Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string name = Console.ReadLine();
                empList.Add(new Employee(id, name));
             
            }
            else if(choice == 2)
            {
                foreach(Employee emp in empList)
                {
                    Console.WriteLine("Employee ID : {0}, Employee Name : {1}", emp.EmployeeId(), emp.EmployeeName());
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}