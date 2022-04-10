using System.IO;
using System;
struct Book
{
    int _bookId;
    string _title;
    double _price;
    enum Type
    {
        Magazine = 1,
        Novel,
        ReferenceBook,
        Miscellaneous
    };
    Type _bookType;
    public void setBook(int bookId, string title, double price, int bookChoice)
    {
        this._bookId = bookId;
        this._title = title;
        this._price = price;
        this._bookType = (Type)bookChoice;
    }
    public void printBook()
    {
        Console.WriteLine("BookId : {0} \nTitle : {1} \nPrice : {2} \nBookType : {3}", this._bookId, this._title, this._price, this._bookType);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Book Id : ");
        int bookId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Book Title : ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Book Price : ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 1 for Magazine, 2 for Novel, 3 for Refrence Book and 4 for Miscellaneous");
        int choice = int.Parse(Console.ReadLine());
        Book b1 = new Book();
        b1.setBook(bookId, title, price, choice);
        b1.printBook();
    }
}