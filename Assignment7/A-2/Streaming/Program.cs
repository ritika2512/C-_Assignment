using System;
using System.IO;

public interface Iuser
{
    int getAccNumber();
    string getUserName();
    double getBalance();
}

class User : Iuser
{
    int accountNumber;
    string userName;
    double balance =0.0;

    public User(int accountNumber, string userName, double balance)
    {
       this.accountNumber = accountNumber;
       this.userName = userName;
       this.balance = balance;
    }

    public int getAccNumber()
    {
        return accountNumber;
    }
    public string getUserName()
    {
        return userName;
    }
    public double getBalance()
    {
        return this.balance;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Account Number");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter User Name");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter Balance");
        double balance = double.Parse(Console.ReadLine());

        User user = new User(accountNumber, userName, balance);
        using (StreamWriter sw = new StreamWriter(@"c:\temp\testfile.txt"))
        {
            sw.WriteLine(user.getAccNumber());
            sw.WriteLine(user.getUserName());
            sw.WriteLine(user.getBalance());
        }

        using (StreamReader sr = new StreamReader(@"c:\temp\testfile.txt"))
        {
            string s = " ";
            Console.WriteLine("\nUser Details");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}