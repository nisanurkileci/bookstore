namespace bookstore.models
{
    public class Buyer : User
    {
        public List<Order> OrderHistory { get; set; }
        public ShoppingCart Cart { get; set; }
    }
}
