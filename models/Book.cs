namespace bookstore.models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int SellerID { get; set; }
        public Seller Seller { get; set; }
    }
}
