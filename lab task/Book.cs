namespace lab_task
{
    public class Book
    {
        private static int _id;
        public int ID { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }

        public Book(string title, string author, int publishedYear)
        {
            ID = ++_id;
            Title = title;
            Author = author;
            PublishedYear = publishedYear;
        }

        public string BookInfo()
        {
            return $"ID: {ID} \nTitle: {Title} \nAuthor: {Author} \nPublished Year: {PublishedYear}";
        }
        
    }
}
