namespace bookstore.models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int BuyerID { get; set; }
        public Buyer Buyer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
