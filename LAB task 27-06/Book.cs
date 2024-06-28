namespace LAB_task_27_06
{
    public class Book : Base
    {
        private static int _id;
        public string Author { get; set; }
        public Category Category { get; set; }



        public Book(string name, string author, Category category) : base(name)
        {
            Name = name;
            Author = author;
            Category = category;
        }
        public void GetInfo()
        {
            Console.WriteLine($" ID: {Id} \tAuthor: {Author} \tName: {Name} \tCategory: {Category}");
        }
    }
}
