namespace bookstore.models
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public ShoppingCart Cart { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
