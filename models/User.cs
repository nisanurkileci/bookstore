﻿namespace bookstore.models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
    public enum UserRole
    {
        Buyer,
        Seller,
        Admin
    }
}