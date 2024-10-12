namespace HotCatCafe.Common.CartHelpers
{
    public class Cart
    {
        //sepet listesi

        public Dictionary<int, CartItem> MyCart = new Dictionary<int, CartItem>();

        //sepet metotları (eylemleri)

        public void AddItem(CartItem cartItem)
        {
            if (MyCart.ContainsKey(cartItem.Id))
            {
                MyCart[cartItem.Id].Quantity += 1;
                return;
            }
            MyCart.Add(cartItem.Id, cartItem);
        }

        public void UpdateItem(int key, int quantity)
        {
            //todo
        }

        public void DeleteItem(int key)
        {
            //todo
        }
    }
}
