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

        public DbSet<ProductType> ProductTypes { get; set; }    

        public DbSet<ProductVariant> ProductVariants { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(x => new { x.ProductId, x.ProductTypeId});

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    Id = 1,
                    Name = "Размер рокли",
                    Value = "38"
                },
                new ProductType
                {
                    Id = 2,
                    Name = "Размер рокли",
                    Value = "40"
                },
                new ProductType
                {
                    Id = 3,
                    Name = "Размер рокли",
                    Value = "42"
                },
                new ProductType
                {
                    Id = 4,
                    Name = "Размер рокли",
                    Value = "44"
                },
                new ProductType
                {
                    Id = 5,
                    Name = "Размер IT",
                    Value = "O"
                },
                new ProductType
                {
                    Id = 6,
                    Name = "Размер IT",
                    Value = "I"
                },
                new ProductType
                {
                    Id = 7,
                    Name = "Размер IT",
                    Value = "III"
                },
                new ProductType
                {
                    Id = 8,
                    Name = "Размер IT",
                    Value = "IV"
                });

            modelBuilder.Entity<Product>()
                .HasData(
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
                     Url = "https://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg",
                     CategoryId = 3
                 },
                 new Product
                 {
                     Id = 5,
                     Title = "PATRIZIA PEPE блуза",
                     Description = "\r\nPATRIZIA PEPE\r\nБлуза\r\n202,00 лв.289,00 лв. 30 \r\nИзберете размер:\r\nКой размер съм?\r\nДОБАВИ В КОЛИЧКАТА\r\nАрт. №: OC-Pepe-1C1342-AD08-CA08\r\n\r\nПолиестер: 100%\r\nGeorgette crêpe\r\nСвободна кройка\r\nДълги ръкави\r\nДетайл Муха\r\nМоделът е висок 1,76 см и носи размер IT 40/S/0",
                     Price = 400,
                     Url = "https://allinone.bg/uploads/product-image/image/original/1C1342_AD08_CA08_1.jpg",
                     CategoryId = 2
                 });


            modelBuilder.Entity<ProductVariant>()
                .HasData(
                new ProductVariant { ProductId = 1, ProductTypeId = 5 },
                new ProductVariant { ProductId = 1, ProductTypeId = 6 },
                new ProductVariant { ProductId = 1, ProductTypeId = 7 },
                new ProductVariant { ProductId = 1, ProductTypeId = 8 },

                new ProductVariant { ProductId = 2, ProductTypeId = 1 },
                new ProductVariant { ProductId = 2, ProductTypeId = 2 },
                new ProductVariant { ProductId = 2, ProductTypeId = 3 },
                new ProductVariant { ProductId = 2, ProductTypeId = 4 },

                new ProductVariant { ProductId = 3, ProductTypeId = 5 },
                new ProductVariant { ProductId = 3, ProductTypeId = 6 },
                new ProductVariant { ProductId = 3, ProductTypeId = 7 },
                new ProductVariant { ProductId = 3, ProductTypeId = 8 },

                new ProductVariant { ProductId = 4, ProductTypeId = 1 },
                new ProductVariant { ProductId = 4, ProductTypeId = 2 },
                new ProductVariant { ProductId = 4, ProductTypeId = 3 },
                new ProductVariant { ProductId = 4, ProductTypeId = 4 },

                new ProductVariant { ProductId = 5, ProductTypeId = 1 },
                new ProductVariant { ProductId = 5, ProductTypeId = 2 },
                new ProductVariant { ProductId = 5, ProductTypeId = 3 },
                new ProductVariant { ProductId = 5, ProductTypeId = 4 }
                );


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
