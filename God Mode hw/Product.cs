namespace God_Mode_hw
{
    public class Product
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Product(string name, int stock, double price)
        {
            Id = ++_id;
            Name = name;
            Stock = stock;
            Price = price;
        }

        
    }
}
