namespace BlazoreCommerce.Context
{
    using Microsoft.EntityFrameworkCore;
    using BlazoreCommerce.Shared;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) 
            : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }

    }
    
}
