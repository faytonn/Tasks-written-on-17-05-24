using System.Net.Http.Headers;

namespace God_Mode_hw
{
    public class OnlineMarket
    {
        public ProductList Products { get; set; }
        public CartItemList Cart {  get; set; }
        public string Name { get; set; }
        public int Id { get; }
        private static int _id;

        public OnlineMarket(string name)
        {
            Id = ++_id;
            Name = name;
            Cart = new List<CartItem>();
            Products = new List<Product>();       
        }

        public void AddToCart(int productID, int quantity)
        {
            foreach(var item in Cart)
            {
                Cart.Add(item);
            }
        }

        public void ShowCart()
        {
            foreach(var item in Cart)
            {
                Console.WriteLine($");
            }
        }


    }
}
