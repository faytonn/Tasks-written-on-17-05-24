using System.Net.Http.Headers;

namespace God_Mode_hw
{
    public class OnlineMarket
    {
        public ProductList Products { get; set; }
        public CartItemList Cart { get; set; }
        public string Name { get; set; }
        public int Id { get; }
        private static int _id;



        public OnlineMarket(string name)
        {
            Id = ++_id;
            Name = name;
            Cart = new CartItemList();
            Products = new ProductList();
        }

        public void AddToCart(int productId, int quantity)
        {
            Product productToAdd = Products.FindById(productId);
            CartItem cartItem = Cart.FindById(productId);

            if (productToAdd.Stock >= quantity)
            {
                if (cartItem != null)
                {
                    cartItem.Quantity += quantity;
                }
                else
                {
                    Cart.Add(new CartItem(productToAdd.Name, quantity, productToAdd.Price));
                }
                productToAdd.Stock = productToAdd.Stock - quantity;
            }
            else
            {
                Console.WriteLine("Product not found or your desired quantity exceeded our stock.");
            }

        }

        public void ShowProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Stock: {3}", product.Id, product.Name, product.Price, product.Stock);
            }
        }

        public void ShowCart()
        {
            foreach (var cartItem in Cart)
            {
                Console.WriteLine(cartItem);
            }
        }


    }
}
