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
    [Migration("20230528171137_Categories")]
    partial class Categories
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
                            Url = "hhttps://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg"
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
#pragma warning restore 612, 618
        }
    }
}
