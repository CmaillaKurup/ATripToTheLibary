using System.Collections.Generic;

namespace ATripToTheLibary
{
    public class Book
    {
        private string titel;
        private string genre;
        
        public string Titel
        {
            get { return this.titel; }
            set { this.titel = value; }
        }
        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public override string ToString()
        {
            return "Titel: " + Titel + ", Genre: " + Genre;
        }

        
    }
}