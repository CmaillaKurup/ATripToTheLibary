using System.Collections.Generic;

namespace ATripToTheLibary
{
    public class BookManager : Book
    {
        //making the List of availerble books
        private List<Book> available = new List<Book>();

        //get/set to the list of available
        public List<Book> Available
        {
            get => available;
            set => available = value;
        }

        //Making a constructor that takes the available books
        public BookManager()
        {
            available = BooksOnTheLibary();
        }

        //Making list of books on the libary
        public List<Book> BooksOnTheLibary()
        {
            List<Book> b = new List<Book>();
            b.Add(new Book(){Titel = "Case1"});
            b.Add(new Book(){Titel = "Case2"});
            b.Add(new Book(){Titel = "Case3"});
            b.Add(new Book(){Titel = "Case4"});
            b.Add(new Book(){Titel = "Case5"});

            return b;
        }
    }
}