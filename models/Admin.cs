namespace bookstore.models
{
    public class Admin :User
    {
        public void ApproveSeller(Seller seller) { /* Satıcı onaylama işlemleri */ }
        public void ManageUsers(List<User> users) { /* Kullanıcı yönetimi işlemleri */ }
        public void ManageBooks(List<Book> books) { /* Kitap yönetimi işlemleri */ }
    }
}
