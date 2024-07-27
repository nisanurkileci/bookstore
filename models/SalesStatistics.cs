namespace bookstore.models
{
    public class SalesStatistics
    {
        public int SellerID { get; set; }
        public Seller Seller { get; set; }
        public int TotalBooksSold { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
