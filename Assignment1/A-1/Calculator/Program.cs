using System.IO;
using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter two space separated integers");
        string[] input = Console.ReadLine().Split();
        int num1 = 0, num2 = 0, result = 0, op = 0;
        num1 = int.Parse(input[0]);
        num2 = int.Parse(input[1]);
        Console.WriteLine("Press 1 for Addition \n Press 2 for Substaction \n Press 3 for multiplication \n Press 4 for division");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
        }
        Console.WriteLine("Result : " + result);
    }

}