namespace StorageApp.DataAccess
{
    using StorageApp.Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}