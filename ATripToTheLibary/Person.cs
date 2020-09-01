using System.Collections.Generic;

namespace ATripToTheLibary
{
    public class Person
    {
        //constructor
        public Person()
        {
            stackOfBooks = new Stack<Book>();
        }
        //calling BookManager
        BookManager bm = new BookManager();
        Stack<Book> stackOfBooks = new Stack<Book>();

        public Stack<Book> StackOfBooks
        {
            get => stackOfBooks;
            set => stackOfBooks = value;
        }
        
        //the users basket of books
        public Stack<Book> Bascket()
        {
            stackOfBooks.Push(bm.Available[0]);
            stackOfBooks.Push(bm.Available[1]);
            stackOfBooks.Push(bm.Available[2]);

            return stackOfBooks;
        }

        //ching out the books that the users are choising
        public void BorrowAllBooks()
        {
            while (stackOfBooks.Count != 0)
            {
                bm.Available.Remove(stackOfBooks.Pop());
            }
        }
    }
}