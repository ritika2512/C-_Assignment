using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileStream F = new FileStream("file1.txt", FileMode.Create, FileAccess.ReadWrite);
        for (int i = 1; i <= 10; i++)
        {
            F.WriteByte((byte)i);
        }
        F.Position = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write(F.ReadByte() + " ");
        }
        string[] dirs = Directory.GetDirectories(@"c:\","p*", SearchOption.TopDirectoryOnly);
        Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
        foreach (string dir in dirs)
        {
            Console.WriteLine(dir);
        }

        //Creating and Deleting a Directory.
        DirectoryInfo direc = new DirectoryInfo(@"c:\temp");
        direc.Delete(true);

        F.Close();
    }
}