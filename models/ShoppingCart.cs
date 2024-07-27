namespace bookstore.models
{
    public class ShoppingCart
    {
        public int CartID { get; set; }
        public int BuyerID { get; set; }
        public Buyer Buyer { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
