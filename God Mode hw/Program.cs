using God_Mode_hw;


OnlineMarket onlineMarket = new OnlineMarket("FatiMart");

bool systemProcess = true;

while (systemProcess)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("[1] Add Product to Market");
    Console.WriteLine("[2] Remove Product from Market");
    Console.WriteLine("[3] Add Product to Cart");
    Console.WriteLine("[4] Show Products in Market");
    Console.WriteLine("[5] Show Products in Cart");
    Console.WriteLine("[0] Exit");

    int command = int.Parse(Console.ReadLine());

    switch (command)
    {
        case 1:
            Console.WriteLine("Enter product details");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(name, stock, price);
            onlineMarket.Products.Add(product);

            Console.WriteLine($"Product '{name}' added to the market.");
            break;
        case 2:
            Console.Write("Enter the ID of the product you want to remove: ");
            int idToRemove = int.Parse(Console.ReadLine());

            Product removedProduct = onlineMarket.Products.FindById(idToRemove);
            if(removedProduct != null)
            {
                onlineMarket.Products.Remove(idToRemove);
                Console.WriteLine($"Product '{removedProduct}' removed from the market.");
            }
            else
            {
                Console.WriteLine($"Product with the ID '{idToRemove}' not found, please write a valid ID.");
            }
            break;
        case 3:
            Console.Write("Enter the desired product's ID: ");
            int idToAdd = int.Parse(Console.ReadLine());

            Product productToAdd = onlineMarket.Products.FindById(idToAdd);

            if(productToAdd != null)
            {
                Console.Write("Enter the desired quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                onlineMarket.AddToCart(idToAdd, quantity);
                Console.WriteLine($"{quantity} units of '{productToAdd.Name}' added to the cart");

            }
            else
            {
                Console.WriteLine($"Product with the ID '{idToAdd}' not found, please write a valid ID.");
            }
            break;
        case 4:
            Console.WriteLine("All available products in FatiMart:");
            for (int i = 0; i < onlineMarket.Products.Length; i++) 
            {
                Product productMarket = onlineMarket.Products[i];
                if (productMarket != null)
                {
                    Console.WriteLine($"ID: {productMarket.Id} \tName: {productMarket.Name} \tStock: {productMarket.Stock} \tPrice: {productMarket.Price}");
                }
            }
            break;
        case 5:
            Console.WriteLine("All products in your cart: ");

            for(int i = 0; i < onlineMarket.Cart.Length; i++)
            {
              CartItem cartItem = onlineMarket.Cart[i];
                if (cartItem != null)
                {
                    Console.WriteLine($"ID: {cartItem.Id} \tName: {cartItem.Name} \tQuantity: {cartItem.Quantity} \tPrice: {cartItem.Price}");

                }

            }
            Console.WriteLine("Total Price: ");
            double totalPrice = 0;
            foreach(var cartItem in onlineMarket.Cart)
            {
                totalPrice = totalPrice + (cartItem.Price * cartItem.Quantity);
            }
            break;
        case 0:
            Console.WriteLine("Terminating program...");
            systemProcess = false;
            break;
        default:
            Console.WriteLine("Invalid command, please try again");
            break;
    }
}