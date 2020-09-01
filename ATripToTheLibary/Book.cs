
namespace ATripToTheLibary
{
    public class Book
    {
        //deafult constructor
        public Book()
        {
            
        }
        
        private string titel;
        
        public string Titel
        {
            get { return this.titel; }
            set { this.titel = value; }
        }
        
        public override string ToString()
        {
            return "Titel: " + Titel;
        }
    }
}