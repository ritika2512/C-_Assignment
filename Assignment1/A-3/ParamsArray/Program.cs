using System.IO;
using System;
class Program
{
    public static int AddElements(params int[] arr)
    {
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        return sum;
    }
    public static void Main()
    {
        Console.WriteLine("Enter no. of elements to be summed\n");
        int noOfElements = int.Parse(Console.ReadLine());
        int[] arr = new int[noOfElements];
        for (int i = 0; i < noOfElements; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = AddElements(arr);
        Console.WriteLine(sum);
    }
}