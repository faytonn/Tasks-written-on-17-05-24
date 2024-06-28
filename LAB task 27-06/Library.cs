using System.Net;

namespace LAB_task_27_06
{
    public class Library : Base
    {
        public Book[] Books;
        private static int _id;
        public Library(string name) : base(name)
        {
            Id = ++_id;
            Name = name;

        }


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public void ListAllBooks()
        {
            foreach (Book book in Books)
            {
                book.GetInfo();
            }
        }

    }
}
