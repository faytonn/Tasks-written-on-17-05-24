namespace God_Mode_hw
{
    public class ProductList
    {
        private List<Product> products = new List<Product>();

        public Product this[int i]
        {
            get { return products[i]; }
            set { products[i] = value; }
        }

        public void Add(Product product)
        {
            this.products.Add(product);
        }

        public void Remove(Product product, int id)
        {
            products.Remove(product);
        }

        public void FindById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine(product.);
                }
            }
        }
    }
}
