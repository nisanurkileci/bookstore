namespace bookstore.models
{
    public class Seller : User
    {
        public List<Book> Books { get; set; }
        public SalesStatistics SalesStats { get; set; }
    }
}
