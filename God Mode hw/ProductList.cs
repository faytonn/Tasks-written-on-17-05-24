namespace God_Mode_hw;

public class ProductList
{
    private Product[] Products;
    private int Count;
    public ProductList()
    {
        Products = new Product[0];

    }

    public Product this[int i]
    {
        get { return Products[i]; }
        set { Products[i] = value; }
    }

    public void Add(Product product)
    {
        if (Count < Products.Length)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[^1] = product;
        }
        else
        {
            Console.WriteLine("Product list exceeded.");
        }
    }

    public void Remove(int id)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Products[i].Id == id)
            {
                for (int j = 0; j < Count - 1; j++)
                {
                    Products[j] = Products[j + 1];
                }
                Count--;
                break;
            }
        }


    }

    public Product FindById(int id)
    {
        foreach (Product product in Products)
        {
            if (product.Id == id)
            {
                return product;
            }
        }
        return null;
    }

}
