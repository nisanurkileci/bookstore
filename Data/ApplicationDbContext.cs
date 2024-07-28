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
        public DbSet<User> Users { get; set; } // Users DbSet'ini ekleyin
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime BookDate { get; set; }
    }

    public class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
    }

    public class Buyer
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
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

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Buyer,
        Seller
    }
}
