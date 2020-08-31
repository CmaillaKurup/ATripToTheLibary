using System.Collections.Generic;
using ATripToTheLibary;

namespace ATripToTheLibary
{
    public class BookManager : Book
    {
        public List<Book> CreateBook(string title, string genre)
        {
            List<Book> b = new List<Book>();
            b.Add(new Book(){Titel = "Asterix", Genre = "Children"});
            b.Add(new Book(){Titel = "I Østen Stiger Solen Op", Genre = "Religion"});
            b.Add(new Book(){Titel = "Romeo and Juliet", Genre = "Drama"});
            b.Add(new Book(){Titel = "Out of control", Genre = "Crime"});

            return b;
        }
    }
}