namespace God_Mode_hw
{
    public class CartItem
    {
        public int Id { get; set; }
        private static int _id;
        public string Name { get; set; } 
        public int Quantity { get; set; }
        public double Price { get; set; }

        public CartItem(string name, int quantity, double price)
        {
            Id = ++_id;
            Name = name;
            Quantity = quantity;    
            Price = price;
        }
    }
}
