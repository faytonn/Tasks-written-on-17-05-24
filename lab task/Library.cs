namespace lab_task
{
    public class Library
    {
        private int index;
        public string Name { get; set; }
        private Book[] books;
        private static int id;

        public Library(string name): this()
        {
            Name = name;
            
        }
        public Library()
        {
            books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;

            Console.WriteLine("Book added");
        }

        public void RemoveBook(int id)
        {
        for(int i = 0; i < books.Length; i++)
            {
                if (books[i].ID == id) 
                {
                    for(int j = 0; j < books.Length - 1; j++) 
                    {
                        books[j] = books[j+1];
                    }
                    Array.Resize(ref books, books.Length - 1);
                    break;
                }
            } 
        }
        
        
        
        public void ShowBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
