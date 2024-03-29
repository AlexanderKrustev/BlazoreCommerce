﻿// <auto-generated />
using BlazoreCommerce.Server.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazoreCommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230602114704_ProductVariantNavProperty")]
    partial class ProductVariantNavProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazoreCommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Dress",
                            Url = "dresses"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Shurt",
                            Url = "shurts"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Coat",
                            Url = "coats"
                        });
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Арт. №: OC-Pepe-1C1342-A432-FE40",
                            Price = 329m,
                            Title = "PATRIZIA PEPE Блуза",
                            Url = "https://allinone.bg/uploads/product-image/image/380x608/1C1342_A432_FE40_1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Арт. №: OC-Pepe-1A2238-A432-FE40",
                            Price = 778m,
                            Title = "PATRIZIA PEPE рокля",
                            Url = "https://allinone.bg/uploads/product-image/image/original/1A2238_A432_FE40_2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Арт. №: OC-Pepe-2A2508-K024-J3Q8",
                            Price = 544m,
                            Title = "PATRIZIA PEPE рокля",
                            Url = "https://allinone.bg/uploads/product-image/image/original/2A2508_K024_J3Q8_2.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Арт. №: OC-BRB-LWO0222-BK12\r\n\r\nПолиестер: 23%\r\nПолиамид: 10%\r\nВълна: 65%\r\nАкрил: 2%\r\n- Свободна кройка",
                            Price = 400m,
                            Title = "BARBOUR палто",
                            Url = "https://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "\r\nPATRIZIA PEPE\r\nБлуза\r\n202,00 лв.289,00 лв. 30 \r\nИзберете размер:\r\nКой размер съм?\r\nДОБАВИ В КОЛИЧКАТА\r\nАрт. №: OC-Pepe-1C1342-AD08-CA08\r\n\r\nПолиестер: 100%\r\nGeorgette crêpe\r\nСвободна кройка\r\nДълги ръкави\r\nДетайл Муха\r\nМоделът е висок 1,76 см и носи размер IT 40/S/0",
                            Price = 400m,
                            Title = "PATRIZIA PEPE блуза",
                            Url = "https://allinone.bg/uploads/product-image/image/original/1C1342_AD08_CA08_1.jpg"
                        });
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Размер рокли",
                            Value = "38"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Размер рокли",
                            Value = "40"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Размер рокли",
                            Value = "42"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Размер рокли",
                            Value = "44"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Размер IT",
                            Value = "O"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Размер IT",
                            Value = "I"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Размер IT",
                            Value = "III"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Размер IT",
                            Value = "IV"
                        });
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 5
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 6
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 7
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 8
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 4
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 5
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 6
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 7
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 8
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 4
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 4
                        });
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazoreCommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazoreCommerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazoreCommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazoreCommerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
