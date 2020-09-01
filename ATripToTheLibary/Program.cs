using System;

namespace ATripToTheLibary
{
    class Program
    {
        static void Main(string[] args)
        {
            //conecting Person to the main
            Person p = new Person();
            p.StackOfBooks = p.Bascket();
            
            //shows the amount of books in the basket
            Console.WriteLine(p.StackOfBooks.Count);
            
            //shows wich books that are cosing
            foreach (Book aPart in p.StackOfBooks)
            {
                Console.WriteLine(aPart);
            }
            //takes thoes books and add them to the ones the user want with him home
            p.BorrowAllBooks();
            
            //shows the amaunt that he has chosen that had not been borrowed
            Console.WriteLine(p.StackOfBooks.Count);
        }
    }
}