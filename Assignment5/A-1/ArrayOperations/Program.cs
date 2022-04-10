using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 for String Array and 2 for Interger Array");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            Console.WriteLine("Enter no. of elements to be inserted.");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter elements..");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }
            string[] temp = arr;
            Array.Reverse(temp);
            Console.WriteLine("Reversed Array : ");
            foreach(string i in temp)
            {
                Console.WriteLine(i + " ");
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted Array : ");
            foreach (string i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Array.Clear(arr);
        }
        else if(choice == 2)
        {
            Console.WriteLine("Enter no. of elements to be inserted.");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter elements..");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] temp = arr;
            Array.Reverse(temp);
            Console.WriteLine("Reversed Array : ");
            foreach(int i in temp)
            {
                Console.WriteLine(i + " ");
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted Array : ");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Array.Clear(arr);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
