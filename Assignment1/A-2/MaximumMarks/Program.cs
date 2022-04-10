using System.IO;
using System;
class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int maxMarks = 0;
        Console.WriteLine("Enter marks of five students\n");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
            maxMarks = Math.Max(maxMarks, marks[i]);
        }
        Console.WriteLine("Maximum Marks : " + maxMarks);
        Console.ReadKey();
    }
}