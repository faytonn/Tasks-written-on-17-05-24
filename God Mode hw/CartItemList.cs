using System.Collections;

namespace God_Mode_hw
{
    public class CartItemList : IEnumerable<CartItem>
    {
        private CartItem[] CartItems;
        private int count;

        public IEnumerator<CartItem> GetEnumerator()
        {
            return ((IEnumerable<CartItem>)CartItems).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return CartItems.GetEnumerator();
        }
        

        public CartItem this[int i]
        {
            get { return CartItems[i]; }
            set { CartItems[i] = value; }
        }

        public void Add(CartItem cartItem)
        {
            if (count == CartItems.Length)
            {
                Array.Resize(ref CartItems, CartItems.Length + 1);
                CartItems[^1] = cartItem;
            }
        }

        public bool Exists(int id)
        {
            foreach(CartItem cartItem in this.CartItems)
            {
                if (cartItem.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public CartItem FindById(int id)
        {
            foreach (CartItem cart in CartItems)
            {
                if (cart.Id == id)
                {
                    return cart;
                }
            }
            return null;
        }
    }

}
