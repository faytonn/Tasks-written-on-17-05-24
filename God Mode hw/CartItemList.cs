namespace God_Mode_hw
{
    public class CartItemList
    {
        private List<CartItem> cart = new List<CartItem>();

        public CartItem this[int i]
        {
            get { return cart[i]; }
            set { cart[i] = value; }
        }

        public void Add(CartItem cart)
        {
            this.cart.Add(cart);
        }
    }

}
