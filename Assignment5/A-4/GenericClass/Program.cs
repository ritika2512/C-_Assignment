using System;

class MyStack<T>
{
    int sizeOfStack;
    T[] array = new T[1000]; 
    int top;
    public MyStack(int size)
    {
        top = -1;
        this.sizeOfStack = size;
    }
    public void push(T item)
    {
        if (this.top == (this.sizeOfStack - 1))
        {
            Console.WriteLine("Stack Overflow\n");
        }
        else
        {
            this.top++;
            this.array[this.top] = item;
            Console.WriteLine("{0} is pushed into the array", item);
        }
    }
    public void pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow\n");
        }
        else
        {
            T popped = this.array[this.top];
            this.top--;
            Console.WriteLine("{0} Popped Successfully",popped);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter 1 to create Integer Stack and 2 to create String Stack");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter no. of elements to be inserted");
            int size = int.Parse(Console.ReadLine());
            MyStack<int> stack = new MyStack<int>(size);
            while (true)
            { 
                Console.WriteLine("\nEnter 1 to Push and 2 to Pull");
                int operation = int.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("Enter element to be pushed");
                    int element = int.Parse(Console.ReadLine());
                    stack.push(element);
                }
                else if (operation == 2)
                {
                    stack.pop();
                }
                else
                {
                    break;
                }
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter no. of elements to be inserted");
            int size = int.Parse(Console.ReadLine());
            MyStack<string> stack = new MyStack<string>(size);
            while (true)
            {
                Console.WriteLine("\nEnter 1 to Push and 2 to Pull");
                int operation = int.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("Enter element to be pushed");
                    string element = Console.ReadLine();
                    stack.push(element);
                }
                if (operation == 2)
                {
                    stack.pop();
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Choice.");
        }
    }
}