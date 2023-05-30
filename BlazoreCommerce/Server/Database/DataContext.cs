namespace BlazoreCommerce.Server.Database
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

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "PATRIZIA PEPE Блуза",
                     Description = "Арт. №: OC-Pepe-1C1342-A432-FE40",
                     Price = 329m,
                     Url = "https://allinone.bg/uploads/product-image/image/380x608/1C1342_A432_FE40_1.jpg",
                     CategoryId = 2
                 },
                 new Product
                 {   Id = 2,
                     Title = "PATRIZIA PEPE рокля",
                     Description = "Арт. №: OC-Pepe-1A2238-A432-FE40",
                     Price = 778,
                     Url = "https://allinone.bg/uploads/product-image/image/original/1A2238_A432_FE40_2.jpg",
                     CategoryId = 1
                 },
                 new Product
                 {
                     Id=3,
                     Title = "PATRIZIA PEPE рокля",
                     Description = "Арт. №: OC-Pepe-2A2508-K024-J3Q8",
                     Price = 544,
                     Url = "https://allinone.bg/uploads/product-image/image/original/2A2508_K024_J3Q8_2.jpg",
                     CategoryId = 1
                 },
                 new Product
                 {
                     Id = 4,
                     Title = "BARBOUR палто",
                     Description = "Арт. №: OC-BRB-LWO0222-BK12\r\n\r\nПолиестер: 23%\r\nПолиамид: 10%\r\nВълна: 65%\r\nАкрил: 2%\r\n- Свободна кройка",
                     Price = 400,
                     Url = "hhttps://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg",
                     CategoryId = 3
                 });





            modelBuilder.Entity<Category>().HasData(
                 new Category
                 {
                     Id = 1,
                     Name = "Dress",
                     Url = "dresses"
                 },
                 new Category
                 {
                     Id = 2,
                     Name = "Shurt",
                     Url = "shurts"
                 },
                 new Category
                 {
                     Id = 3,
                     Name = "Coat",
                     Url = "coats"
                 });



            base.OnModelCreating(modelBuilder);
        }
      
    }
}
