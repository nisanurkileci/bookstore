
using bookstore.models;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace bookstore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime BookDate { get; set; }
    }

    public class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string Contact { get; set; }
    }

    public class Buyer
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public string Contact { get; set; }
    }

    public class Sale
    {
        public int SaleId { get; set; }
        public int BookId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public DateTime SaleDate { get; set; }
        public Book Book { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
    }
}
