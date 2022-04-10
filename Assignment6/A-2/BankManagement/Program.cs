using System;

class Account
{
    int accountNumber;
    string customerName;
    double balance = 0.0;

    public Account(int accountNumber, string customerName, double balance)
    {
        this.accountNumber = accountNumber;
        this.customerName = customerName;
        this.balance = balance;
    }
    public void Withdraw(double amount)
    {
        if(this.balance == 0)
        {
            Console.WriteLine("Zero Balance.");
        }
        else if(this.balance < amount)
        {
            Console.WriteLine("Under Balance.");
        }
        else
        {
            this.balance -= amount;
            Console.WriteLine("Current Balance : {0}", balance);
        }
    }
    public void Deposite(double amount)
    {
        this.balance += amount;
        Console.WriteLine("Current Balance : {0}", balance);
    }
    public double checkBalance()
    {
        return this.balance;
    }
}

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Account Number");
        int accNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Customer Name");
        string custName = Console.ReadLine();
        Console.WriteLine("Enter Current Balance");
        double balance = double.Parse(Console.ReadLine());
        Account account = new Account(accNum, custName, balance);
        while (true)
        {
            Console.WriteLine("Enter 1 to Withdraw, 2 to deposite and 3 to check the current balance");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("Enter amount to withdraw");
                double amt = double.Parse(Console.ReadLine());
                account.Withdraw(amt);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter amount to deposite");
                double amt = double.Parse(Console.ReadLine());
                account.Deposite(amt);
            }
            else if(choice == 3)
            {
                Console.WriteLine(account.checkBalance());
            }
            else
            {
                break;
            }
        }
    }
}