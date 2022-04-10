using System.IO;
using System;

namespace StackImplementation
{
    class MyStack
    {
        int sizeOfArray;
        int[] array = new int[1000];
        int top;
        public MyStack(int size)
        {
            top = -1;
            this.sizeOfArray = size;
        }
        public void push(int item)
        {
            if (this.top == (this.sizeOfArray - 1))
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
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow\n");
                return -99;
            }
            else
            {
                int poppedItem = this.array[this.top];
                this.top--;
                return poppedItem;
            }
        }
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array");
        int size = int.Parse(Console.ReadLine());
        StackImplementation.MyStack stack = new StackImplementation.MyStack(size);
        while (true)
        {
            Console.WriteLine("Enter 1 to push\nEnter 2 to pop\nEnter 3 to exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter item to be pushed");
                int item = int.Parse(Console.ReadLine());
                stack.push(item);
            }
            else if (choice == 2)
            {
                int popped = stack.pop();
                if (popped != -99)
                {
                    Console.WriteLine("Popped Item : " + popped);
                }
            }
            else
            {
                break;
            }
        }
    }
}