namespace BlazoreCommerce.Server.Database
{
    using Microsoft.EntityFrameworkCore;
    using BlazoreCommerce.Shared;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
            SeedDB();
        }

        public DbSet<Product> Products { get; set; }


        public void SeedDB()
        {
            if (!this.Products.Any())
            {
                List<Product> productList = new List<Product>()
                {
                    new Product
                    {
                        Title="PATRIZIA PEPE Блуза",
                        Description ="Арт. №: OC-Pepe-1C1342-A432-FE40",
                        Price = 329m,
                        Url="https://allinone.bg/uploads/product-image/image/380x608/1C1342_A432_FE40_1.jpg"
                    },
                      new Product
                    {
                        Title="PATRIZIA PEPE рокля",
                        Description ="Арт. №: OC-Pepe-1A2238-A432-FE40",
                        Price = 778,
                        Url="https://allinone.bg/uploads/product-image/image/original/1A2238_A432_FE40_2.jpg"
                    },
                      new Product
                    {
                        Title="PATRIZIA PEPE рокля",
                        Description ="Арт. №: OC-Pepe-2A2508-K024-J3Q8",
                        Price = 544,
                        Url="https://allinone.bg/uploads/product-image/image/original/2A2508_K024_J3Q8_2.jpg"
                    },
                };

                this.Products.AddRange(productList);
                this.SaveChanges();
            }
        }
    }
}
