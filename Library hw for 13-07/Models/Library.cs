using _11_7_24.Classes;

namespace Library_hw_for_13_07.Models
{
    public class Library
    {
        public int BookLimit { get; set; }
        private Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }
    }
}
