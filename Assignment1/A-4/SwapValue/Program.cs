using System.IO;
using System;
class Program
{
    public static void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    static void Main()
    {
        int num1, num2;
        Console.WriteLine("Enter two numbers to swap \n");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Before Swapping num1 : {0}, num2 : {1} \n", num1, num2);
        Swap(ref num1, ref num2);
        Console.WriteLine("After Swapping num1 : {0}, num2 : {1}", num1, num2);
    }
}